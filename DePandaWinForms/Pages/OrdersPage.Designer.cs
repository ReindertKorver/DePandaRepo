

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
            this.RightEditPanel = new DePandaWinForms.Design.PPanel();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.LeftEditPanel = new DePandaWinForms.Design.PPanel();
            this.OrderItemList = new System.Windows.Forms.FlowLayoutPanel();
            this.NewOrderBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MainPanel.SuspendLayout();
            this.panel2.SuspendLayout();
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
            // RightEditPanel
            // 
            this.RightEditPanel.BackColor = System.Drawing.Color.White;
            this.RightEditPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RightEditPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightEditPanel.Location = new System.Drawing.Point(5, 10);
            this.RightEditPanel.Name = "RightEditPanel";
            this.RightEditPanel.Padding = new System.Windows.Forms.Padding(10);
            this.RightEditPanel.Size = new System.Drawing.Size(535, 393);
            this.RightEditPanel.TabIndex = 0;
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
            this.LeftEditPanel.Controls.Add(this.OrderItemList);
            this.LeftEditPanel.Controls.Add(this.NewOrderBtn);
            this.LeftEditPanel.Controls.Add(this.textBox1);
            this.LeftEditPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftEditPanel.Location = new System.Drawing.Point(10, 10);
            this.LeftEditPanel.Name = "LeftEditPanel";
            this.LeftEditPanel.Padding = new System.Windows.Forms.Padding(10);
            this.LeftEditPanel.Size = new System.Drawing.Size(235, 393);
            this.LeftEditPanel.TabIndex = 0;
            // 
            // OrderItemList
            // 
            this.OrderItemList.BackColor = System.Drawing.Color.Transparent;
            this.OrderItemList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderItemList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.OrderItemList.Location = new System.Drawing.Point(10, 43);
            this.OrderItemList.Name = "OrderItemList";
            this.OrderItemList.Size = new System.Drawing.Size(215, 312);
            this.OrderItemList.TabIndex = 14;
            // 
            // NewOrderBtn
            // 
            this.NewOrderBtn.BackColor = System.Drawing.Color.Transparent;
            this.NewOrderBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NewOrderBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(137)))), ((int)(((byte)(145)))));
            this.NewOrderBtn.FlatAppearance.BorderSize = 2;
            this.NewOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewOrderBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewOrderBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(137)))), ((int)(((byte)(145)))));
            this.NewOrderBtn.Location = new System.Drawing.Point(10, 355);
            this.NewOrderBtn.Name = "NewOrderBtn";
            this.NewOrderBtn.Size = new System.Drawing.Size(215, 28);
            this.NewOrderBtn.TabIndex = 13;
            this.NewOrderBtn.Text = "Nieuwe bestelling";
            this.NewOrderBtn.UseVisualStyleBackColor = false;
            this.NewOrderBtn.Click += new System.EventHandler(this.NewOrderBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(10, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 33);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Zoeken...";
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
            this.LeftEditPanel.ResumeLayout(false);
            this.LeftEditPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel LeftPanel;
        private PPanel RightEditPanel;
        private PPanel LeftEditPanel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button NewOrderBtn;
        private System.Windows.Forms.FlowLayoutPanel OrderItemList;
    }
}