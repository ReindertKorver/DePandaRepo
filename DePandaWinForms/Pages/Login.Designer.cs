namespace DePandaWinForms.Pages
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.PinInput = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Pincode = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.PinInput);
            this.panel2.Location = new System.Drawing.Point(448, 492);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 154);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LoginBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 60);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 94);
            this.panel3.TabIndex = 10;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.LoginBtn.FlatAppearance.BorderSize = 2;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.LoginBtn.Location = new System.Drawing.Point(0, 0);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(300, 46);
            this.LoginBtn.TabIndex = 10;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click_1);
            // 
            // PinInput
            // 
            this.PinInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PinInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.PinInput.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PinInput.Location = new System.Drawing.Point(0, 0);
            this.PinInput.Margin = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.PinInput.MaxLength = 5;
            this.PinInput.Name = "PinInput";
            this.PinInput.PasswordChar = '*';
            this.PinInput.Size = new System.Drawing.Size(300, 26);
            this.PinInput.TabIndex = 8;
            this.PinInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PinInput.UseSystemPasswordChar = true;
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.Controls.Add(this.Pincode);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 38, 0, 0);
            this.panel4.Size = new System.Drawing.Size(1200, 458);
            this.panel4.TabIndex = 12;
            // 
            // Pincode
            // 
            this.Pincode.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pincode.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pincode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.Pincode.Location = new System.Drawing.Point(0, 401);
            this.Pincode.Margin = new System.Windows.Forms.Padding(4, 38, 4, 0);
            this.Pincode.Name = "Pincode";
            this.Pincode.Size = new System.Drawing.Size(1200, 57);
            this.Pincode.TabIndex = 12;
            this.Pincode.Text = "Pincode";
            this.Pincode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::DePandaWinForms.Properties.Resources.logindark;
            this.pictureBox1.Location = new System.Drawing.Point(0, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 38, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(0, 38, 0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(1200, 363);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.TextBox PinInput;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Pincode;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}