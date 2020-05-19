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
            this.RightEditPanel = new DePandaWinForms.Design.PPanel();
            this.MenuItemGroupBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CategoryCB = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseSelectedMenuItem = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CreateNewMenuItem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AmountMenuItemInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DescriptionMenuItemInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PriceMenuItemInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameMenuItemInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.LeftEditPanel = new DePandaWinForms.Design.PPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchMenuItemsList = new System.Windows.Forms.TextBox();
            this.ShowCreateMenuItemPanel = new System.Windows.Forms.Button();
            this.MenuItemsList = new System.Windows.Forms.ListBox();
            this.MainPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.RightEditPanel.SuspendLayout();
            this.MenuItemGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.LeftEditPanel.SuspendLayout();
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
            this.MenuItemGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.label6.Location = new System.Drawing.Point(7, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Categorie";
            // 
            // CategoryCB
            // 
            this.CategoryCB.FormattingEnabled = true;
            this.CategoryCB.Location = new System.Drawing.Point(74, 182);
            this.CategoryCB.Name = "CategoryCB";
            this.CategoryCB.Size = new System.Drawing.Size(326, 21);
            this.CategoryCB.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CloseSelectedMenuItem);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.CreateNewMenuItem);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 336);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 34);
            this.panel1.TabIndex = 24;
            // 
            // CloseSelectedMenuItem
            // 
            this.CloseSelectedMenuItem.Location = new System.Drawing.Point(265, 6);
            this.CloseSelectedMenuItem.Name = "CloseSelectedMenuItem";
            this.CloseSelectedMenuItem.Size = new System.Drawing.Size(85, 23);
            this.CloseSelectedMenuItem.TabIndex = 22;
            this.CloseSelectedMenuItem.Text = "Sluit scherm";
            this.CloseSelectedMenuItem.UseVisualStyleBackColor = true;
            this.CloseSelectedMenuItem.Click += new System.EventHandler(this.CloseMenuItemPanel);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(214, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.EditSelectedMenuItem);
            // 
            // CreateNewMenuItem
            // 
            this.CreateNewMenuItem.Location = new System.Drawing.Point(66, 6);
            this.CreateNewMenuItem.Name = "CreateNewMenuItem";
            this.CreateNewMenuItem.Size = new System.Drawing.Size(97, 23);
            this.CreateNewMenuItem.TabIndex = 25;
            this.CreateNewMenuItem.Text = "Creër";
            this.CreateNewMenuItem.UseVisualStyleBackColor = true;
            this.CreateNewMenuItem.Click += new System.EventHandler(this.CreateMenuItem);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Del";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.DeleteSelectedMenuItem);
            // 
            // AmountMenuItemInput
            // 
            this.AmountMenuItemInput.Location = new System.Drawing.Point(74, 107);
            this.AmountMenuItemInput.Name = "AmountMenuItemInput";
            this.AmountMenuItemInput.Size = new System.Drawing.Size(326, 20);
            this.AmountMenuItemInput.TabIndex = 23;
            this.AmountMenuItemInput.TextChanged += new System.EventHandler(this.MenuItemAmountChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Hoeveelheid";
            // 
            // DescriptionMenuItemInput
            // 
            this.DescriptionMenuItemInput.Location = new System.Drawing.Point(74, 145);
            this.DescriptionMenuItemInput.Name = "DescriptionMenuItemInput";
            this.DescriptionMenuItemInput.Size = new System.Drawing.Size(326, 20);
            this.DescriptionMenuItemInput.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Notities";
            // 
            // PriceMenuItemInput
            // 
            this.PriceMenuItemInput.Location = new System.Drawing.Point(74, 68);
            this.PriceMenuItemInput.Name = "PriceMenuItemInput";
            this.PriceMenuItemInput.Size = new System.Drawing.Size(326, 20);
            this.PriceMenuItemInput.TabIndex = 19;
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
            // NameMenuItemInput
            // 
            this.NameMenuItemInput.Location = new System.Drawing.Point(74, 28);
            this.NameMenuItemInput.Name = "NameMenuItemInput";
            this.NameMenuItemInput.Size = new System.Drawing.Size(326, 20);
            this.NameMenuItemInput.TabIndex = 18;
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
            // LeftEditPanel
            // 
            this.LeftEditPanel.BackColor = System.Drawing.Color.White;
            this.LeftEditPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LeftEditPanel.Controls.Add(this.label4);
            this.LeftEditPanel.Controls.Add(this.SearchMenuItemsList);
            this.LeftEditPanel.Controls.Add(this.ShowCreateMenuItemPanel);
            this.LeftEditPanel.Controls.Add(this.MenuItemsList);
            this.LeftEditPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftEditPanel.Location = new System.Drawing.Point(10, 10);
            this.LeftEditPanel.Name = "LeftEditPanel";
            this.LeftEditPanel.Padding = new System.Windows.Forms.Padding(10);
            this.LeftEditPanel.Size = new System.Drawing.Size(235, 393);
            this.LeftEditPanel.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(13, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Zoek";
            // 
            // SearchMenuItemsList
            // 
            this.SearchMenuItemsList.Location = new System.Drawing.Point(61, 7);
            this.SearchMenuItemsList.Name = "SearchMenuItemsList";
            this.SearchMenuItemsList.Size = new System.Drawing.Size(172, 20);
            this.SearchMenuItemsList.TabIndex = 30;
            this.SearchMenuItemsList.TextChanged += new System.EventHandler(this.SearchMenuItems);
            // 
            // ShowCreateMenuItemPanel
            // 
            this.ShowCreateMenuItemPanel.Location = new System.Drawing.Point(78, 363);
            this.ShowCreateMenuItemPanel.Name = "ShowCreateMenuItemPanel";
            this.ShowCreateMenuItemPanel.Size = new System.Drawing.Size(155, 23);
            this.ShowCreateMenuItemPanel.TabIndex = 29;
            this.ShowCreateMenuItemPanel.Text = "Menu item aanmaken";
            this.ShowCreateMenuItemPanel.UseVisualStyleBackColor = true;
            this.ShowCreateMenuItemPanel.Click += new System.EventHandler(this.ShowMenuItemPanel);
            // 
            // MenuItemsList
            // 
            this.MenuItemsList.FormattingEnabled = true;
            this.MenuItemsList.Location = new System.Drawing.Point(1, 46);
            this.MenuItemsList.Name = "MenuItemsList";
            this.MenuItemsList.ScrollAlwaysVisible = true;
            this.MenuItemsList.Size = new System.Drawing.Size(232, 303);
            this.MenuItemsList.TabIndex = 28;
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
            this.RightEditPanel.ResumeLayout(false);
            this.MenuItemGroupBox.ResumeLayout(false);
            this.MenuItemGroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.LeftPanel.ResumeLayout(false);
            this.LeftEditPanel.ResumeLayout(false);
            this.LeftEditPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panel2;
        private Design.PPanel RightEditPanel;
        private System.Windows.Forms.Panel LeftPanel;
        private Design.PPanel LeftEditPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SearchMenuItemsList;
        private System.Windows.Forms.Button ShowCreateMenuItemPanel;
        private System.Windows.Forms.ListBox MenuItemsList;
        private System.Windows.Forms.GroupBox MenuItemGroupBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CategoryCB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CloseSelectedMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button CreateNewMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox AmountMenuItemInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DescriptionMenuItemInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PriceMenuItemInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameMenuItemInput;
        private System.Windows.Forms.Label label1;
    }
}