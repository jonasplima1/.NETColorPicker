using System;
using System.Drawing;
using System.Windows.Forms;

namespace ColorPicker
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnPick_Click(object sender, EventArgs e)
        {
            //Start the picker instance seting Menu as a parent
            Picker picker = new Picker();
            picker.ParentForm = this;
            picker.Show();
        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {
            //Update the value on the textbox to picked HEX
            var hex = this.txtHEX.Text;
            ChangeColor(hex);
        }

        private void ChangeColor(string hex)
        {
            try
            {
                //Transforms HEX value to RGB, then set the Backcolor as needed
                Color color = ColorTranslator.FromHtml(hex);
                this.pcimg.BackColor = color;
            }
            catch
            {

            }
        }
    }
}
