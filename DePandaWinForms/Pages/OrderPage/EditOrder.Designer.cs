namespace DePandaWinForms.Pages.OrderPage
{
    partial class EditOrder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SaveOrderBtn = new System.Windows.Forms.Button();
            this.EditOrderBtn = new System.Windows.Forms.PictureBox();
            this.DeleteOrderBtn = new System.Windows.Forms.PictureBox();
            this.PaymentBtn = new System.Windows.Forms.Button();
            this.TotalLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.OnTheNameOfTb = new System.Windows.Forms.TextBox();
            this.OnTheNameOfLbl = new System.Windows.Forms.Label();
            this.MenuItemList = new System.Windows.Forms.FlowLayoutPanel();
            this.MenuItemsLBL = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TableNumberTB = new System.Windows.Forms.TextBox();
            this.TableNumberLBL = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DateTb = new System.Windows.Forms.TextBox();
            this.DateLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditOrderBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteOrderBtn)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TotalLbl);
            this.panel1.Controls.Add(this.PaymentBtn);
            this.panel1.Controls.Add(this.EditOrderBtn);
            this.panel1.Controls.Add(this.SaveOrderBtn);
            this.panel1.Controls.Add(this.DeleteOrderBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 396);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(800, 54);
            this.panel1.TabIndex = 12;
            // 
            // SaveOrderBtn
            // 
            this.SaveOrderBtn.BackColor = System.Drawing.Color.Transparent;
            this.SaveOrderBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.SaveOrderBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(137)))), ((int)(((byte)(145)))));
            this.SaveOrderBtn.FlatAppearance.BorderSize = 2;
            this.SaveOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveOrderBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveOrderBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(137)))), ((int)(((byte)(145)))));
            this.SaveOrderBtn.Location = new System.Drawing.Point(685, 10);
            this.SaveOrderBtn.Name = "SaveOrderBtn";
            this.SaveOrderBtn.Size = new System.Drawing.Size(105, 34);
            this.SaveOrderBtn.TabIndex = 14;
            this.SaveOrderBtn.Text = "Opslaan";
            this.SaveOrderBtn.UseVisualStyleBackColor = false;
            // 
            // EditOrderBtn
            // 
            this.EditOrderBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.EditOrderBtn.Image = global::DePandaWinForms.Properties.Resources.Edit;
            this.EditOrderBtn.Location = new System.Drawing.Point(46, 10);
            this.EditOrderBtn.Name = "EditOrderBtn";
            this.EditOrderBtn.Size = new System.Drawing.Size(36, 34);
            this.EditOrderBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EditOrderBtn.TabIndex = 15;
            this.EditOrderBtn.TabStop = false;
            // 
            // DeleteOrderBtn
            // 
            this.DeleteOrderBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.DeleteOrderBtn.Image = global::DePandaWinForms.Properties.Resources.Del;
            this.DeleteOrderBtn.Location = new System.Drawing.Point(10, 10);
            this.DeleteOrderBtn.Name = "DeleteOrderBtn";
            this.DeleteOrderBtn.Size = new System.Drawing.Size(36, 34);
            this.DeleteOrderBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DeleteOrderBtn.TabIndex = 0;
            this.DeleteOrderBtn.TabStop = false;
            // 
            // PaymentBtn
            // 
            this.PaymentBtn.BackColor = System.Drawing.Color.Transparent;
            this.PaymentBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.PaymentBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(137)))), ((int)(((byte)(145)))));
            this.PaymentBtn.FlatAppearance.BorderSize = 2;
            this.PaymentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaymentBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(137)))), ((int)(((byte)(145)))));
            this.PaymentBtn.Location = new System.Drawing.Point(580, 10);
            this.PaymentBtn.Name = "PaymentBtn";
            this.PaymentBtn.Size = new System.Drawing.Size(105, 34);
            this.PaymentBtn.TabIndex = 16;
            this.PaymentBtn.Text = "Afrekenen";
            this.PaymentBtn.UseVisualStyleBackColor = false;
            // 
            // TotalLbl
            // 
            this.TotalLbl.AutoSize = true;
            this.TotalLbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.TotalLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(137)))), ((int)(((byte)(145)))));
            this.TotalLbl.Location = new System.Drawing.Point(523, 10);
            this.TotalLbl.Name = "TotalLbl";
            this.TotalLbl.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.TotalLbl.Size = new System.Drawing.Size(57, 31);
            this.TotalLbl.TabIndex = 17;
            this.TotalLbl.Text = "Totaal: ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.MenuItemList);
            this.panel2.Controls.Add(this.MenuItemsLBL);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(15);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(15);
            this.panel2.Size = new System.Drawing.Size(800, 396);
            this.panel2.TabIndex = 19;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.OnTheNameOfTb);
            this.panel5.Controls.Add(this.OnTheNameOfLbl);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(15, 15);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(770, 30);
            this.panel5.TabIndex = 47;
            // 
            // OnTheNameOfTb
            // 
            this.OnTheNameOfTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OnTheNameOfTb.Dock = System.Windows.Forms.DockStyle.Left;
            this.OnTheNameOfTb.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnTheNameOfTb.Location = new System.Drawing.Point(125, 0);
            this.OnTheNameOfTb.Margin = new System.Windows.Forms.Padding(10);
            this.OnTheNameOfTb.MaxLength = 5;
            this.OnTheNameOfTb.Name = "OnTheNameOfTb";
            this.OnTheNameOfTb.Size = new System.Drawing.Size(177, 26);
            this.OnTheNameOfTb.TabIndex = 35;
            // 
            // OnTheNameOfLbl
            // 
            this.OnTheNameOfLbl.AutoSize = true;
            this.OnTheNameOfLbl.BackColor = System.Drawing.Color.Transparent;
            this.OnTheNameOfLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.OnTheNameOfLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnTheNameOfLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(137)))), ((int)(((byte)(145)))));
            this.OnTheNameOfLbl.Location = new System.Drawing.Point(0, 0);
            this.OnTheNameOfLbl.Name = "OnTheNameOfLbl";
            this.OnTheNameOfLbl.Size = new System.Drawing.Size(125, 25);
            this.OnTheNameOfLbl.TabIndex = 34;
            this.OnTheNameOfLbl.Text = "Reserveerder:";
            this.OnTheNameOfLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // MenuItemList
            // 
            this.MenuItemList.AutoScroll = true;
            this.MenuItemList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuItemList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.MenuItemList.Location = new System.Drawing.Point(15, 130);
            this.MenuItemList.Name = "MenuItemList";
            this.MenuItemList.Size = new System.Drawing.Size(770, 251);
            this.MenuItemList.TabIndex = 52;
            // 
            // MenuItemsLBL
            // 
            this.MenuItemsLBL.AutoSize = true;
            this.MenuItemsLBL.BackColor = System.Drawing.Color.Transparent;
            this.MenuItemsLBL.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuItemsLBL.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuItemsLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(137)))), ((int)(((byte)(145)))));
            this.MenuItemsLBL.Location = new System.Drawing.Point(15, 105);
            this.MenuItemsLBL.Name = "MenuItemsLBL";
            this.MenuItemsLBL.Size = new System.Drawing.Size(115, 25);
            this.MenuItemsLBL.TabIndex = 51;
            this.MenuItemsLBL.Text = "Menu items:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TableNumberTB);
            this.panel3.Controls.Add(this.TableNumberLBL);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(15, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(770, 28);
            this.panel3.TabIndex = 50;
            // 
            // TableNumberTB
            // 
            this.TableNumberTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TableNumberTB.Dock = System.Windows.Forms.DockStyle.Left;
            this.TableNumberTB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableNumberTB.Location = new System.Drawing.Point(126, 0);
            this.TableNumberTB.Margin = new System.Windows.Forms.Padding(10);
            this.TableNumberTB.MaxLength = 5;
            this.TableNumberTB.Name = "TableNumberTB";
            this.TableNumberTB.Size = new System.Drawing.Size(88, 26);
            this.TableNumberTB.TabIndex = 33;
            // 
            // TableNumberLBL
            // 
            this.TableNumberLBL.AutoSize = true;
            this.TableNumberLBL.BackColor = System.Drawing.Color.Transparent;
            this.TableNumberLBL.Dock = System.Windows.Forms.DockStyle.Left;
            this.TableNumberLBL.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableNumberLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(137)))), ((int)(((byte)(145)))));
            this.TableNumberLBL.Location = new System.Drawing.Point(0, 0);
            this.TableNumberLBL.Name = "TableNumberLBL";
            this.TableNumberLBL.Size = new System.Drawing.Size(126, 25);
            this.TableNumberLBL.TabIndex = 24;
            this.TableNumberLBL.Text = "Tafelnummer:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.DateTb);
            this.panel4.Controls.Add(this.DateLbl);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(15, 45);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(770, 32);
            this.panel4.TabIndex = 49;
            // 
            // DateTb
            // 
            this.DateTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DateTb.Dock = System.Windows.Forms.DockStyle.Left;
            this.DateTb.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTb.Location = new System.Drawing.Point(72, 0);
            this.DateTb.Margin = new System.Windows.Forms.Padding(10);
            this.DateTb.MaxLength = 5;
            this.DateTb.Name = "DateTb";
            this.DateTb.Size = new System.Drawing.Size(177, 26);
            this.DateTb.TabIndex = 33;
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.BackColor = System.Drawing.Color.Transparent;
            this.DateLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.DateLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(137)))), ((int)(((byte)(145)))));
            this.DateLbl.Location = new System.Drawing.Point(0, 0);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(72, 25);
            this.DateLbl.TabIndex = 31;
            this.DateLbl.Text = "Datum:";
            // 
            // EditOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditOrder";
            this.Text = "EditOrder";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditOrderBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteOrderBtn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox EditOrderBtn;
        private System.Windows.Forms.Button SaveOrderBtn;
        private System.Windows.Forms.PictureBox DeleteOrderBtn;
        private System.Windows.Forms.Button PaymentBtn;
        private System.Windows.Forms.Label TotalLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox OnTheNameOfTb;
        private System.Windows.Forms.Label OnTheNameOfLbl;
        private System.Windows.Forms.FlowLayoutPanel MenuItemList;
        private System.Windows.Forms.Label MenuItemsLBL;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TableNumberTB;
        private System.Windows.Forms.Label TableNumberLBL;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox DateTb;
        private System.Windows.Forms.Label DateLbl;
    }
}