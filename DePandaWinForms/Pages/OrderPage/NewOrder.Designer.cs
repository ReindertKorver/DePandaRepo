namespace DePandaWinForms.Pages.OrderPage
{
    partial class NewOrder
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
            this.DeleteOrderBtn = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MenuItemList = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.CategoryCB = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.MenuItemsLBL = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ReservationLBL = new System.Windows.Forms.Label();
            this.TableNumberTB = new System.Windows.Forms.TextBox();
            this.TableNumberLBL = new System.Windows.Forms.Label();
            this.NewOrderLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteOrderBtn)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SaveOrderBtn);
            this.panel1.Controls.Add(this.DeleteOrderBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 396);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(800, 54);
            this.panel1.TabIndex = 11;
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
            this.SaveOrderBtn.Click += new System.EventHandler(this.SaveOrderBtn_Click);
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
            this.DeleteOrderBtn.Click += new System.EventHandler(this.DeleteOrderBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.MenuItemList);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.NewOrderLbl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(15);
            this.panel2.Size = new System.Drawing.Size(800, 396);
            this.panel2.TabIndex = 12;
            // 
            // MenuItemList
            // 
            this.MenuItemList.AutoScroll = true;
            this.MenuItemList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuItemList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.MenuItemList.Location = new System.Drawing.Point(15, 102);
            this.MenuItemList.Name = "MenuItemList";
            this.MenuItemList.Size = new System.Drawing.Size(770, 279);
            this.MenuItemList.TabIndex = 61;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.MenuItemsLBL);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(15, 73);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(770, 29);
            this.panel4.TabIndex = 58;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.CategoryCB);
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(480, 0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(4);
            this.panel5.Size = new System.Drawing.Size(290, 29);
            this.panel5.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 68;
            this.label1.Text = "Filter categorie:";
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(120, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(13, 21);
            this.panel6.TabIndex = 67;
            // 
            // CategoryCB
            // 
            this.CategoryCB.Dock = System.Windows.Forms.DockStyle.Right;
            this.CategoryCB.FormattingEnabled = true;
            this.CategoryCB.Location = new System.Drawing.Point(133, 4);
            this.CategoryCB.Name = "CategoryCB";
            this.CategoryCB.Size = new System.Drawing.Size(128, 21);
            this.CategoryCB.TabIndex = 66;
            this.CategoryCB.SelectedIndexChanged += new System.EventHandler(this.CategoryCB_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::DePandaWinForms.Properties.Resources.closehover;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = global::DePandaWinForms.Properties.Resources.closehover;
            this.pictureBox2.Location = new System.Drawing.Point(261, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // MenuItemsLBL
            // 
            this.MenuItemsLBL.AutoSize = true;
            this.MenuItemsLBL.BackColor = System.Drawing.Color.Transparent;
            this.MenuItemsLBL.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuItemsLBL.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuItemsLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(137)))), ((int)(((byte)(145)))));
            this.MenuItemsLBL.Location = new System.Drawing.Point(0, 0);
            this.MenuItemsLBL.Name = "MenuItemsLBL";
            this.MenuItemsLBL.Size = new System.Drawing.Size(115, 25);
            this.MenuItemsLBL.TabIndex = 61;
            this.MenuItemsLBL.Text = "Menu items:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ReservationLBL);
            this.panel3.Controls.Add(this.TableNumberTB);
            this.panel3.Controls.Add(this.TableNumberLBL);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(15, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(770, 28);
            this.panel3.TabIndex = 57;
            // 
            // ReservationLBL
            // 
            this.ReservationLBL.AutoSize = true;
            this.ReservationLBL.BackColor = System.Drawing.Color.Transparent;
            this.ReservationLBL.Dock = System.Windows.Forms.DockStyle.Left;
            this.ReservationLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservationLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(137)))), ((int)(((byte)(145)))));
            this.ReservationLBL.Location = new System.Drawing.Point(214, 0);
            this.ReservationLBL.Name = "ReservationLBL";
            this.ReservationLBL.Size = new System.Drawing.Size(0, 21);
            this.ReservationLBL.TabIndex = 34;
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
            this.TableNumberTB.TextChanged += new System.EventHandler(this.TableNumberTB_TextChanged);
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
            // NewOrderLbl
            // 
            this.NewOrderLbl.AutoSize = true;
            this.NewOrderLbl.BackColor = System.Drawing.Color.Transparent;
            this.NewOrderLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.NewOrderLbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewOrderLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(137)))), ((int)(((byte)(145)))));
            this.NewOrderLbl.Location = new System.Drawing.Point(15, 15);
            this.NewOrderLbl.Name = "NewOrderLbl";
            this.NewOrderLbl.Size = new System.Drawing.Size(190, 30);
            this.NewOrderLbl.TabIndex = 56;
            this.NewOrderLbl.Text = "Nieuwe bestelling";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::DePandaWinForms.Properties.Resources.closehover;
            this.pictureBox1.Location = new System.Drawing.Point(750, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // NewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewOrder";
            this.Text = "NewOrder";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DeleteOrderBtn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SaveOrderBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label ReservationLBL;
        private System.Windows.Forms.TextBox TableNumberTB;
        private System.Windows.Forms.Label TableNumberLBL;
        private System.Windows.Forms.Label NewOrderLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox DeleteOrderBtn;
        private System.Windows.Forms.FlowLayoutPanel MenuItemList;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label MenuItemsLBL;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox CategoryCB;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}