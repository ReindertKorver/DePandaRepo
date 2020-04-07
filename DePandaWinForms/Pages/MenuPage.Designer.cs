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
            this.NameInput = new System.Windows.Forms.TextBox();
            this.PriceInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MenuGrid)).BeginInit();
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
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MenuGrid
            // 
            this.MenuGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.MenuGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MenuGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MenuGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MenuGrid.Location = new System.Drawing.Point(0, 46);
            this.MenuGrid.Name = "MenuGrid";
            this.MenuGrid.Size = new System.Drawing.Size(800, 404);
            this.MenuGrid.TabIndex = 15;
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
            this.AddMenuItemButton.Location = new System.Drawing.Point(157, 415);
            this.AddMenuItemButton.Name = "AddMenuItemButton";
            this.AddMenuItemButton.Size = new System.Drawing.Size(75, 23);
            this.AddMenuItemButton.TabIndex = 17;
            this.AddMenuItemButton.Text = "button1";
            this.AddMenuItemButton.UseVisualStyleBackColor = true;
            this.AddMenuItemButton.Click += new System.EventHandler(this.AddMenuItemButton_Click);
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(297, 340);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(100, 20);
            this.NameInput.TabIndex = 18;
            // 
            // PriceInput
            // 
            this.PriceInput.Location = new System.Drawing.Point(297, 380);
            this.PriceInput.Name = "PriceInput";
            this.PriceInput.Size = new System.Drawing.Size(100, 20);
            this.PriceInput.TabIndex = 19;
            // 
            // MenuPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PriceInput);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.AddMenuItemButton);
            this.Controls.Add(this.MenuItemsList);
            this.Controls.Add(this.MenuGrid);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Pincode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPage";
            this.Text = "Reservations";
            ((System.ComponentModel.ISupportInitialize)(this.MenuGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Pincode;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView MenuGrid;
        private System.Windows.Forms.ListBox MenuItemsList;
        private System.Windows.Forms.Button AddMenuItemButton;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.TextBox PriceInput;
    }
}