using DePandaLib.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DePandaWinForms.Pages
{
    public partial class SettingsPage : Form
    {
        public SettingsPage()
        {
            InitializeComponent();
            int height = Screen.PrimaryScreen.Bounds.Height;
            int width = Screen.PrimaryScreen.Bounds.Width;
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Pincode = new System.Windows.Forms.Label();
            this.SunDayClosed = new System.Windows.Forms.TextBox();
            this.SunDayOpen = new System.Windows.Forms.TextBox();
            this.SaturDayOpen = new System.Windows.Forms.TextBox();
            this.SaturDayClosed = new System.Windows.Forms.TextBox();
            this.FridayOpen = new System.Windows.Forms.TextBox();
            this.FridayClosed = new System.Windows.Forms.TextBox();
            this.ThursDayClosed = new System.Windows.Forms.TextBox();
            this.ThursDayOpen = new System.Windows.Forms.TextBox();
            this.WednesDayOpen = new System.Windows.Forms.TextBox();
            this.WednesDayClosed = new System.Windows.Forms.TextBox();
            this.TuesDayClosed = new System.Windows.Forms.TextBox();
            this.TuesDayOpen = new System.Windows.Forms.TextBox();
            this.MondayClosed = new System.Windows.Forms.TextBox();
            this.MondayOpen = new System.Windows.Forms.TextBox();
            this.ThursDayDot = new System.Windows.Forms.Label();
            this.SunDayDot = new System.Windows.Forms.Label();
            this.SaturDayDot = new System.Windows.Forms.Label();
            this.FridayDot = new System.Windows.Forms.Label();
            this.WednesDayDot = new System.Windows.Forms.Label();
            this.TuesDayDot = new System.Windows.Forms.Label();
            this.MondayDot = new System.Windows.Forms.Label();
            this.SunDayText = new System.Windows.Forms.Label();
            this.SaturDayText = new System.Windows.Forms.Label();
            this.FridayText = new System.Windows.Forms.Label();
            this.ThursDayText = new System.Windows.Forms.Label();
            this.WednesDayText = new System.Windows.Forms.Label();
            this.TuesDayText = new System.Windows.Forms.Label();
            this.MondayText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ChangeBTN = new System.Windows.Forms.Button();
            this.PincodeInput = new System.Windows.Forms.TextBox();
            this.PincodeText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Pincode
            // 
            this.Pincode.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pincode.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pincode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.Pincode.Location = new System.Drawing.Point(0, 0);
            this.Pincode.Margin = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.Pincode.Name = "Pincode";
            this.Pincode.Size = new System.Drawing.Size(880, 37);
            this.Pincode.TabIndex = 15;
            this.Pincode.Text = "Instellingen";
            this.Pincode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SunDayClosed
            // 
            this.SunDayClosed.Location = new System.Drawing.Point(306, 468);
            this.SunDayClosed.MaxLength = 5;
            this.SunDayClosed.Name = "SunDayClosed";
            this.SunDayClosed.Size = new System.Drawing.Size(114, 20);
            this.SunDayClosed.TabIndex = 81;
            this.SunDayClosed.Text = "20.00";
            this.SunDayClosed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SunDayOpen
            // 
            this.SunDayOpen.Location = new System.Drawing.Point(141, 468);
            this.SunDayOpen.MaxLength = 5;
            this.SunDayOpen.Name = "SunDayOpen";
            this.SunDayOpen.Size = new System.Drawing.Size(114, 20);
            this.SunDayOpen.TabIndex = 80;
            this.SunDayOpen.Text = "13.00";
            this.SunDayOpen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SaturDayOpen
            // 
            this.SaturDayOpen.Location = new System.Drawing.Point(141, 428);
            this.SaturDayOpen.MaxLength = 5;
            this.SaturDayOpen.Name = "SaturDayOpen";
            this.SaturDayOpen.Size = new System.Drawing.Size(114, 20);
            this.SaturDayOpen.TabIndex = 79;
            this.SaturDayOpen.Text = "13.00";
            this.SaturDayOpen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SaturDayClosed
            // 
            this.SaturDayClosed.Location = new System.Drawing.Point(306, 428);
            this.SaturDayClosed.MaxLength = 5;
            this.SaturDayClosed.Name = "SaturDayClosed";
            this.SaturDayClosed.Size = new System.Drawing.Size(114, 20);
            this.SaturDayClosed.TabIndex = 78;
            this.SaturDayClosed.Text = "20.00";
            this.SaturDayClosed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FridayOpen
            // 
            this.FridayOpen.Location = new System.Drawing.Point(141, 388);
            this.FridayOpen.MaxLength = 5;
            this.FridayOpen.Name = "FridayOpen";
            this.FridayOpen.Size = new System.Drawing.Size(114, 20);
            this.FridayOpen.TabIndex = 77;
            this.FridayOpen.Text = "13.00";
            this.FridayOpen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FridayClosed
            // 
            this.FridayClosed.Location = new System.Drawing.Point(306, 388);
            this.FridayClosed.MaxLength = 5;
            this.FridayClosed.Name = "FridayClosed";
            this.FridayClosed.Size = new System.Drawing.Size(114, 20);
            this.FridayClosed.TabIndex = 76;
            this.FridayClosed.Text = "20.00";
            this.FridayClosed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ThursDayClosed
            // 
            this.ThursDayClosed.Location = new System.Drawing.Point(306, 348);
            this.ThursDayClosed.MaxLength = 5;
            this.ThursDayClosed.Name = "ThursDayClosed";
            this.ThursDayClosed.Size = new System.Drawing.Size(114, 20);
            this.ThursDayClosed.TabIndex = 75;
            this.ThursDayClosed.Text = "20.00";
            this.ThursDayClosed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ThursDayOpen
            // 
            this.ThursDayOpen.Location = new System.Drawing.Point(141, 348);
            this.ThursDayOpen.MaxLength = 5;
            this.ThursDayOpen.Name = "ThursDayOpen";
            this.ThursDayOpen.Size = new System.Drawing.Size(114, 20);
            this.ThursDayOpen.TabIndex = 74;
            this.ThursDayOpen.Text = "13.00";
            this.ThursDayOpen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WednesDayOpen
            // 
            this.WednesDayOpen.Location = new System.Drawing.Point(141, 308);
            this.WednesDayOpen.MaxLength = 5;
            this.WednesDayOpen.Name = "WednesDayOpen";
            this.WednesDayOpen.Size = new System.Drawing.Size(114, 20);
            this.WednesDayOpen.TabIndex = 73;
            this.WednesDayOpen.Text = "13.00";
            this.WednesDayOpen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WednesDayClosed
            // 
            this.WednesDayClosed.Location = new System.Drawing.Point(306, 308);
            this.WednesDayClosed.MaxLength = 5;
            this.WednesDayClosed.Name = "WednesDayClosed";
            this.WednesDayClosed.Size = new System.Drawing.Size(114, 20);
            this.WednesDayClosed.TabIndex = 72;
            this.WednesDayClosed.Text = "20.00";
            this.WednesDayClosed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TuesDayClosed
            // 
            this.TuesDayClosed.Location = new System.Drawing.Point(306, 268);
            this.TuesDayClosed.MaxLength = 5;
            this.TuesDayClosed.Name = "TuesDayClosed";
            this.TuesDayClosed.Size = new System.Drawing.Size(114, 20);
            this.TuesDayClosed.TabIndex = 71;
            this.TuesDayClosed.Text = "20.00";
            this.TuesDayClosed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TuesDayOpen
            // 
            this.TuesDayOpen.Location = new System.Drawing.Point(141, 268);
            this.TuesDayOpen.MaxLength = 5;
            this.TuesDayOpen.Name = "TuesDayOpen";
            this.TuesDayOpen.Size = new System.Drawing.Size(114, 20);
            this.TuesDayOpen.TabIndex = 70;
            this.TuesDayOpen.Text = "13.00";
            this.TuesDayOpen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MondayClosed
            // 
            this.MondayClosed.Location = new System.Drawing.Point(306, 225);
            this.MondayClosed.MaxLength = 5;
            this.MondayClosed.Name = "MondayClosed";
            this.MondayClosed.Size = new System.Drawing.Size(114, 20);
            this.MondayClosed.TabIndex = 69;
            this.MondayClosed.Text = "20.00";
            this.MondayClosed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MondayClosed.TextChanged += new System.EventHandler(this.MondayClosed_TextChanged);
            // 
            // MondayOpen
            // 
            this.MondayOpen.Location = new System.Drawing.Point(141, 225);
            this.MondayOpen.MaxLength = 5;
            this.MondayOpen.Name = "MondayOpen";
            this.MondayOpen.Size = new System.Drawing.Size(114, 20);
            this.MondayOpen.TabIndex = 68;
            this.MondayOpen.Text = "13.00";
            this.MondayOpen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ThursDayDot
            // 
            this.ThursDayDot.AutoSize = true;
            this.ThursDayDot.Location = new System.Drawing.Point(275, 351);
            this.ThursDayDot.Name = "ThursDayDot";
            this.ThursDayDot.Size = new System.Drawing.Size(10, 13);
            this.ThursDayDot.TabIndex = 67;
            this.ThursDayDot.Text = "-";
            // 
            // SunDayDot
            // 
            this.SunDayDot.AutoSize = true;
            this.SunDayDot.Location = new System.Drawing.Point(275, 471);
            this.SunDayDot.Name = "SunDayDot";
            this.SunDayDot.Size = new System.Drawing.Size(10, 13);
            this.SunDayDot.TabIndex = 66;
            this.SunDayDot.Text = "-";
            // 
            // SaturDayDot
            // 
            this.SaturDayDot.AutoSize = true;
            this.SaturDayDot.Location = new System.Drawing.Point(275, 431);
            this.SaturDayDot.Name = "SaturDayDot";
            this.SaturDayDot.Size = new System.Drawing.Size(10, 13);
            this.SaturDayDot.TabIndex = 65;
            this.SaturDayDot.Text = "-";
            // 
            // FridayDot
            // 
            this.FridayDot.AutoSize = true;
            this.FridayDot.Location = new System.Drawing.Point(275, 391);
            this.FridayDot.Name = "FridayDot";
            this.FridayDot.Size = new System.Drawing.Size(10, 13);
            this.FridayDot.TabIndex = 64;
            this.FridayDot.Text = "-";
            // 
            // WednesDayDot
            // 
            this.WednesDayDot.AutoSize = true;
            this.WednesDayDot.Location = new System.Drawing.Point(275, 311);
            this.WednesDayDot.Name = "WednesDayDot";
            this.WednesDayDot.Size = new System.Drawing.Size(10, 13);
            this.WednesDayDot.TabIndex = 63;
            this.WednesDayDot.Text = "-";
            // 
            // TuesDayDot
            // 
            this.TuesDayDot.AutoSize = true;
            this.TuesDayDot.Location = new System.Drawing.Point(275, 271);
            this.TuesDayDot.Name = "TuesDayDot";
            this.TuesDayDot.Size = new System.Drawing.Size(10, 13);
            this.TuesDayDot.TabIndex = 62;
            this.TuesDayDot.Text = "-";
            // 
            // MondayDot
            // 
            this.MondayDot.AutoSize = true;
            this.MondayDot.Location = new System.Drawing.Point(275, 233);
            this.MondayDot.Name = "MondayDot";
            this.MondayDot.Size = new System.Drawing.Size(10, 13);
            this.MondayDot.TabIndex = 61;
            this.MondayDot.Text = "-";
            // 
            // SunDayText
            // 
            this.SunDayText.AutoSize = true;
            this.SunDayText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SunDayText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.SunDayText.Location = new System.Drawing.Point(23, 465);
            this.SunDayText.Name = "SunDayText";
            this.SunDayText.Size = new System.Drawing.Size(44, 13);
            this.SunDayText.TabIndex = 60;
            this.SunDayText.Text = "Zondag";
            // 
            // SaturDayText
            // 
            this.SaturDayText.AutoSize = true;
            this.SaturDayText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaturDayText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.SaturDayText.Location = new System.Drawing.Point(23, 425);
            this.SaturDayText.Name = "SaturDayText";
            this.SaturDayText.Size = new System.Drawing.Size(50, 13);
            this.SaturDayText.TabIndex = 59;
            this.SaturDayText.Text = "Zaterdag";
            // 
            // FridayText
            // 
            this.FridayText.AutoSize = true;
            this.FridayText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FridayText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.FridayText.Location = new System.Drawing.Point(23, 388);
            this.FridayText.Name = "FridayText";
            this.FridayText.Size = new System.Drawing.Size(39, 13);
            this.FridayText.TabIndex = 58;
            this.FridayText.Text = "Vrijdag";
            this.FridayText.Click += new System.EventHandler(this.FridayText_Click);
            // 
            // ThursDayText
            // 
            this.ThursDayText.AutoSize = true;
            this.ThursDayText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThursDayText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.ThursDayText.Location = new System.Drawing.Point(22, 348);
            this.ThursDayText.Name = "ThursDayText";
            this.ThursDayText.Size = new System.Drawing.Size(60, 13);
            this.ThursDayText.TabIndex = 57;
            this.ThursDayText.Text = "Donderdag";
            // 
            // WednesDayText
            // 
            this.WednesDayText.AutoSize = true;
            this.WednesDayText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WednesDayText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.WednesDayText.Location = new System.Drawing.Point(22, 308);
            this.WednesDayText.Name = "WednesDayText";
            this.WednesDayText.Size = new System.Drawing.Size(59, 13);
            this.WednesDayText.TabIndex = 56;
            this.WednesDayText.Text = "Woensdag";
            // 
            // TuesDayText
            // 
            this.TuesDayText.AutoSize = true;
            this.TuesDayText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TuesDayText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.TuesDayText.Location = new System.Drawing.Point(23, 268);
            this.TuesDayText.Name = "TuesDayText";
            this.TuesDayText.Size = new System.Drawing.Size(46, 13);
            this.TuesDayText.TabIndex = 55;
            this.TuesDayText.Text = "Dinsdag";
            // 
            // MondayText
            // 
            this.MondayText.AutoSize = true;
            this.MondayText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MondayText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.MondayText.Location = new System.Drawing.Point(23, 228);
            this.MondayText.Name = "MondayText";
            this.MondayText.Size = new System.Drawing.Size(52, 13);
            this.MondayText.TabIndex = 54;
            this.MondayText.Text = "Maandag";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.label2.Location = new System.Drawing.Point(23, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 53;
            this.label2.Text = "Openingstijden: ";
            // 
            // ChangeBTN
            // 
            this.ChangeBTN.BackColor = System.Drawing.Color.White;
            this.ChangeBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(142)))), ((int)(((byte)(149)))));
            this.ChangeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(142)))), ((int)(((byte)(149)))));
            this.ChangeBTN.Location = new System.Drawing.Point(25, 117);
            this.ChangeBTN.Margin = new System.Windows.Forms.Padding(0);
            this.ChangeBTN.Name = "ChangeBTN";
            this.ChangeBTN.Size = new System.Drawing.Size(130, 26);
            this.ChangeBTN.TabIndex = 52;
            this.ChangeBTN.Text = "wijzigen";
            this.ChangeBTN.UseVisualStyleBackColor = false;
            this.ChangeBTN.Click += new System.EventHandler(this.ChangeBTN_Click_1);
            // 
            // PincodeInput
            // 
            this.PincodeInput.BackColor = System.Drawing.Color.White;
            this.PincodeInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PincodeInput.Location = new System.Drawing.Point(25, 92);
            this.PincodeInput.MaxLength = 5;
            this.PincodeInput.Multiline = true;
            this.PincodeInput.Name = "PincodeInput";
            this.PincodeInput.Size = new System.Drawing.Size(130, 22);
            this.PincodeInput.TabIndex = 51;
            this.PincodeInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PincodeInput.TextChanged += new System.EventHandler(this.PincodeInput_TextChanged);
            // 
            // PincodeText
            // 
            this.PincodeText.AutoSize = true;
            this.PincodeText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.PincodeText.Location = new System.Drawing.Point(23, 67);
            this.PincodeText.Name = "PincodeText";
            this.PincodeText.Size = new System.Drawing.Size(49, 13);
            this.PincodeText.TabIndex = 50;
            this.PincodeText.Text = "Pincode:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(764, 618);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 82;
            this.label3.Text = "label3";
            // 
            // SettingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 683);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SunDayClosed);
            this.Controls.Add(this.SunDayOpen);
            this.Controls.Add(this.SaturDayOpen);
            this.Controls.Add(this.SaturDayClosed);
            this.Controls.Add(this.FridayOpen);
            this.Controls.Add(this.FridayClosed);
            this.Controls.Add(this.ThursDayClosed);
            this.Controls.Add(this.ThursDayOpen);
            this.Controls.Add(this.WednesDayOpen);
            this.Controls.Add(this.WednesDayClosed);
            this.Controls.Add(this.TuesDayClosed);
            this.Controls.Add(this.TuesDayOpen);
            this.Controls.Add(this.MondayClosed);
            this.Controls.Add(this.MondayOpen);
            this.Controls.Add(this.ThursDayDot);
            this.Controls.Add(this.SunDayDot);
            this.Controls.Add(this.SaturDayDot);
            this.Controls.Add(this.FridayDot);
            this.Controls.Add(this.WednesDayDot);
            this.Controls.Add(this.TuesDayDot);
            this.Controls.Add(this.MondayDot);
            this.Controls.Add(this.SunDayText);
            this.Controls.Add(this.SaturDayText);
            this.Controls.Add(this.FridayText);
            this.Controls.Add(this.ThursDayText);
            this.Controls.Add(this.WednesDayText);
            this.Controls.Add(this.TuesDayText);
            this.Controls.Add(this.MondayText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ChangeBTN);
            this.Controls.Add(this.PincodeInput);
            this.Controls.Add(this.PincodeText);
            this.Controls.Add(this.Pincode);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SettingsPage";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MondayClosed_TextChanged(object sender, EventArgs e)
        {

        }

        private void FridayText_Click(object sender, EventArgs e)
        {

        }

        private void PincodeInput_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void ChangeBTN_Click_1(object sender, EventArgs e)
        {
            if (PincodeInput.Text.All(char.IsDigit)) 
            {
                DataStorageHandler.Storage.Settings.PinCode = PincodeInput.Text;
            }
            else
            {
                MessageBox.Show("Een pincode mag alleen uit cijfers bestaan.");
            }
        }
    }
}
