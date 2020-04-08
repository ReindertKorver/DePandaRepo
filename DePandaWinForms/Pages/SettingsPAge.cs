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
            this.WednesDayClosed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Opentimes = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Opentimes.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.Pincode.Size = new System.Drawing.Size(1683, 37);
            this.Pincode.TabIndex = 15;
            this.Pincode.Text = "Instellingen";
            this.Pincode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SunDayClosed
            // 
            this.SunDayClosed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SunDayClosed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SunDayClosed.Location = new System.Drawing.Point(270, 322);
            this.SunDayClosed.MaxLength = 5;
            this.SunDayClosed.Name = "SunDayClosed";
            this.SunDayClosed.Size = new System.Drawing.Size(114, 20);
            this.SunDayClosed.TabIndex = 81;
            this.SunDayClosed.Text = "20.00";
            this.SunDayClosed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SunDayOpen
            // 
            this.SunDayOpen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SunDayOpen.Location = new System.Drawing.Point(132, 322);
            this.SunDayOpen.MaxLength = 5;
            this.SunDayOpen.Name = "SunDayOpen";
            this.SunDayOpen.Size = new System.Drawing.Size(114, 20);
            this.SunDayOpen.TabIndex = 80;
            this.SunDayOpen.Text = "13.00";
            this.SunDayOpen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SaturDayOpen
            // 
            this.SaturDayOpen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaturDayOpen.Location = new System.Drawing.Point(132, 275);
            this.SaturDayOpen.MaxLength = 5;
            this.SaturDayOpen.Name = "SaturDayOpen";
            this.SaturDayOpen.Size = new System.Drawing.Size(114, 20);
            this.SaturDayOpen.TabIndex = 79;
            this.SaturDayOpen.Text = "13.00";
            this.SaturDayOpen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SaturDayClosed
            // 
            this.SaturDayClosed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaturDayClosed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SaturDayClosed.Location = new System.Drawing.Point(270, 275);
            this.SaturDayClosed.MaxLength = 5;
            this.SaturDayClosed.Name = "SaturDayClosed";
            this.SaturDayClosed.Size = new System.Drawing.Size(114, 20);
            this.SaturDayClosed.TabIndex = 78;
            this.SaturDayClosed.Text = "20.00";
            this.SaturDayClosed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FridayOpen
            // 
            this.FridayOpen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FridayOpen.Location = new System.Drawing.Point(132, 229);
            this.FridayOpen.MaxLength = 5;
            this.FridayOpen.Name = "FridayOpen";
            this.FridayOpen.Size = new System.Drawing.Size(114, 20);
            this.FridayOpen.TabIndex = 77;
            this.FridayOpen.Text = "13.00";
            this.FridayOpen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FridayClosed
            // 
            this.FridayClosed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FridayClosed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FridayClosed.Location = new System.Drawing.Point(270, 229);
            this.FridayClosed.MaxLength = 5;
            this.FridayClosed.Name = "FridayClosed";
            this.FridayClosed.Size = new System.Drawing.Size(114, 20);
            this.FridayClosed.TabIndex = 76;
            this.FridayClosed.Text = "20.00";
            this.FridayClosed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ThursDayClosed
            // 
            this.ThursDayClosed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ThursDayClosed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ThursDayClosed.Location = new System.Drawing.Point(270, 183);
            this.ThursDayClosed.MaxLength = 5;
            this.ThursDayClosed.Name = "ThursDayClosed";
            this.ThursDayClosed.Size = new System.Drawing.Size(114, 20);
            this.ThursDayClosed.TabIndex = 75;
            this.ThursDayClosed.Text = "20.00";
            this.ThursDayClosed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ThursDayOpen
            // 
            this.ThursDayOpen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ThursDayOpen.Location = new System.Drawing.Point(132, 183);
            this.ThursDayOpen.MaxLength = 5;
            this.ThursDayOpen.Name = "ThursDayOpen";
            this.ThursDayOpen.Size = new System.Drawing.Size(114, 20);
            this.ThursDayOpen.TabIndex = 74;
            this.ThursDayOpen.Text = "13.00";
            this.ThursDayOpen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WednesDayOpen
            // 
            this.WednesDayOpen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WednesDayOpen.Location = new System.Drawing.Point(132, 137);
            this.WednesDayOpen.MaxLength = 5;
            this.WednesDayOpen.Name = "WednesDayOpen";
            this.WednesDayOpen.Size = new System.Drawing.Size(114, 20);
            this.WednesDayOpen.TabIndex = 73;
            this.WednesDayOpen.Text = "13.00";
            this.WednesDayOpen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TuesDayClosed
            // 
            this.TuesDayClosed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TuesDayClosed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TuesDayClosed.Location = new System.Drawing.Point(270, 91);
            this.TuesDayClosed.MaxLength = 5;
            this.TuesDayClosed.Name = "TuesDayClosed";
            this.TuesDayClosed.Size = new System.Drawing.Size(114, 20);
            this.TuesDayClosed.TabIndex = 71;
            this.TuesDayClosed.Text = "20.00";
            this.TuesDayClosed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TuesDayOpen
            // 
            this.TuesDayOpen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TuesDayOpen.Location = new System.Drawing.Point(132, 91);
            this.TuesDayOpen.MaxLength = 5;
            this.TuesDayOpen.Name = "TuesDayOpen";
            this.TuesDayOpen.Size = new System.Drawing.Size(114, 20);
            this.TuesDayOpen.TabIndex = 70;
            this.TuesDayOpen.Text = "13.00";
            this.TuesDayOpen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MondayClosed
            // 
            this.MondayClosed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MondayClosed.BackColor = System.Drawing.SystemColors.Window;
            this.MondayClosed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MondayClosed.Location = new System.Drawing.Point(270, 45);
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
            this.MondayOpen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MondayOpen.Location = new System.Drawing.Point(132, 45);
            this.MondayOpen.MaxLength = 5;
            this.MondayOpen.Name = "MondayOpen";
            this.MondayOpen.Size = new System.Drawing.Size(114, 20);
            this.MondayOpen.TabIndex = 68;
            this.MondayOpen.Text = "13.00";
            this.MondayOpen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ThursDayDot
            // 
            this.ThursDayDot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ThursDayDot.AutoSize = true;
            this.ThursDayDot.Location = new System.Drawing.Point(252, 186);
            this.ThursDayDot.Name = "ThursDayDot";
            this.ThursDayDot.Size = new System.Drawing.Size(10, 13);
            this.ThursDayDot.TabIndex = 67;
            this.ThursDayDot.Text = "-";
            // 
            // SunDayDot
            // 
            this.SunDayDot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SunDayDot.AutoSize = true;
            this.SunDayDot.Location = new System.Drawing.Point(252, 326);
            this.SunDayDot.Name = "SunDayDot";
            this.SunDayDot.Size = new System.Drawing.Size(10, 13);
            this.SunDayDot.TabIndex = 66;
            this.SunDayDot.Text = "-";
            // 
            // SaturDayDot
            // 
            this.SaturDayDot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaturDayDot.AutoSize = true;
            this.SaturDayDot.Location = new System.Drawing.Point(252, 278);
            this.SaturDayDot.Name = "SaturDayDot";
            this.SaturDayDot.Size = new System.Drawing.Size(10, 13);
            this.SaturDayDot.TabIndex = 65;
            this.SaturDayDot.Text = "-";
            // 
            // FridayDot
            // 
            this.FridayDot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FridayDot.AutoSize = true;
            this.FridayDot.Location = new System.Drawing.Point(252, 232);
            this.FridayDot.Name = "FridayDot";
            this.FridayDot.Size = new System.Drawing.Size(10, 13);
            this.FridayDot.TabIndex = 64;
            this.FridayDot.Text = "-";
            // 
            // WednesDayDot
            // 
            this.WednesDayDot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WednesDayDot.AutoSize = true;
            this.WednesDayDot.Location = new System.Drawing.Point(252, 140);
            this.WednesDayDot.Name = "WednesDayDot";
            this.WednesDayDot.Size = new System.Drawing.Size(10, 13);
            this.WednesDayDot.TabIndex = 63;
            this.WednesDayDot.Text = "-";
            // 
            // TuesDayDot
            // 
            this.TuesDayDot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TuesDayDot.AutoSize = true;
            this.TuesDayDot.Location = new System.Drawing.Point(252, 94);
            this.TuesDayDot.Name = "TuesDayDot";
            this.TuesDayDot.Size = new System.Drawing.Size(10, 13);
            this.TuesDayDot.TabIndex = 62;
            this.TuesDayDot.Text = "-";
            // 
            // MondayDot
            // 
            this.MondayDot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MondayDot.AutoSize = true;
            this.MondayDot.Location = new System.Drawing.Point(252, 48);
            this.MondayDot.Name = "MondayDot";
            this.MondayDot.Size = new System.Drawing.Size(10, 13);
            this.MondayDot.TabIndex = 61;
            this.MondayDot.Text = "-";
            // 
            // SunDayText
            // 
            this.SunDayText.AutoSize = true;
            this.SunDayText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SunDayText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SunDayText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.SunDayText.Location = new System.Drawing.Point(3, 308);
            this.SunDayText.Name = "SunDayText";
            this.SunDayText.Size = new System.Drawing.Size(123, 49);
            this.SunDayText.TabIndex = 60;
            this.SunDayText.Text = "Zondag";
            this.SunDayText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SaturDayText
            // 
            this.SaturDayText.AutoSize = true;
            this.SaturDayText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaturDayText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SaturDayText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.SaturDayText.Location = new System.Drawing.Point(3, 262);
            this.SaturDayText.Name = "SaturDayText";
            this.SaturDayText.Size = new System.Drawing.Size(123, 46);
            this.SaturDayText.TabIndex = 59;
            this.SaturDayText.Text = "Zaterdag";
            this.SaturDayText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FridayText
            // 
            this.FridayText.AutoSize = true;
            this.FridayText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FridayText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FridayText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.FridayText.Location = new System.Drawing.Point(3, 216);
            this.FridayText.Name = "FridayText";
            this.FridayText.Size = new System.Drawing.Size(123, 46);
            this.FridayText.TabIndex = 58;
            this.FridayText.Text = "Vrijdag";
            this.FridayText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FridayText.Click += new System.EventHandler(this.FridayText_Click);
            // 
            // ThursDayText
            // 
            this.ThursDayText.AutoSize = true;
            this.ThursDayText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThursDayText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ThursDayText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.ThursDayText.Location = new System.Drawing.Point(3, 170);
            this.ThursDayText.Name = "ThursDayText";
            this.ThursDayText.Size = new System.Drawing.Size(123, 46);
            this.ThursDayText.TabIndex = 57;
            this.ThursDayText.Text = "Donderdag";
            this.ThursDayText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WednesDayText
            // 
            this.WednesDayText.AutoSize = true;
            this.WednesDayText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WednesDayText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.WednesDayText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.WednesDayText.Location = new System.Drawing.Point(3, 124);
            this.WednesDayText.Name = "WednesDayText";
            this.WednesDayText.Size = new System.Drawing.Size(123, 46);
            this.WednesDayText.TabIndex = 56;
            this.WednesDayText.Text = "Woensdag";
            this.WednesDayText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TuesDayText
            // 
            this.TuesDayText.AutoSize = true;
            this.TuesDayText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TuesDayText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TuesDayText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.TuesDayText.Location = new System.Drawing.Point(3, 78);
            this.TuesDayText.Name = "TuesDayText";
            this.TuesDayText.Size = new System.Drawing.Size(123, 46);
            this.TuesDayText.TabIndex = 55;
            this.TuesDayText.Text = "Dinsdag";
            this.TuesDayText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MondayText
            // 
            this.MondayText.AutoSize = true;
            this.MondayText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MondayText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MondayText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.MondayText.Location = new System.Drawing.Point(3, 32);
            this.MondayText.Name = "MondayText";
            this.MondayText.Size = new System.Drawing.Size(123, 46);
            this.MondayText.TabIndex = 54;
            this.MondayText.Text = "Maandag";
            this.MondayText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 32);
            this.label2.TabIndex = 53;
            this.label2.Text = "Openingstijden: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ChangeBTN
            // 
            this.ChangeBTN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ChangeBTN.BackColor = System.Drawing.Color.White;
            this.ChangeBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(142)))), ((int)(((byte)(149)))));
            this.ChangeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(142)))), ((int)(((byte)(149)))));
            this.ChangeBTN.Location = new System.Drawing.Point(0, 75);
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
            this.PincodeInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PincodeInput.BackColor = System.Drawing.Color.White;
            this.PincodeInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PincodeInput.Location = new System.Drawing.Point(3, 41);
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
            this.PincodeText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PincodeText.AutoSize = true;
            this.PincodeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PincodeText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.PincodeText.Location = new System.Drawing.Point(3, 7);
            this.PincodeText.Name = "PincodeText";
            this.PincodeText.Size = new System.Drawing.Size(70, 20);
            this.PincodeText.TabIndex = 50;
            this.PincodeText.Text = "Pincode:";
            // 
            // WednesDayClosed
            // 
            this.WednesDayClosed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WednesDayClosed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WednesDayClosed.Location = new System.Drawing.Point(270, 137);
            this.WednesDayClosed.MaxLength = 5;
            this.WednesDayClosed.Name = "WednesDayClosed";
            this.WednesDayClosed.Size = new System.Drawing.Size(114, 20);
            this.WednesDayClosed.TabIndex = 72;
            this.WednesDayClosed.Text = "20.00";
            this.WednesDayClosed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1567, 1035);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 82;
            this.label3.Text = "label3";
            // 
            // Opentimes
            // 
            this.Opentimes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Opentimes.ColumnCount = 4;
            this.Opentimes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Opentimes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Opentimes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Opentimes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Opentimes.Controls.Add(this.WednesDayClosed, 3, 3);
            this.Opentimes.Controls.Add(this.SunDayDot, 2, 7);
            this.Opentimes.Controls.Add(this.ThursDayDot, 2, 4);
            this.Opentimes.Controls.Add(this.SaturDayDot, 2, 6);
            this.Opentimes.Controls.Add(this.TuesDayOpen, 1, 2);
            this.Opentimes.Controls.Add(this.label2, 0, 0);
            this.Opentimes.Controls.Add(this.FridayDot, 2, 5);
            this.Opentimes.Controls.Add(this.MondayDot, 2, 1);
            this.Opentimes.Controls.Add(this.WednesDayOpen, 1, 3);
            this.Opentimes.Controls.Add(this.ThursDayOpen, 1, 4);
            this.Opentimes.Controls.Add(this.WednesDayDot, 2, 3);
            this.Opentimes.Controls.Add(this.FridayOpen, 1, 5);
            this.Opentimes.Controls.Add(this.SaturDayOpen, 1, 6);
            this.Opentimes.Controls.Add(this.TuesDayDot, 2, 2);
            this.Opentimes.Controls.Add(this.SunDayClosed, 3, 7);
            this.Opentimes.Controls.Add(this.MondayOpen, 1, 1);
            this.Opentimes.Controls.Add(this.MondayText, 0, 1);
            this.Opentimes.Controls.Add(this.TuesDayText, 0, 2);
            this.Opentimes.Controls.Add(this.SaturDayClosed, 3, 6);
            this.Opentimes.Controls.Add(this.WednesDayText, 0, 3);
            this.Opentimes.Controls.Add(this.ThursDayText, 0, 4);
            this.Opentimes.Controls.Add(this.FridayClosed, 3, 5);
            this.Opentimes.Controls.Add(this.FridayText, 0, 5);
            this.Opentimes.Controls.Add(this.SaturDayText, 0, 6);
            this.Opentimes.Controls.Add(this.SunDayText, 0, 7);
            this.Opentimes.Controls.Add(this.TuesDayClosed, 3, 2);
            this.Opentimes.Controls.Add(this.SunDayOpen, 1, 7);
            this.Opentimes.Controls.Add(this.ThursDayClosed, 3, 4);
            this.Opentimes.Controls.Add(this.MondayClosed, 3, 1);
            this.Opentimes.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.Opentimes.Location = new System.Drawing.Point(36, 239);
            this.Opentimes.Name = "Opentimes";
            this.Opentimes.RowCount = 8;
            this.Opentimes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.09091F));
            this.Opentimes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.98701F));
            this.Opentimes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.98701F));
            this.Opentimes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.98701F));
            this.Opentimes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.98701F));
            this.Opentimes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.98701F));
            this.Opentimes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.98701F));
            this.Opentimes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.98701F));
            this.Opentimes.Size = new System.Drawing.Size(390, 357);
            this.Opentimes.TabIndex = 83;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.PincodeInput, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ChangeBTN, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.PincodeText, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(36, 88);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(157, 107);
            this.tableLayoutPanel1.TabIndex = 82;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Control;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Woensdag\t08-04-2020\t13.00\t19.00"});
            this.listBox1.Location = new System.Drawing.Point(451, 239);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(360, 356);
            this.listBox1.TabIndex = 84;
            // 
            // SettingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1683, 1100);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Opentimes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Pincode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SettingsPage";
            this.Text = "Settings";
            this.Opentimes.ResumeLayout(false);
            this.Opentimes.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
                MessageBox.Show($"Uw pincode is gewijzigd naar {DataStorageHandler.Storage.Settings.PinCode}");
            }
            else
            {
                MessageBox.Show("Een pincode mag alleen uit cijfers bestaan.");
            }
        }
    }
}
