
namespace Pc_Auto_Shutdown
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnSd = new System.Windows.Forms.Button();
            this.BtnSleep = new System.Windows.Forms.Button();
            this.BtnReboot = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSd
            // 
            this.BtnSd.Location = new System.Drawing.Point(88, 78);
            this.BtnSd.Name = "BtnSd";
            this.BtnSd.Size = new System.Drawing.Size(178, 45);
            this.BtnSd.TabIndex = 0;
            this.BtnSd.Text = "Shutdown";
            this.BtnSd.UseVisualStyleBackColor = true;
            this.BtnSd.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnSleep
            // 
            this.BtnSleep.Location = new System.Drawing.Point(88, 164);
            this.BtnSleep.Name = "BtnSleep";
            this.BtnSleep.Size = new System.Drawing.Size(178, 45);
            this.BtnSleep.TabIndex = 1;
            this.BtnSleep.Text = "Sleep";
            this.BtnSleep.UseVisualStyleBackColor = true;
            this.BtnSleep.Click += new System.EventHandler(this.BtnSleep_Click);
            // 
            // BtnReboot
            // 
            this.BtnReboot.Location = new System.Drawing.Point(88, 256);
            this.BtnReboot.Name = "BtnReboot";
            this.BtnReboot.Size = new System.Drawing.Size(178, 45);
            this.BtnReboot.TabIndex = 2;
            this.BtnReboot.Text = "Restart";
            this.BtnReboot.UseVisualStyleBackColor = true;
            this.BtnReboot.Click += new System.EventHandler(this.BtnReboot_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(268, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(361, 339);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnReboot);
            this.Controls.Add(this.BtnSleep);
            this.Controls.Add(this.BtnSd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSd;
        private System.Windows.Forms.Button BtnSleep;
        private System.Windows.Forms.Button BtnReboot;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

