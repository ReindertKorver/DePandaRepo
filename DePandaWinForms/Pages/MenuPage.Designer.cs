namespace DePandaWinForms.Pages
{
    partial class MenuPage
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
            this.Pincode = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MenuGrid = new System.Windows.Forms.DataGridView();
            this.MenuItemsList = new System.Windows.Forms.ListBox();
            this.AddMenuItemButton = new System.Windows.Forms.Button();
            this.NameNewMenuItemInput = new System.Windows.Forms.TextBox();
            this.PriceNewMenuItemInput = new System.Windows.Forms.TextBox();
            this.NewMenuItemGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NotitionNewMenuItemInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MenuGrid)).BeginInit();
            this.NewMenuItemGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pincode
            // 
            this.Pincode.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pincode.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pincode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.Pincode.Location = new System.Drawing.Point(0, 0);
            this.Pincode.Margin = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.Pincode.Name = "Pincode";
            this.Pincode.Size = new System.Drawing.Size(800, 37);
            this.Pincode.TabIndex = 13;
            this.Pincode.Text = "Menu";
            this.Pincode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Pincode.Click += new System.EventHandler(this.Pincode_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(627, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 29);
            this.textBox1.TabIndex = 14;
            // 
            // MenuGrid
            // 
            this.MenuGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.MenuGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MenuGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MenuGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MenuGrid.Enabled = false;
            this.MenuGrid.Location = new System.Drawing.Point(0, 46);
            this.MenuGrid.Name = "MenuGrid";
            this.MenuGrid.Size = new System.Drawing.Size(800, 404);
            this.MenuGrid.TabIndex = 15;
            this.MenuGrid.Visible = false;
            // 
            // MenuItemsList
            // 
            this.MenuItemsList.FormattingEnabled = true;
            this.MenuItemsList.Location = new System.Drawing.Point(0, 46);
            this.MenuItemsList.Name = "MenuItemsList";
            this.MenuItemsList.Size = new System.Drawing.Size(232, 355);
            this.MenuItemsList.TabIndex = 16;
            // 
            // AddMenuItemButton
            // 
            this.AddMenuItemButton.Location = new System.Drawing.Point(108, 415);
            this.AddMenuItemButton.Name = "AddMenuItemButton";
            this.AddMenuItemButton.Size = new System.Drawing.Size(124, 23);
            this.AddMenuItemButton.TabIndex = 17;
            this.AddMenuItemButton.Text = "Menu item aanmaken";
            this.AddMenuItemButton.UseVisualStyleBackColor = true;
            this.AddMenuItemButton.Click += new System.EventHandler(this.AddMenuItemButton_Click);
            // 
            // NameNewMenuItemInput
            // 
            this.NameNewMenuItemInput.Location = new System.Drawing.Point(74, 28);
            this.NameNewMenuItemInput.Name = "NameNewMenuItemInput";
            this.NameNewMenuItemInput.Size = new System.Drawing.Size(326, 20);
            this.NameNewMenuItemInput.TabIndex = 18;
            // 
            // PriceNewMenuItemInput
            // 
            this.PriceNewMenuItemInput.Location = new System.Drawing.Point(74, 68);
            this.PriceNewMenuItemInput.Name = "PriceNewMenuItemInput";
            this.PriceNewMenuItemInput.Size = new System.Drawing.Size(326, 20);
            this.PriceNewMenuItemInput.TabIndex = 19;
            // 
            // NewMenuItemGroupBox
            // 
            this.NewMenuItemGroupBox.Controls.Add(this.NotitionNewMenuItemInput);
            this.NewMenuItemGroupBox.Controls.Add(this.label3);
            this.NewMenuItemGroupBox.Controls.Add(this.PriceNewMenuItemInput);
            this.NewMenuItemGroupBox.Controls.Add(this.label2);
            this.NewMenuItemGroupBox.Controls.Add(this.NameNewMenuItemInput);
            this.NewMenuItemGroupBox.Controls.Add(this.label1);
            this.NewMenuItemGroupBox.Location = new System.Drawing.Point(327, 92);
            this.NewMenuItemGroupBox.Name = "NewMenuItemGroupBox";
            this.NewMenuItemGroupBox.Size = new System.Drawing.Size(423, 227);
            this.NewMenuItemGroupBox.TabIndex = 20;
            this.NewMenuItemGroupBox.TabStop = false;
            this.NewMenuItemGroupBox.Text = "Menu item aanmaken";
            this.NewMenuItemGroupBox.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prijs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Notities";
            // 
            // NotitionNewMenuItemInput
            // 
            this.NotitionNewMenuItemInput.Location = new System.Drawing.Point(74, 114);
            this.NotitionNewMenuItemInput.Name = "NotitionNewMenuItemInput";
            this.NotitionNewMenuItemInput.Size = new System.Drawing.Size(326, 20);
            this.NotitionNewMenuItemInput.TabIndex = 20;
            // 
            // MenuPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NewMenuItemGroupBox);
            this.Controls.Add(this.AddMenuItemButton);
            this.Controls.Add(this.MenuItemsList);
            this.Controls.Add(this.MenuGrid);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Pincode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPage";
            this.Text = "Reservations";
            ((System.ComponentModel.ISupportInitialize)(this.MenuGrid)).EndInit();
            this.NewMenuItemGroupBox.ResumeLayout(false);
            this.NewMenuItemGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Pincode;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView MenuGrid;
        private System.Windows.Forms.ListBox MenuItemsList;
        private System.Windows.Forms.Button AddMenuItemButton;
        private System.Windows.Forms.TextBox NameNewMenuItemInput;
        private System.Windows.Forms.TextBox PriceNewMenuItemInput;
        private System.Windows.Forms.GroupBox NewMenuItemGroupBox;
        private System.Windows.Forms.TextBox NotitionNewMenuItemInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}