﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorPicker
{ 
    public partial class Picker : Form
    {
        public Menu ParentForm { get; set; }
        public Picker()
        {
            InitializeComponent();
        }

        private void Picker_Load(object sender, EventArgs e)
        {
            //Define background control to full screen
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;
        }

        private void Picker_MouseMove(object sender, EventArgs e)
        {
            //Make the picker icon move with the mouse
            Point mouse = PointToClient(MousePosition);
            pickericon.Location = new Point(mouse.X, mouse.Y - 20);
        }

        private void Picker_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Wait for ESC key to be pressed, then exit the picker instance 
            if (e.KeyChar == (char)27)
            {
                this.Close();
            }
        }

        //Method to get current color based on the cursor position
        [DllImport("user32.dll")]
        static extern bool GetCursorPos(ref Point lpPoint);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern int BitBlt(IntPtr hDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);
        private void Picker_Click(object sender, EventArgs e)
        {
            //Get current position of cursor
            Point cursor = new Point();
            GetCursorPos(ref cursor);

            //Calls the method to get the color based on the cursor position
            var c = GetColorAt(cursor);
            //Get BackColor property
            this.BackColor = c;
            //Close the picker instance
            this.Close();

            //Convert RGB values generated by the method to a true RGB value on the Color class
            Color myColor = Color.FromArgb(c.R, c.G, c.B);
            //Convert Color RGB value to HAX
            string hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
            //Calls the method to set label
            SetLabel(hex);
        }

        //Generates a small bitmap 1x1 pixel
        Bitmap screenPixel = new Bitmap(1, 1, PixelFormat.Format32bppArgb);
        public Color GetColorAt(Point location)
        {
            using (Graphics gdest = Graphics.FromImage(screenPixel))
            {
                using (Graphics gsrc = Graphics.FromHwnd(IntPtr.Zero))
                {
                    //Based on the bitmap generated, retrieves the max-color pixeled.
                    IntPtr hSrcDC = gsrc.GetHdc();
                    IntPtr hDC = gdest.GetHdc();
                    int retval = BitBlt(hDC, 0, 0, 1, 1, hSrcDC, location.X, location.Y, (int)CopyPixelOperation.SourceCopy);
                    gdest.ReleaseHdc();
                    gsrc.ReleaseHdc();
                }
            }

            return screenPixel.GetPixel(0, 0);
        }

        private void SetLabel (string hex)
        {
            ParentForm.txtBox.Text = "#" + hex;
        }
    }
}
