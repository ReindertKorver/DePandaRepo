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
            this.ShowCreateMenuItemPanel = new System.Windows.Forms.Button();
            this.NameNewMenuItemInput = new System.Windows.Forms.TextBox();
            this.PriceNewMenuItemInput = new System.Windows.Forms.TextBox();
            this.NewMenuItemGroupBox = new System.Windows.Forms.GroupBox();
            this.CreateNewMenuItem = new System.Windows.Forms.Button();
            this.DescriptionNewMenuItemInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchMenuItemsList = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SelectedMenuItemText = new System.Windows.Forms.GroupBox();
            this.CloseSelectedMenuItem = new System.Windows.Forms.Button();
            this.PriceSelectedMenuItem = new System.Windows.Forms.Label();
            this.NameSelectedMenuItem = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DescriptionSelectedMenuItem = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MenuGrid)).BeginInit();
            this.NewMenuItemGroupBox.SuspendLayout();
            this.SelectedMenuItemText.SuspendLayout();
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
            this.MenuItemsList.Location = new System.Drawing.Point(0, 98);
            this.MenuItemsList.Name = "MenuItemsList";
            this.MenuItemsList.Size = new System.Drawing.Size(232, 303);
            this.MenuItemsList.TabIndex = 16;
            this.MenuItemsList.SelectedIndexChanged += new System.EventHandler(this.MenuItemsList_SelectedIndexChanged);
            // 
            // ShowCreateMenuItemPanel
            // 
            this.ShowCreateMenuItemPanel.Location = new System.Drawing.Point(77, 415);
            this.ShowCreateMenuItemPanel.Name = "ShowCreateMenuItemPanel";
            this.ShowCreateMenuItemPanel.Size = new System.Drawing.Size(155, 23);
            this.ShowCreateMenuItemPanel.TabIndex = 17;
            this.ShowCreateMenuItemPanel.Text = "Menu item aanmaken";
            this.ShowCreateMenuItemPanel.UseVisualStyleBackColor = true;
            this.ShowCreateMenuItemPanel.Click += new System.EventHandler(this.ShowCreateMenuItemPanel_Click);
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
            this.NewMenuItemGroupBox.Controls.Add(this.CreateNewMenuItem);
            this.NewMenuItemGroupBox.Controls.Add(this.DescriptionNewMenuItemInput);
            this.NewMenuItemGroupBox.Controls.Add(this.label3);
            this.NewMenuItemGroupBox.Controls.Add(this.PriceNewMenuItemInput);
            this.NewMenuItemGroupBox.Controls.Add(this.label2);
            this.NewMenuItemGroupBox.Controls.Add(this.NameNewMenuItemInput);
            this.NewMenuItemGroupBox.Controls.Add(this.label1);
            this.NewMenuItemGroupBox.Location = new System.Drawing.Point(327, 46);
            this.NewMenuItemGroupBox.Name = "NewMenuItemGroupBox";
            this.NewMenuItemGroupBox.Size = new System.Drawing.Size(423, 227);
            this.NewMenuItemGroupBox.TabIndex = 20;
            this.NewMenuItemGroupBox.TabStop = false;
            this.NewMenuItemGroupBox.Text = "Menu item aanmaken";
            this.NewMenuItemGroupBox.Visible = false;
            // 
            // CreateNewMenuItem
            // 
            this.CreateNewMenuItem.Location = new System.Drawing.Point(74, 154);
            this.CreateNewMenuItem.Name = "CreateNewMenuItem";
            this.CreateNewMenuItem.Size = new System.Drawing.Size(97, 23);
            this.CreateNewMenuItem.TabIndex = 21;
            this.CreateNewMenuItem.Text = "Creër";
            this.CreateNewMenuItem.UseVisualStyleBackColor = true;
            this.CreateNewMenuItem.Click += new System.EventHandler(this.CreateNewMenuItem_Click);
            // 
            // DescriptionNewMenuItemInput
            // 
            this.DescriptionNewMenuItemInput.Location = new System.Drawing.Point(74, 114);
            this.DescriptionNewMenuItemInput.Name = "DescriptionNewMenuItemInput";
            this.DescriptionNewMenuItemInput.Size = new System.Drawing.Size(326, 20);
            this.DescriptionNewMenuItemInput.TabIndex = 20;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prijs";
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
            // SearchMenuItemsList
            // 
            this.SearchMenuItemsList.Location = new System.Drawing.Point(60, 59);
            this.SearchMenuItemsList.Name = "SearchMenuItemsList";
            this.SearchMenuItemsList.Size = new System.Drawing.Size(172, 20);
            this.SearchMenuItemsList.TabIndex = 21;
            this.SearchMenuItemsList.TextChanged += new System.EventHandler(this.SearchMenuItems);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Zoek";
            // 
            // SelectedMenuItemText
            // 
            this.SelectedMenuItemText.Controls.Add(this.CloseSelectedMenuItem);
            this.SelectedMenuItemText.Controls.Add(this.PriceSelectedMenuItem);
            this.SelectedMenuItemText.Controls.Add(this.NameSelectedMenuItem);
            this.SelectedMenuItemText.Controls.Add(this.label7);
            this.SelectedMenuItemText.Controls.Add(this.label6);
            this.SelectedMenuItemText.Controls.Add(this.DescriptionSelectedMenuItem);
            this.SelectedMenuItemText.Controls.Add(this.label5);
            this.SelectedMenuItemText.Location = new System.Drawing.Point(327, 279);
            this.SelectedMenuItemText.Name = "SelectedMenuItemText";
            this.SelectedMenuItemText.Size = new System.Drawing.Size(433, 159);
            this.SelectedMenuItemText.TabIndex = 23;
            this.SelectedMenuItemText.TabStop = false;
            this.SelectedMenuItemText.Text = "Informatie geselecteerde menu item";
            this.SelectedMenuItemText.Visible = false;
            // 
            // CloseSelectedMenuItem
            // 
            this.CloseSelectedMenuItem.Location = new System.Drawing.Point(341, 120);
            this.CloseSelectedMenuItem.Name = "CloseSelectedMenuItem";
            this.CloseSelectedMenuItem.Size = new System.Drawing.Size(85, 23);
            this.CloseSelectedMenuItem.TabIndex = 6;
            this.CloseSelectedMenuItem.Text = "Sluit scherm";
            this.CloseSelectedMenuItem.UseVisualStyleBackColor = true;
            this.CloseSelectedMenuItem.Click += new System.EventHandler(this.CloseSelectedMenuItem_Click);
            // 
            // PriceSelectedMenuItem
            // 
            this.PriceSelectedMenuItem.AutoSize = true;
            this.PriceSelectedMenuItem.Location = new System.Drawing.Point(105, 84);
            this.PriceSelectedMenuItem.Name = "PriceSelectedMenuItem";
            this.PriceSelectedMenuItem.Size = new System.Drawing.Size(35, 13);
            this.PriceSelectedMenuItem.TabIndex = 5;
            this.PriceSelectedMenuItem.Text = "label9";
            // 
            // NameSelectedMenuItem
            // 
            this.NameSelectedMenuItem.AutoSize = true;
            this.NameSelectedMenuItem.Location = new System.Drawing.Point(105, 43);
            this.NameSelectedMenuItem.Name = "NameSelectedMenuItem";
            this.NameSelectedMenuItem.Size = new System.Drawing.Size(35, 13);
            this.NameSelectedMenuItem.TabIndex = 4;
            this.NameSelectedMenuItem.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Naam ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Prijs";
            // 
            // DescriptionSelectedMenuItem
            // 
            this.DescriptionSelectedMenuItem.AutoSize = true;
            this.DescriptionSelectedMenuItem.Location = new System.Drawing.Point(105, 120);
            this.DescriptionSelectedMenuItem.Name = "DescriptionSelectedMenuItem";
            this.DescriptionSelectedMenuItem.Size = new System.Drawing.Size(35, 13);
            this.DescriptionSelectedMenuItem.TabIndex = 1;
            this.DescriptionSelectedMenuItem.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Extra info";
            // 
            // MenuPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SelectedMenuItemText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SearchMenuItemsList);
            this.Controls.Add(this.NewMenuItemGroupBox);
            this.Controls.Add(this.ShowCreateMenuItemPanel);
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
            this.SelectedMenuItemText.ResumeLayout(false);
            this.SelectedMenuItemText.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Pincode;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView MenuGrid;
        private System.Windows.Forms.ListBox MenuItemsList;
        private System.Windows.Forms.Button ShowCreateMenuItemPanel;
        private System.Windows.Forms.TextBox NameNewMenuItemInput;
        private System.Windows.Forms.TextBox PriceNewMenuItemInput;
        private System.Windows.Forms.GroupBox NewMenuItemGroupBox;
        private System.Windows.Forms.TextBox DescriptionNewMenuItemInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CreateNewMenuItem;
        private System.Windows.Forms.TextBox SearchMenuItemsList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox SelectedMenuItemText;
        private System.Windows.Forms.Label DescriptionSelectedMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label PriceSelectedMenuItem;
        private System.Windows.Forms.Label NameSelectedMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CloseSelectedMenuItem;
    }
}