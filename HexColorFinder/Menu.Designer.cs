﻿
namespace ColorPicker
{
    public partial class Menu
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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnPick = new System.Windows.Forms.Button();
            this.lblHEX = new System.Windows.Forms.Label();
            this.pcimg = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txtBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcimg)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPick
            // 
            this.btnPick.Location = new System.Drawing.Point(157, 25);
            this.btnPick.Name = "btnPick";
            this.btnPick.Size = new System.Drawing.Size(75, 23);
            this.btnPick.TabIndex = 0;
            this.btnPick.Text = "Pick";
            this.btnPick.UseVisualStyleBackColor = true;
            this.btnPick.Click += new System.EventHandler(this.btnPick_Click);
            // 
            // lblHEX
            // 
            this.lblHEX.AutoSize = true;
            this.lblHEX.Location = new System.Drawing.Point(119, 62);
            this.lblHEX.Name = "lblHEX";
            this.lblHEX.Size = new System.Drawing.Size(32, 13);
            this.lblHEX.TabIndex = 1;
            this.lblHEX.Text = "HEX:";
            // 
            // pcimg
            // 
            this.pcimg.BackColor = System.Drawing.Color.Black;
            this.pcimg.Location = new System.Drawing.Point(12, 25);
            this.pcimg.Name = "pcimg";
            this.pcimg.Size = new System.Drawing.Size(100, 53);
            this.pcimg.TabIndex = 2;
            this.pcimg.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 109);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(254, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(157, 59);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(75, 20);
            this.txtBox.TabIndex = 4;
            this.txtBox.Text = "#00000";
            this.txtBox.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            // 
            // Menu
            // 
            this.AccessibleDescription = "Menu";
            this.AccessibleName = "Menu";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 131);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pcimg);
            this.Controls.Add(this.lblHEX);
            this.Controls.Add(this.btnPick);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HexFinder";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPick;
        private System.Windows.Forms.Label lblHEX;
        private System.Windows.Forms.PictureBox pcimg;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.TextBox txtBox;
    }
}

