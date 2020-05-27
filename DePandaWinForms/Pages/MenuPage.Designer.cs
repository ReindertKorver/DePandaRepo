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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.RightEditPanel = new DePandaWinForms.Design.PPanel();
            this.MenuItemGroupBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CategoryCB = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CreateNewMenuItem = new System.Windows.Forms.Button();
            this.AmountMenuItemInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DescriptionMenuItemInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PriceMenuItemInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameMenuItemInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LeftEditPanel = new DePandaWinForms.Design.PPanel();
            this.SearchMenuItemsList = new System.Windows.Forms.TextBox();
            this.ShowCreateMenuItemPanel = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MenuItemsList = new System.Windows.Forms.ListBox();
            this.MainPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.RightEditPanel.SuspendLayout();
            this.MenuItemGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.LeftEditPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.White;
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Margin = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(800, 37);
            this.Title.TabIndex = 13;
            this.Title.Text = "Menu";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Controls.Add(this.LeftPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 37);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(800, 413);
            this.MainPanel.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.RightEditPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(250, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5, 10, 10, 10);
            this.panel2.Size = new System.Drawing.Size(550, 413);
            this.panel2.TabIndex = 1;
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.White;
            this.LeftPanel.Controls.Add(this.LeftEditPanel);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Margin = new System.Windows.Forms.Padding(50);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Padding = new System.Windows.Forms.Padding(10, 10, 5, 10);
            this.LeftPanel.Size = new System.Drawing.Size(250, 413);
            this.LeftPanel.TabIndex = 0;
            // 
            // RightEditPanel
            // 
            this.RightEditPanel.BackColor = System.Drawing.Color.White;
            this.RightEditPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RightEditPanel.Controls.Add(this.MenuItemGroupBox);
            this.RightEditPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightEditPanel.Location = new System.Drawing.Point(5, 10);
            this.RightEditPanel.Name = "RightEditPanel";
            this.RightEditPanel.Padding = new System.Windows.Forms.Padding(10);
            this.RightEditPanel.Size = new System.Drawing.Size(535, 393);
            this.RightEditPanel.TabIndex = 0;
            // 
            // MenuItemGroupBox
            // 
            this.MenuItemGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.MenuItemGroupBox.Controls.Add(this.pictureBox2);
            this.MenuItemGroupBox.Controls.Add(this.label6);
            this.MenuItemGroupBox.Controls.Add(this.CategoryCB);
            this.MenuItemGroupBox.Controls.Add(this.panel1);
            this.MenuItemGroupBox.Controls.Add(this.AmountMenuItemInput);
            this.MenuItemGroupBox.Controls.Add(this.label5);
            this.MenuItemGroupBox.Controls.Add(this.DescriptionMenuItemInput);
            this.MenuItemGroupBox.Controls.Add(this.label3);
            this.MenuItemGroupBox.Controls.Add(this.PriceMenuItemInput);
            this.MenuItemGroupBox.Controls.Add(this.label2);
            this.MenuItemGroupBox.Controls.Add(this.NameMenuItemInput);
            this.MenuItemGroupBox.Controls.Add(this.label1);
            this.MenuItemGroupBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuItemGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuItemGroupBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.MenuItemGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(137)))), ((int)(((byte)(145)))));
            this.MenuItemGroupBox.Location = new System.Drawing.Point(10, 10);
            this.MenuItemGroupBox.Name = "MenuItemGroupBox";
            this.MenuItemGroupBox.Size = new System.Drawing.Size(515, 373);
            this.MenuItemGroupBox.TabIndex = 26;
            this.MenuItemGroupBox.TabStop = false;
            this.MenuItemGroupBox.Text = "Menu item ";
            this.MenuItemGroupBox.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label6.Location = new System.Drawing.Point(7, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "Categorie";
            // 
            // CategoryCB
            // 
            this.CategoryCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CategoryCB.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.CategoryCB.FormattingEnabled = true;
            this.CategoryCB.Location = new System.Drawing.Point(153, 185);
            this.CategoryCB.Name = "CategoryCB";
            this.CategoryCB.Size = new System.Drawing.Size(276, 33);
            this.CategoryCB.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.CreateNewMenuItem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 322);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 48);
            this.panel1.TabIndex = 24;
            // 
            // CreateNewMenuItem
            // 
            this.CreateNewMenuItem.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.CreateNewMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(137)))), ((int)(((byte)(145)))));
            this.CreateNewMenuItem.Location = new System.Drawing.Point(397, 13);
            this.CreateNewMenuItem.Name = "CreateNewMenuItem";
            this.CreateNewMenuItem.Size = new System.Drawing.Size(97, 23);
            this.CreateNewMenuItem.TabIndex = 25;
            this.CreateNewMenuItem.Text = "Aanmaken";
            this.CreateNewMenuItem.UseVisualStyleBackColor = true;
            this.CreateNewMenuItem.Click += new System.EventHandler(this.CreateMenuItem);
            // 
            // AmountMenuItemInput
            // 
            this.AmountMenuItemInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AmountMenuItemInput.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.AmountMenuItemInput.Location = new System.Drawing.Point(153, 110);
            this.AmountMenuItemInput.Name = "AmountMenuItemInput";
            this.AmountMenuItemInput.Size = new System.Drawing.Size(276, 26);
            this.AmountMenuItemInput.TabIndex = 23;
            this.AmountMenuItemInput.TextChanged += new System.EventHandler(this.MenuItemAmountChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label5.Location = new System.Drawing.Point(7, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Hoeveelheid";
            // 
            // DescriptionMenuItemInput
            // 
            this.DescriptionMenuItemInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescriptionMenuItemInput.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.DescriptionMenuItemInput.Location = new System.Drawing.Point(153, 147);
            this.DescriptionMenuItemInput.Name = "DescriptionMenuItemInput";
            this.DescriptionMenuItemInput.Size = new System.Drawing.Size(276, 26);
            this.DescriptionMenuItemInput.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label3.Location = new System.Drawing.Point(7, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Notities";
            // 
            // PriceMenuItemInput
            // 
            this.PriceMenuItemInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PriceMenuItemInput.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.PriceMenuItemInput.Location = new System.Drawing.Point(153, 68);
            this.PriceMenuItemInput.Name = "PriceMenuItemInput";
            this.PriceMenuItemInput.Size = new System.Drawing.Size(276, 26);
            this.PriceMenuItemInput.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label2.Location = new System.Drawing.Point(7, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prijs";
            // 
            // NameMenuItemInput
            // 
            this.NameMenuItemInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameMenuItemInput.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.NameMenuItemInput.Location = new System.Drawing.Point(153, 23);
            this.NameMenuItemInput.Name = "NameMenuItemInput";
            this.NameMenuItemInput.Size = new System.Drawing.Size(276, 26);
            this.NameMenuItemInput.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naam";
            // 
            // LeftEditPanel
            // 
            this.LeftEditPanel.BackColor = System.Drawing.Color.White;
            this.LeftEditPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LeftEditPanel.Controls.Add(this.MenuItemsList);
            this.LeftEditPanel.Controls.Add(this.ShowCreateMenuItemPanel);
            this.LeftEditPanel.Controls.Add(this.panel3);
            this.LeftEditPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftEditPanel.Location = new System.Drawing.Point(10, 10);
            this.LeftEditPanel.Name = "LeftEditPanel";
            this.LeftEditPanel.Padding = new System.Windows.Forms.Padding(10);
            this.LeftEditPanel.Size = new System.Drawing.Size(235, 393);
            this.LeftEditPanel.TabIndex = 0;
            // 
            // SearchMenuItemsList
            // 
            this.SearchMenuItemsList.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.SearchMenuItemsList.Location = new System.Drawing.Point(0, 0);
            this.SearchMenuItemsList.Name = "SearchMenuItemsList";
            this.SearchMenuItemsList.Size = new System.Drawing.Size(215, 33);
            this.SearchMenuItemsList.TabIndex = 30;
            this.SearchMenuItemsList.Text = "Zoeken";
            this.SearchMenuItemsList.TextChanged += new System.EventHandler(this.SearchMenuItems);
            this.SearchMenuItemsList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchMenuItemsList_KeyPress);
            // 
            // ShowCreateMenuItemPanel
            // 
            this.ShowCreateMenuItemPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ShowCreateMenuItemPanel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ShowCreateMenuItemPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(137)))), ((int)(((byte)(145)))));
            this.ShowCreateMenuItemPanel.Location = new System.Drawing.Point(10, 351);
            this.ShowCreateMenuItemPanel.Name = "ShowCreateMenuItemPanel";
            this.ShowCreateMenuItemPanel.Size = new System.Drawing.Size(215, 32);
            this.ShowCreateMenuItemPanel.TabIndex = 29;
            this.ShowCreateMenuItemPanel.Text = "Menu item aanmaken";
            this.ShowCreateMenuItemPanel.UseVisualStyleBackColor = true;
            this.ShowCreateMenuItemPanel.Click += new System.EventHandler(this.ShowMenuItemPanel);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::DePandaWinForms.Properties.Resources.closehover;
            this.pictureBox2.Location = new System.Drawing.Point(445, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.CloseMenuItemPanel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::DePandaWinForms.Properties.Resources.Edit;
            this.pictureBox1.Location = new System.Drawing.Point(7, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.EditSelectedMenuItem);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::DePandaWinForms.Properties.Resources.Del;
            this.pictureBox3.Location = new System.Drawing.Point(49, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.DeleteSelectedMenuItem);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.SearchMenuItemsList);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 30);
            this.panel3.TabIndex = 32;
            // 
            // MenuItemsList
            // 
            this.MenuItemsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.MenuItemsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuItemsList.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.MenuItemsList.FormattingEnabled = true;
            this.MenuItemsList.ItemHeight = 25;
            this.MenuItemsList.Location = new System.Drawing.Point(10, 40);
            this.MenuItemsList.Name = "MenuItemsList";
            this.MenuItemsList.ScrollAlwaysVisible = true;
            this.MenuItemsList.Size = new System.Drawing.Size(215, 311);
            this.MenuItemsList.TabIndex = 33;
            this.MenuItemsList.SelectedIndexChanged += new System.EventHandler(this.MenuItemsList_SelectedIndexChanged);
            // 
            // MenuPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPage";
            this.Text = "x";
            this.MainPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.LeftPanel.ResumeLayout(false);
            this.RightEditPanel.ResumeLayout(false);
            this.MenuItemGroupBox.ResumeLayout(false);
            this.MenuItemGroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.LeftEditPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panel2;
        private Design.PPanel RightEditPanel;
        private System.Windows.Forms.Panel LeftPanel;
        private Design.PPanel LeftEditPanel;
        private System.Windows.Forms.TextBox SearchMenuItemsList;
        private System.Windows.Forms.Button ShowCreateMenuItemPanel;
        private System.Windows.Forms.GroupBox MenuItemGroupBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CategoryCB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CreateNewMenuItem;
        private System.Windows.Forms.TextBox AmountMenuItemInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DescriptionMenuItemInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PriceMenuItemInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameMenuItemInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox MenuItemsList;
    }
}