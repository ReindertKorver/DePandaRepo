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
            this.Title = new System.Windows.Forms.Label();
            this.MenuGrid = new System.Windows.Forms.DataGridView();
            this.MenuItemsList = new System.Windows.Forms.ListBox();
            this.ShowCreateMenuItemPanel = new System.Windows.Forms.Button();
            this.NameMenuItemInput = new System.Windows.Forms.TextBox();
            this.PriceMenuItemInput = new System.Windows.Forms.TextBox();
            this.MenuItemGroupBox = new System.Windows.Forms.GroupBox();
            this.AmountMenuItemInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CloseSelectedMenuItem = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CreateNewMenuItem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DescriptionMenuItemInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchMenuItemsList = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MenuGrid)).BeginInit();
            this.MenuItemGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 31, 4, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(1067, 46);
            this.Title.TabIndex = 13;
            this.Title.Text = "Menu";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MenuGrid
            // 
            this.MenuGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.MenuGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MenuGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MenuGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MenuGrid.Enabled = false;
            this.MenuGrid.Location = new System.Drawing.Point(0, 57);
            this.MenuGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MenuGrid.Name = "MenuGrid";
            this.MenuGrid.Size = new System.Drawing.Size(1067, 497);
            this.MenuGrid.TabIndex = 15;
            this.MenuGrid.Visible = false;
            // 
            // MenuItemsList
            // 
            this.MenuItemsList.FormattingEnabled = true;
            this.MenuItemsList.ItemHeight = 16;
            this.MenuItemsList.Location = new System.Drawing.Point(0, 121);
            this.MenuItemsList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MenuItemsList.Name = "MenuItemsList";
            this.MenuItemsList.ScrollAlwaysVisible = true;
            this.MenuItemsList.Size = new System.Drawing.Size(308, 372);
            this.MenuItemsList.TabIndex = 16;
            this.MenuItemsList.SelectedIndexChanged += new System.EventHandler(this.MenuItemsList_SelectedIndexChanged);
            // 
            // ShowCreateMenuItemPanel
            // 
            this.ShowCreateMenuItemPanel.Location = new System.Drawing.Point(103, 511);
            this.ShowCreateMenuItemPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShowCreateMenuItemPanel.Name = "ShowCreateMenuItemPanel";
            this.ShowCreateMenuItemPanel.Size = new System.Drawing.Size(207, 28);
            this.ShowCreateMenuItemPanel.TabIndex = 17;
            this.ShowCreateMenuItemPanel.Text = "Menu item aanmaken";
            this.ShowCreateMenuItemPanel.UseVisualStyleBackColor = true;
            this.ShowCreateMenuItemPanel.Click += new System.EventHandler(this.ShowMenuItemPanel);
            // 
            // NameMenuItemInput
            // 
            this.NameMenuItemInput.Location = new System.Drawing.Point(99, 34);
            this.NameMenuItemInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NameMenuItemInput.Name = "NameMenuItemInput";
            this.NameMenuItemInput.Size = new System.Drawing.Size(433, 22);
            this.NameMenuItemInput.TabIndex = 18;
            // 
            // PriceMenuItemInput
            // 
            this.PriceMenuItemInput.Location = new System.Drawing.Point(99, 84);
            this.PriceMenuItemInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PriceMenuItemInput.Name = "PriceMenuItemInput";
            this.PriceMenuItemInput.Size = new System.Drawing.Size(433, 22);
            this.PriceMenuItemInput.TabIndex = 19;
            // 
            // MenuItemGroupBox
            // 
            this.MenuItemGroupBox.Controls.Add(this.AmountMenuItemInput);
            this.MenuItemGroupBox.Controls.Add(this.label5);
            this.MenuItemGroupBox.Controls.Add(this.CloseSelectedMenuItem);
            this.MenuItemGroupBox.Controls.Add(this.button2);
            this.MenuItemGroupBox.Controls.Add(this.CreateNewMenuItem);
            this.MenuItemGroupBox.Controls.Add(this.button1);
            this.MenuItemGroupBox.Controls.Add(this.DescriptionMenuItemInput);
            this.MenuItemGroupBox.Controls.Add(this.label3);
            this.MenuItemGroupBox.Controls.Add(this.PriceMenuItemInput);
            this.MenuItemGroupBox.Controls.Add(this.label2);
            this.MenuItemGroupBox.Controls.Add(this.NameMenuItemInput);
            this.MenuItemGroupBox.Controls.Add(this.label1);
            this.MenuItemGroupBox.Location = new System.Drawing.Point(436, 57);
            this.MenuItemGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MenuItemGroupBox.Name = "MenuItemGroupBox";
            this.MenuItemGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MenuItemGroupBox.Size = new System.Drawing.Size(564, 292);
            this.MenuItemGroupBox.TabIndex = 20;
            this.MenuItemGroupBox.TabStop = false;
            this.MenuItemGroupBox.Text = "Menu item ";
            this.MenuItemGroupBox.Visible = false;
            // 
            // AmountMenuItemInput
            // 
            this.AmountMenuItemInput.Location = new System.Drawing.Point(99, 132);
            this.AmountMenuItemInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AmountMenuItemInput.Name = "AmountMenuItemInput";
            this.AmountMenuItemInput.Size = new System.Drawing.Size(433, 22);
            this.AmountMenuItemInput.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 135);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Hoeveelheid";
            // 
            // CloseSelectedMenuItem
            // 
            this.CloseSelectedMenuItem.Location = new System.Drawing.Point(364, 218);
            this.CloseSelectedMenuItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CloseSelectedMenuItem.Name = "CloseSelectedMenuItem";
            this.CloseSelectedMenuItem.Size = new System.Drawing.Size(113, 28);
            this.CloseSelectedMenuItem.TabIndex = 6;
            this.CloseSelectedMenuItem.Text = "Sluit scherm";
            this.CloseSelectedMenuItem.UseVisualStyleBackColor = true;
            this.CloseSelectedMenuItem.Click += new System.EventHandler(this.CloseMenuItemPanel);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(296, 218);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 28);
            this.button2.TabIndex = 8;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.EditSelectedMenuItem);
            // 
            // CreateNewMenuItem
            // 
            this.CreateNewMenuItem.Location = new System.Drawing.Point(99, 218);
            this.CreateNewMenuItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CreateNewMenuItem.Name = "CreateNewMenuItem";
            this.CreateNewMenuItem.Size = new System.Drawing.Size(129, 28);
            this.CreateNewMenuItem.TabIndex = 21;
            this.CreateNewMenuItem.Text = "Creër";
            this.CreateNewMenuItem.UseVisualStyleBackColor = true;
            this.CreateNewMenuItem.Click += new System.EventHandler(this.CreateMenuItem);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 218);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Del";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.DeleteSelectedMenuItem);
            // 
            // DescriptionMenuItemInput
            // 
            this.DescriptionMenuItemInput.Location = new System.Drawing.Point(99, 178);
            this.DescriptionMenuItemInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DescriptionMenuItemInput.Name = "DescriptionMenuItemInput";
            this.DescriptionMenuItemInput.Size = new System.Drawing.Size(433, 22);
            this.DescriptionMenuItemInput.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Notities";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prijs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naam";
            // 
            // SearchMenuItemsList
            // 
            this.SearchMenuItemsList.Location = new System.Drawing.Point(80, 73);
            this.SearchMenuItemsList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchMenuItemsList.Name = "SearchMenuItemsList";
            this.SearchMenuItemsList.Size = new System.Drawing.Size(228, 22);
            this.SearchMenuItemsList.TabIndex = 21;
            this.SearchMenuItemsList.TextChanged += new System.EventHandler(this.SearchMenuItems);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Zoek";
            // 
            // MenuPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SearchMenuItemsList);
            this.Controls.Add(this.MenuItemGroupBox);
            this.Controls.Add(this.ShowCreateMenuItemPanel);
            this.Controls.Add(this.MenuItemsList);
            this.Controls.Add(this.MenuGrid);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MenuPage";
            this.Text = "x";
            ((System.ComponentModel.ISupportInitialize)(this.MenuGrid)).EndInit();
            this.MenuItemGroupBox.ResumeLayout(false);
            this.MenuItemGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.DataGridView MenuGrid;
        private System.Windows.Forms.ListBox MenuItemsList;
        private System.Windows.Forms.Button ShowCreateMenuItemPanel;
        private System.Windows.Forms.TextBox NameMenuItemInput;
        private System.Windows.Forms.TextBox PriceMenuItemInput;
        private System.Windows.Forms.GroupBox MenuItemGroupBox;
        private System.Windows.Forms.TextBox DescriptionMenuItemInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CreateNewMenuItem;
        private System.Windows.Forms.TextBox SearchMenuItemsList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CloseSelectedMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox AmountMenuItemInput;
        private System.Windows.Forms.Label label5;
    }
}