﻿namespace DePandaWinForms.Pages.OrderPage
{
    partial class PaymentOption
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
            this.PinButton = new System.Windows.Forms.Button();
            this.CashButton = new System.Windows.Forms.Button();
            this.Question = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.ContactPanel = new DePandaWinForms.Design.PPanel();
            this.ConfirmCashPayment = new System.Windows.Forms.Button();
            this.TotalGivenAmountBox = new System.Windows.Forms.TextBox();
            this.ChangeLabel = new System.Windows.Forms.Label();
            this.OutPutTextBox = new System.Windows.Forms.TextBox();
            this.CustomerGivesLabel = new System.Windows.Forms.Label();
            this.ProgressPanel = new DePandaWinForms.Design.PPanel();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.ProgressText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.PictureBox();
            this.ContactPanel.SuspendLayout();
            this.ProgressPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            this.SuspendLayout();
            // 
            // PinButton
            // 
            this.PinButton.BackColor = System.Drawing.Color.White;
            this.PinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.PinButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(142)))), ((int)(((byte)(149)))));
            this.PinButton.Location = new System.Drawing.Point(70, 105);
            this.PinButton.Name = "PinButton";
            this.PinButton.Size = new System.Drawing.Size(230, 212);
            this.PinButton.TabIndex = 99;
            this.PinButton.Text = "Pinnen";
            this.PinButton.UseVisualStyleBackColor = false;
            this.PinButton.Click += new System.EventHandler(this.PinButton_Click);
            // 
            // CashButton
            // 
            this.CashButton.BackColor = System.Drawing.Color.White;
            this.CashButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CashButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CashButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(142)))), ((int)(((byte)(149)))));
            this.CashButton.Location = new System.Drawing.Point(486, 105);
            this.CashButton.Name = "CashButton";
            this.CashButton.Size = new System.Drawing.Size(230, 212);
            this.CashButton.TabIndex = 100;
            this.CashButton.Text = "Contant";
            this.CashButton.UseVisualStyleBackColor = false;
            this.CashButton.Click += new System.EventHandler(this.CashButton_Click);
            // 
            // Question
            // 
            this.Question.AutoSize = true;
            this.Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Question.Location = new System.Drawing.Point(266, 48);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(261, 26);
            this.Question.TabIndex = 101;
            this.Question.Text = "Hoe wilt de klant betalen?";
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // ContactPanel
            // 
            this.ContactPanel.Controls.Add(this.ConfirmCashPayment);
            this.ContactPanel.Controls.Add(this.TotalGivenAmountBox);
            this.ContactPanel.Controls.Add(this.ChangeLabel);
            this.ContactPanel.Controls.Add(this.OutPutTextBox);
            this.ContactPanel.Controls.Add(this.CustomerGivesLabel);
            this.ContactPanel.Location = new System.Drawing.Point(306, 159);
            this.ContactPanel.Name = "ContactPanel";
            this.ContactPanel.Size = new System.Drawing.Size(174, 158);
            this.ContactPanel.TabIndex = 103;
            this.ContactPanel.Visible = false;
            // 
            // ConfirmCashPayment
            // 
            this.ConfirmCashPayment.BackColor = System.Drawing.Color.White;
            this.ConfirmCashPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmCashPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ConfirmCashPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(142)))), ((int)(((byte)(149)))));
            this.ConfirmCashPayment.Location = new System.Drawing.Point(3, 119);
            this.ConfirmCashPayment.Name = "ConfirmCashPayment";
            this.ConfirmCashPayment.Size = new System.Drawing.Size(120, 25);
            this.ConfirmCashPayment.TabIndex = 105;
            this.ConfirmCashPayment.Text = "Betaald";
            this.ConfirmCashPayment.UseVisualStyleBackColor = false;
            this.ConfirmCashPayment.Click += new System.EventHandler(this.ConfirmCashPayment_Click);
            // 
            // TotalGivenAmountBox
            // 
            this.TotalGivenAmountBox.Location = new System.Drawing.Point(4, 31);
            this.TotalGivenAmountBox.Name = "TotalGivenAmountBox";
            this.TotalGivenAmountBox.Size = new System.Drawing.Size(150, 20);
            this.TotalGivenAmountBox.TabIndex = 4;
            this.TotalGivenAmountBox.Visible = false;
            this.TotalGivenAmountBox.TextChanged += new System.EventHandler(this.TotalGivenAmountBox_TextChanged);
            // 
            // ChangeLabel
            // 
            this.ChangeLabel.AutoSize = true;
            this.ChangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ChangeLabel.Location = new System.Drawing.Point(3, 55);
            this.ChangeLabel.Name = "ChangeLabel";
            this.ChangeLabel.Size = new System.Drawing.Size(96, 17);
            this.ChangeLabel.TabIndex = 3;
            this.ChangeLabel.Text = "U moet geven";
            this.ChangeLabel.Visible = false;
            // 
            // OutPutTextBox
            // 
            this.OutPutTextBox.Location = new System.Drawing.Point(4, 77);
            this.OutPutTextBox.Name = "OutPutTextBox";
            this.OutPutTextBox.Size = new System.Drawing.Size(150, 20);
            this.OutPutTextBox.TabIndex = 2;
            this.OutPutTextBox.Visible = false;
            // 
            // CustomerGivesLabel
            // 
            this.CustomerGivesLabel.AutoSize = true;
            this.CustomerGivesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CustomerGivesLabel.Location = new System.Drawing.Point(3, 11);
            this.CustomerGivesLabel.Name = "CustomerGivesLabel";
            this.CustomerGivesLabel.Size = new System.Drawing.Size(158, 17);
            this.CustomerGivesLabel.TabIndex = 0;
            this.CustomerGivesLabel.Text = "Hoeveel geeft de klant?";
            this.CustomerGivesLabel.Visible = false;
            // 
            // ProgressPanel
            // 
            this.ProgressPanel.Controls.Add(this.ProgressBar);
            this.ProgressPanel.Controls.Add(this.ProgressText);
            this.ProgressPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(142)))), ((int)(((byte)(149)))));
            this.ProgressPanel.Location = new System.Drawing.Point(70, 339);
            this.ProgressPanel.Name = "ProgressPanel";
            this.ProgressPanel.Size = new System.Drawing.Size(174, 99);
            this.ProgressPanel.TabIndex = 102;
            this.ProgressPanel.Visible = false;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(6, 41);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(136, 23);
            this.ProgressBar.TabIndex = 103;
            this.ProgressBar.Visible = false;
            // 
            // ProgressText
            // 
            this.ProgressText.AutoSize = true;
            this.ProgressText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ProgressText.ForeColor = System.Drawing.Color.Black;
            this.ProgressText.Location = new System.Drawing.Point(3, 12);
            this.ProgressText.Name = "ProgressText";
            this.ProgressText.Size = new System.Drawing.Size(139, 17);
            this.ProgressText.TabIndex = 0;
            this.ProgressText.Text = "Bezig met verwerken";
            this.ProgressText.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 32);
            this.panel1.TabIndex = 104;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "De Panda";
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Image = global::DePandaWinForms.Properties.Resources.close;
            this.Close.Location = new System.Drawing.Point(766, 2);
            this.Close.Margin = new System.Windows.Forms.Padding(0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(26, 26);
            this.Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Close.TabIndex = 0;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            this.Close.MouseEnter += new System.EventHandler(this.Close_MouseHover);
            this.Close.MouseLeave += new System.EventHandler(this.Close_MouseHover);
            // 
            // PaymentOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ContactPanel);
            this.Controls.Add(this.ProgressPanel);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.CashButton);
            this.Controls.Add(this.PinButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaymentOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentOption";
            this.ContactPanel.ResumeLayout(false);
            this.ContactPanel.PerformLayout();
            this.ProgressPanel.ResumeLayout(false);
            this.ProgressPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PinButton;
        private System.Windows.Forms.Button CashButton;
        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.Timer Timer;
        private Design.PPanel ContactPanel;
        private System.Windows.Forms.Label ChangeLabel;
        private System.Windows.Forms.TextBox OutPutTextBox;
        private System.Windows.Forms.Label CustomerGivesLabel;
        private System.Windows.Forms.TextBox TotalGivenAmountBox;
        private System.Windows.Forms.Label ProgressText;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private Design.PPanel ProgressPanel;
        private System.Windows.Forms.Button ConfirmCashPayment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Close;
    }
}