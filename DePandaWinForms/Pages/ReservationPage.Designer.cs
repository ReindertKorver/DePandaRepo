namespace DePandaWinForms.Pages
{
    partial class ReservationPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.Reserveringpanel = new System.Windows.Forms.Panel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.label3 = new System.Windows.Forms.Label();
            this.Hoeveelpersonen = new System.Windows.Forms.Label();
            this.Tijd1 = new System.Windows.Forms.Label();
            this.Naam1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.nieuwereserveringknop = new System.Windows.Forms.Button();
            this.Reserveringpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reserveringen";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Reserveringpanel
            // 
            this.Reserveringpanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Reserveringpanel.Controls.Add(this.vScrollBar1);
            this.Reserveringpanel.Controls.Add(this.label3);
            this.Reserveringpanel.Controls.Add(this.Hoeveelpersonen);
            this.Reserveringpanel.Controls.Add(this.Tijd1);
            this.Reserveringpanel.Controls.Add(this.Naam1);
            this.Reserveringpanel.Controls.Add(this.tableLayoutPanel1);
            this.Reserveringpanel.Location = new System.Drawing.Point(0, 46);
            this.Reserveringpanel.Name = "Reserveringpanel";
            this.Reserveringpanel.Size = new System.Drawing.Size(1048, 480);
            this.Reserveringpanel.TabIndex = 1;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(1025, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(23, 480);
            this.vScrollBar1.TabIndex = 5;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(773, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bijzonderheden";
            // 
            // Hoeveelpersonen
            // 
            this.Hoeveelpersonen.AutoSize = true;
            this.Hoeveelpersonen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hoeveelpersonen.Location = new System.Drawing.Point(577, 15);
            this.Hoeveelpersonen.Name = "Hoeveelpersonen";
            this.Hoeveelpersonen.Size = new System.Drawing.Size(123, 36);
            this.Hoeveelpersonen.TabIndex = 3;
            this.Hoeveelpersonen.Text = "Hoeveel";
            this.Hoeveelpersonen.Click += new System.EventHandler(this.Hoeveelpersonen_Click);
            // 
            // Tijd1
            // 
            this.Tijd1.AutoSize = true;
            this.Tijd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tijd1.Location = new System.Drawing.Point(366, 15);
            this.Tijd1.Name = "Tijd1";
            this.Tijd1.Size = new System.Drawing.Size(64, 36);
            this.Tijd1.TabIndex = 2;
            this.Tijd1.Text = "Tijd";
            this.Tijd1.Click += new System.EventHandler(this.Tijd1_Click);
            // 
            // Naam1
            // 
            this.Naam1.AutoSize = true;
            this.Naam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Naam1.Location = new System.Drawing.Point(78, 15);
            this.Naam1.Name = "Naam1";
            this.Naam1.Size = new System.Drawing.Size(92, 36);
            this.Naam1.TabIndex = 1;
            this.Naam1.Text = "Naam";
            this.Naam1.Click += new System.EventHandler(this.Naam1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 54);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(991, 399);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // nieuwereserveringknop
            // 
            this.nieuwereserveringknop.Location = new System.Drawing.Point(847, 596);
            this.nieuwereserveringknop.Name = "nieuwereserveringknop";
            this.nieuwereserveringknop.Size = new System.Drawing.Size(213, 35);
            this.nieuwereserveringknop.TabIndex = 2;
            this.nieuwereserveringknop.Text = "Nieuwe reservering";
            this.nieuwereserveringknop.UseVisualStyleBackColor = true;
            // 
            // ReservationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 639);
            this.Controls.Add(this.nieuwereserveringknop);
            this.Controls.Add(this.Reserveringpanel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReservationPage";
            this.Text = "Reservations";
            this.Load += new System.EventHandler(this.ReservationPage_Load);
            this.Reserveringpanel.ResumeLayout(false);
            this.Reserveringpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Reserveringpanel;
        private System.Windows.Forms.Label Naam1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Hoeveelpersonen;
        private System.Windows.Forms.Label Tijd1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button nieuwereserveringknop;
    }
}