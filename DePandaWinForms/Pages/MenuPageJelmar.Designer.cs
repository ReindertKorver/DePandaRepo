namespace DePandaWinForms.Pages
{
    partial class MenuPageJelmar
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
            this.components = new System.ComponentModel.Container();
            this.Pincode = new System.Windows.Forms.Label();
            this.MenuGrid = new System.Windows.Forms.DataGridView();
            this.NieuwItemButton = new System.Windows.Forms.Button();
            this.MenuItemList = new System.Windows.Forms.FlowLayoutPanel();
            this.Searchbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DeleteButton = new System.Windows.Forms.PictureBox();
            this.NotitiesInput = new System.Windows.Forms.TextBox();
            this.PrijsInput = new System.Windows.Forms.TextBox();
            this.NieuwMenuItemTekstbox = new System.Windows.Forms.TextBox();
            this.NotitiesLabel = new System.Windows.Forms.Label();
            this.PrijsLabel = new System.Windows.Forms.Label();
            this.OpslaanButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MenuGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteButton)).BeginInit();
            this.SuspendLayout();
            // 
            // Pincode
            // 
            this.Pincode.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pincode.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pincode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.Pincode.Location = new System.Drawing.Point(0, 0);
            this.Pincode.Margin = new System.Windows.Forms.Padding(6, 48, 6, 0);
            this.Pincode.Name = "Pincode";
            this.Pincode.Size = new System.Drawing.Size(1600, 71);
            this.Pincode.TabIndex = 13;
            this.Pincode.Text = "Menu";
            this.Pincode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MenuGrid
            // 
            this.MenuGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.MenuGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MenuGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MenuGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MenuGrid.Location = new System.Drawing.Point(0, 88);
            this.MenuGrid.Margin = new System.Windows.Forms.Padding(6);
            this.MenuGrid.Name = "MenuGrid";
            this.MenuGrid.RowHeadersWidth = 82;
            this.MenuGrid.Size = new System.Drawing.Size(1600, 777);
            this.MenuGrid.TabIndex = 15;
            // 
            // NieuwItemButton
            // 
            this.NieuwItemButton.Location = new System.Drawing.Point(260, 762);
            this.NieuwItemButton.Name = "NieuwItemButton";
            this.NieuwItemButton.Size = new System.Drawing.Size(222, 63);
            this.NieuwItemButton.TabIndex = 21;
            this.NieuwItemButton.Text = "Nieuw item";
            this.NieuwItemButton.UseVisualStyleBackColor = true;
            this.NieuwItemButton.Click += new System.EventHandler(this.NieuwMenuItemClick);
            // 
            // MenuItemList
            // 
            this.MenuItemList.AutoScroll = true;
            this.MenuItemList.Location = new System.Drawing.Point(57, 210);
            this.MenuItemList.Name = "MenuItemList";
            this.MenuItemList.Size = new System.Drawing.Size(431, 534);
            this.MenuItemList.TabIndex = 22;
            // 
            // Searchbox
            // 
            this.Searchbox.Location = new System.Drawing.Point(64, 173);
            this.Searchbox.Name = "Searchbox";
            this.Searchbox.Size = new System.Drawing.Size(329, 31);
            this.Searchbox.TabIndex = 23;
            this.Searchbox.TextChanged += new System.EventHandler(this.SearchBoxFlowPanel_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.DeleteButton);
            this.panel1.Controls.Add(this.NotitiesInput);
            this.panel1.Controls.Add(this.PrijsInput);
            this.panel1.Controls.Add(this.NieuwMenuItemTekstbox);
            this.panel1.Controls.Add(this.NotitiesLabel);
            this.panel1.Controls.Add(this.PrijsLabel);
            this.panel1.Controls.Add(this.OpslaanButton);
            this.panel1.Location = new System.Drawing.Point(581, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 591);
            this.panel1.TabIndex = 24;
            this.panel1.Visible = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Image = global::DePandaWinForms.Properties.Resources.closehover;
            this.DeleteButton.Location = new System.Drawing.Point(3, 496);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(102, 92);
            this.DeleteButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.TabStop = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButtonClick);
            // 
            // NotitiesInput
            // 
            this.NotitiesInput.BackColor = System.Drawing.Color.DarkGray;
            this.NotitiesInput.ForeColor = System.Drawing.Color.Teal;
            this.NotitiesInput.Location = new System.Drawing.Point(313, 151);
            this.NotitiesInput.Multiline = true;
            this.NotitiesInput.Name = "NotitiesInput";
            this.NotitiesInput.Size = new System.Drawing.Size(609, 274);
            this.NotitiesInput.TabIndex = 8;
            // 
            // PrijsInput
            // 
            this.PrijsInput.BackColor = System.Drawing.Color.DarkGray;
            this.PrijsInput.ForeColor = System.Drawing.Color.Teal;
            this.PrijsInput.Location = new System.Drawing.Point(313, 101);
            this.PrijsInput.Multiline = true;
            this.PrijsInput.Name = "PrijsInput";
            this.PrijsInput.Size = new System.Drawing.Size(117, 37);
            this.PrijsInput.TabIndex = 7;
            // 
            // NieuwMenuItemTekstbox
            // 
            this.NieuwMenuItemTekstbox.BackColor = System.Drawing.Color.DarkGray;
            this.NieuwMenuItemTekstbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NieuwMenuItemTekstbox.ForeColor = System.Drawing.Color.Teal;
            this.NieuwMenuItemTekstbox.Location = new System.Drawing.Point(30, 20);
            this.NieuwMenuItemTekstbox.Multiline = true;
            this.NieuwMenuItemTekstbox.Name = "NieuwMenuItemTekstbox";
            this.NieuwMenuItemTekstbox.Size = new System.Drawing.Size(383, 61);
            this.NieuwMenuItemTekstbox.TabIndex = 6;
            this.NieuwMenuItemTekstbox.Text = "Nieuw menu item";
            this.NieuwMenuItemTekstbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // NotitiesLabel
            // 
            this.NotitiesLabel.AutoSize = true;
            this.NotitiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotitiesLabel.ForeColor = System.Drawing.Color.Teal;
            this.NotitiesLabel.Location = new System.Drawing.Point(33, 154);
            this.NotitiesLabel.Name = "NotitiesLabel";
            this.NotitiesLabel.Size = new System.Drawing.Size(121, 33);
            this.NotitiesLabel.TabIndex = 5;
            this.NotitiesLabel.Text = "Notities:";
            // 
            // PrijsLabel
            // 
            this.PrijsLabel.AutoSize = true;
            this.PrijsLabel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.PrijsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrijsLabel.ForeColor = System.Drawing.Color.Teal;
            this.PrijsLabel.Location = new System.Drawing.Point(33, 101);
            this.PrijsLabel.Name = "PrijsLabel";
            this.PrijsLabel.Size = new System.Drawing.Size(88, 37);
            this.PrijsLabel.TabIndex = 4;
            this.PrijsLabel.Text = "Prijs:";
            // 
            // OpslaanButton
            // 
            this.OpslaanButton.Location = new System.Drawing.Point(791, 520);
            this.OpslaanButton.Name = "OpslaanButton";
            this.OpslaanButton.Size = new System.Drawing.Size(131, 57);
            this.OpslaanButton.TabIndex = 0;
            this.OpslaanButton.Text = "Opslaan";
            this.OpslaanButton.UseVisualStyleBackColor = true;
            this.OpslaanButton.Click += new System.EventHandler(this.OpslaanButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MenuPageJelmar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Searchbox);
            this.Controls.Add(this.MenuItemList);
            this.Controls.Add(this.NieuwItemButton);
            this.Controls.Add(this.MenuGrid);
            this.Controls.Add(this.Pincode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MenuPageJelmar";
            this.Text = "Reservations";
            ((System.ComponentModel.ISupportInitialize)(this.MenuGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Pincode;
        private System.Windows.Forms.DataGridView MenuGrid;
        private System.Windows.Forms.FlowLayoutPanel MenuItemList;
        private System.Windows.Forms.TextBox Searchbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label NotitiesLabel;
        private System.Windows.Forms.Label PrijsLabel;
        private System.Windows.Forms.Button OpslaanButton;
        private System.Windows.Forms.Button NieuwItemButton;
        private System.Windows.Forms.TextBox NieuwMenuItemTekstbox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox NotitiesInput;
        private System.Windows.Forms.TextBox PrijsInput;
        private System.Windows.Forms.PictureBox DeleteButton;
    }
}