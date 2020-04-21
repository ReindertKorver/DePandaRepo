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
            this.EditOrderBtn = new System.Windows.Forms.PictureBox();
            this.SaveOrderBtn = new System.Windows.Forms.Button();
            this.DeleteOrderBtn = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.TableNumberTB = new System.Windows.Forms.TextBox();
            this.TableNumberLBL = new System.Windows.Forms.Label();
            this.MenuItemsLBL = new System.Windows.Forms.Label();
            this.OrderMenuItemsView = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditOrderBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteOrderBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
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
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(137)))), ((int)(((byte)(145)))));
            this.Title.Location = new System.Drawing.Point(12, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(0, 30);
            this.Title.TabIndex = 13;
            // 
            // TableNumberTB
            // 
            this.TableNumberTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TableNumberTB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableNumberTB.Location = new System.Drawing.Point(19, 74);
            this.TableNumberTB.Margin = new System.Windows.Forms.Padding(10);
            this.TableNumberTB.MaxLength = 5;
            this.TableNumberTB.Name = "TableNumberTB";
            this.TableNumberTB.Size = new System.Drawing.Size(200, 26);
            this.TableNumberTB.TabIndex = 0;
            this.TableNumberTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TableNumberLBL
            // 
            this.TableNumberLBL.AutoSize = true;
            this.TableNumberLBL.BackColor = System.Drawing.Color.Transparent;
            this.TableNumberLBL.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableNumberLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(137)))), ((int)(((byte)(145)))));
            this.TableNumberLBL.Location = new System.Drawing.Point(12, 39);
            this.TableNumberLBL.Name = "TableNumberLBL";
            this.TableNumberLBL.Size = new System.Drawing.Size(126, 25);
            this.TableNumberLBL.TabIndex = 14;
            this.TableNumberLBL.Text = "Tafelnummer:";
            // 
            // MenuItemsLBL
            // 
            this.MenuItemsLBL.AutoSize = true;
            this.MenuItemsLBL.BackColor = System.Drawing.Color.Transparent;
            this.MenuItemsLBL.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuItemsLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(137)))), ((int)(((byte)(145)))));
            this.MenuItemsLBL.Location = new System.Drawing.Point(12, 110);
            this.MenuItemsLBL.Name = "MenuItemsLBL";
            this.MenuItemsLBL.Size = new System.Drawing.Size(115, 25);
            this.MenuItemsLBL.TabIndex = 15;
            this.MenuItemsLBL.Text = "Menu items:";
            // 
            // OrderMenuItemsView
            // 
            this.OrderMenuItemsView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderMenuItemsView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.OrderMenuItemsView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderMenuItemsView.HideSelection = false;
            this.OrderMenuItemsView.Location = new System.Drawing.Point(17, 138);
            this.OrderMenuItemsView.Name = "OrderMenuItemsView";
            this.OrderMenuItemsView.Size = new System.Drawing.Size(769, 252);
            this.OrderMenuItemsView.TabIndex = 16;
            this.OrderMenuItemsView.UseCompatibleStateImageBehavior = false;
            // 
            // EditOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OrderMenuItemsView);
            this.Controls.Add(this.MenuItemsLBL);
            this.Controls.Add(this.TableNumberTB);
            this.Controls.Add(this.TableNumberLBL);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditOrder";
            this.Text = "EditOrder";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EditOrderBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteOrderBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox EditOrderBtn;
        private System.Windows.Forms.Button SaveOrderBtn;
        private System.Windows.Forms.PictureBox DeleteOrderBtn;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox TableNumberTB;
        private System.Windows.Forms.Label TableNumberLBL;
        private System.Windows.Forms.Label MenuItemsLBL;
        private System.Windows.Forms.ListView OrderMenuItemsView;
    }
}