namespace ColorPicker
{
    partial class Picker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pickericon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pickericon)).BeginInit();
            this.SuspendLayout();
            // 
            // pickericon
            // 
            this.pickericon.BackColor = System.Drawing.Color.Transparent;
            this.pickericon.BackgroundImage = global::ColorPicker.Properties.Resources.picker;
            this.pickericon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pickericon.Location = new System.Drawing.Point(29, 31);
            this.pickericon.Name = "pickericon";
            this.pickericon.Size = new System.Drawing.Size(26, 26);
            this.pickericon.TabIndex = 0;
            this.pickericon.TabStop = false;
            this.pickericon.Click += new System.EventHandler(this.Picker_Click);
            // 
            // Picker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(84, 86);
            this.ControlBox = false;
            this.Controls.Add(this.pickericon);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Picker";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Picker";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Cyan;
            this.Load += new System.EventHandler(this.Picker_Load);
            this.Click += new System.EventHandler(this.Picker_Click);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Picker_KeyPress);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Picker_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pickericon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pickericon;
    }
}