namespace DePandaWinForms.Pages
{
    partial class BartOrder
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
            this.LeftPanel = new DePandaWinForms.Design.PPanel();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.NewOrderButton = new System.Windows.Forms.Button();
            this.ListOfTables = new System.Windows.Forms.FlowLayoutPanel();
            this.RightPanel = new DePandaWinForms.Design.PPanel();
            this.LeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.ListOfTables);
            this.LeftPanel.Controls.Add(this.NewOrderButton);
            this.LeftPanel.Controls.Add(this.SearchBox);
            this.LeftPanel.Location = new System.Drawing.Point(12, 12);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(295, 500);
            this.LeftPanel.TabIndex = 0;
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.SearchBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.Location = new System.Drawing.Point(0, 0);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(295, 33);
            this.SearchBox.TabIndex = 1;
            this.SearchBox.Text = "Zoeken...";
            this.SearchBox.Enter += new System.EventHandler(this.SearchBoxEnter);
            this.SearchBox.Leave += new System.EventHandler(this.SearchBoxLeave);
            // 
            // NewOrderButton
            // 
            this.NewOrderButton.BackColor = System.Drawing.Color.Transparent;
            this.NewOrderButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NewOrderButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(137)))), ((int)(((byte)(145)))));
            this.NewOrderButton.FlatAppearance.BorderSize = 2;
            this.NewOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewOrderButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewOrderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(137)))), ((int)(((byte)(145)))));
            this.NewOrderButton.Location = new System.Drawing.Point(0, 472);
            this.NewOrderButton.Name = "NewOrderButton";
            this.NewOrderButton.Size = new System.Drawing.Size(295, 28);
            this.NewOrderButton.TabIndex = 14;
            this.NewOrderButton.Text = "Nieuwe bestelling";
            this.NewOrderButton.UseVisualStyleBackColor = false;
            this.NewOrderButton.Click += new System.EventHandler(this.NewOrderButton_Click);
            // 
            // ListOfTables
            // 
            this.ListOfTables.BackColor = System.Drawing.Color.Transparent;
            this.ListOfTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListOfTables.Location = new System.Drawing.Point(0, 33);
            this.ListOfTables.Name = "ListOfTables";
            this.ListOfTables.Size = new System.Drawing.Size(295, 439);
            this.ListOfTables.TabIndex = 1;
            // 
            // RightPanel
            // 
            this.RightPanel.Location = new System.Drawing.Point(341, 12);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(553, 500);
            this.RightPanel.TabIndex = 1;
            // 
            // BartOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 555);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.LeftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BartOrder";
            this.Text = "BartOrder";
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Design.PPanel LeftPanel;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.FlowLayoutPanel ListOfTables;
        private System.Windows.Forms.Button NewOrderButton;
        private Design.PPanel RightPanel;
    }
}