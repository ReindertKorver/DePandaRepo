

using DePandaWinForms.Design;

namespace DePandaWinForms.Pages
{
    partial class OrdersPage
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
            this.LeftEditPanel = new DePandaWinForms.Design.PPanel();
            this.MainPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.LeftPanel.SuspendLayout();
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
            this.Title.TabIndex = 14;
            this.Title.Text = "Bestellingen";
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
            this.MainPanel.TabIndex = 15;
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
            this.RightEditPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightEditPanel.Location = new System.Drawing.Point(5, 10);
            this.RightEditPanel.Name = "RightEditPanel";
            this.RightEditPanel.Size = new System.Drawing.Size(535, 393);
            this.RightEditPanel.TabIndex = 0;
            // 
            // LeftEditPanel
            // 
            this.LeftEditPanel.BackColor = System.Drawing.Color.White;
            this.LeftEditPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LeftEditPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftEditPanel.Location = new System.Drawing.Point(10, 10);
            this.LeftEditPanel.Name = "LeftEditPanel";
            this.LeftEditPanel.Size = new System.Drawing.Size(235, 393);
            this.LeftEditPanel.TabIndex = 0;
            this.LeftEditPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LeftEditPanel_Paint);
            // 
            // OrdersPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrdersPage";
            this.Text = "Reservations";
            this.MainPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.LeftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel LeftPanel;
        private PPanel RightEditPanel;
        private PPanel LeftEditPanel;
    }
}