namespace DePandaWinForms.Design
{
    partial class OrderItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Counter = new System.Windows.Forms.Label();
            this.OrderItemPanel = new System.Windows.Forms.Panel();
            this.Min = new System.Windows.Forms.Label();
            this.Plus = new System.Windows.Forms.Label();
            this.Item = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.OrderItemPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Counter);
            this.panel1.Controls.Add(this.OrderItemPanel);
            this.panel1.Controls.Add(this.Item);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 30);
            this.panel1.TabIndex = 11;
            // 
            // Counter
            // 
            this.Counter.AutoSize = true;
            this.Counter.BackColor = System.Drawing.Color.Transparent;
            this.Counter.Dock = System.Windows.Forms.DockStyle.Right;
            this.Counter.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Counter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(137)))), ((int)(((byte)(145)))));
            this.Counter.Location = new System.Drawing.Point(216, 0);
            this.Counter.Name = "Counter";
            this.Counter.Size = new System.Drawing.Size(22, 25);
            this.Counter.TabIndex = 13;
            this.Counter.Text = "0";
            // 
            // OrderItemPanel
            // 
            this.OrderItemPanel.Controls.Add(this.Min);
            this.OrderItemPanel.Controls.Add(this.Plus);
            this.OrderItemPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.OrderItemPanel.Location = new System.Drawing.Point(238, 0);
            this.OrderItemPanel.Name = "OrderItemPanel";
            this.OrderItemPanel.Padding = new System.Windows.Forms.Padding(2);
            this.OrderItemPanel.Size = new System.Drawing.Size(42, 30);
            this.OrderItemPanel.TabIndex = 12;
            // 
            // Min
            // 
            this.Min.AutoSize = true;
            this.Min.Dock = System.Windows.Forms.DockStyle.Left;
            this.Min.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Min.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Min.Location = new System.Drawing.Point(2, 2);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(16, 21);
            this.Min.TabIndex = 2;
            this.Min.Text = "-";
            this.Min.Click += new System.EventHandler(this.Min_Click);
            // 
            // Plus
            // 
            this.Plus.AutoSize = true;
            this.Plus.Dock = System.Windows.Forms.DockStyle.Right;
            this.Plus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plus.ForeColor = System.Drawing.Color.Green;
            this.Plus.Location = new System.Drawing.Point(19, 2);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(21, 21);
            this.Plus.TabIndex = 1;
            this.Plus.Text = "+";
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Item
            // 
            this.Item.AutoSize = true;
            this.Item.BackColor = System.Drawing.Color.Transparent;
            this.Item.Dock = System.Windows.Forms.DockStyle.Left;
            this.Item.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(137)))), ((int)(((byte)(145)))));
            this.Item.Location = new System.Drawing.Point(0, 0);
            this.Item.Name = "Item";
            this.Item.Size = new System.Drawing.Size(49, 25);
            this.Item.TabIndex = 11;
            this.Item.Text = "Item";
            this.Item.Click += new System.EventHandler(this.Item_Click);
            // 
            // OrderItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "OrderItem";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(300, 50);
            this.Click += new System.EventHandler(this.Item_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OrderItem_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.OrderItemPanel.ResumeLayout(false);
            this.OrderItemPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Counter;
        public System.Windows.Forms.Panel OrderItemPanel;
        private System.Windows.Forms.Label Min;
        private System.Windows.Forms.Label Plus;
        private System.Windows.Forms.Label Item;
    }
}
