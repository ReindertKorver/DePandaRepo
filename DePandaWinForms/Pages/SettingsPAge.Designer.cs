namespace DePandaWinForms.Pages
{
    partial class SettingsPage
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
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Pincode = new System.Windows.Forms.Label();
            this.PincodeInput = new System.Windows.Forms.TextBox();
            this.PincodeText = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ChangePincodeButton = new System.Windows.Forms.Button();
            this.ListOfAlternativeDays = new System.Windows.Forms.ListBox();
            this.AddAlternativeDay = new System.Windows.Forms.Button();
            this.DatePlanner = new System.Windows.Forms.DateTimePicker();
            this.OpenAlternative = new System.Windows.Forms.Label();
            this.ClosedAlternative = new System.Windows.Forms.Label();
            this.PanelAlternativeDay = new System.Windows.Forms.Panel();
            this.DeleteAlternativeDay = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.MondayClosedCheck = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.SundayText = new System.Windows.Forms.Label();
            this.SaturdayText = new System.Windows.Forms.Label();
            this.FridayText = new System.Windows.Forms.Label();
            this.ThursdayText = new System.Windows.Forms.Label();
            this.WednesdayText = new System.Windows.Forms.Label();
            this.TuesdayText = new System.Windows.Forms.Label();
            this.MondayText = new System.Windows.Forms.Label();
            this.TuesdayDot = new System.Windows.Forms.Label();
            this.WednesdayDot = new System.Windows.Forms.Label();
            this.MondayDot = new System.Windows.Forms.Label();
            this.FridayDot = new System.Windows.Forms.Label();
            this.RegularTimesText = new System.Windows.Forms.Label();
            this.SaturdayDot = new System.Windows.Forms.Label();
            this.ThursdayDot = new System.Windows.Forms.Label();
            this.SundayDot = new System.Windows.Forms.Label();
            this.Opentimes = new System.Windows.Forms.TableLayoutPanel();
            this.MondayOpenPicker = new System.Windows.Forms.DateTimePicker();
            this.MondayClosedPicker = new System.Windows.Forms.DateTimePicker();
            this.TuesdayOpenPicker = new System.Windows.Forms.DateTimePicker();
            this.TuesdayClosedPicker = new System.Windows.Forms.DateTimePicker();
            this.WednesdayOpenPicker = new System.Windows.Forms.DateTimePicker();
            this.WednesdayClosedPicker = new System.Windows.Forms.DateTimePicker();
            this.ThursdayOpenPicker = new System.Windows.Forms.DateTimePicker();
            this.ThursdayClosedPicker = new System.Windows.Forms.DateTimePicker();
            this.FridayOpenPicker = new System.Windows.Forms.DateTimePicker();
            this.FridayClosedPicker = new System.Windows.Forms.DateTimePicker();
            this.SaturdayOpenPicker = new System.Windows.Forms.DateTimePicker();
            this.SaturdayClosedPicker = new System.Windows.Forms.DateTimePicker();
            this.SundayOpenPicker = new System.Windows.Forms.DateTimePicker();
            this.SundayClosedPicker = new System.Windows.Forms.DateTimePicker();
            this.AlternativeDayOpenPicker = new System.Windows.Forms.DateTimePicker();
            this.AlternativeDayClosedPicker = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            this.PanelAlternativeDay.SuspendLayout();
            this.Opentimes.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 96;
            // 
            // Pincode
            // 
            this.Pincode.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pincode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.Pincode.Location = new System.Drawing.Point(0, 0);
            this.Pincode.Margin = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.Pincode.Name = "Pincode";
            this.Pincode.Size = new System.Drawing.Size(1067, 37);
            this.Pincode.TabIndex = 15;
            this.Pincode.Text = "Instellingen";
            this.Pincode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PincodeInput
            // 
            this.PincodeInput.BackColor = System.Drawing.Color.White;
            this.PincodeInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PincodeInput.Location = new System.Drawing.Point(3, 38);
            this.PincodeInput.MaxLength = 5;
            this.PincodeInput.Multiline = true;
            this.PincodeInput.Name = "PincodeInput";
            this.PincodeInput.Size = new System.Drawing.Size(130, 22);
            this.PincodeInput.TabIndex = 51;
            this.PincodeInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PincodeText
            // 
            this.PincodeText.AutoSize = true;
            this.PincodeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PincodeText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.PincodeText.Location = new System.Drawing.Point(3, 0);
            this.PincodeText.Name = "PincodeText";
            this.PincodeText.Size = new System.Drawing.Size(70, 20);
            this.PincodeText.TabIndex = 50;
            this.PincodeText.Text = "Pincode:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.PincodeInput, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.PincodeText, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ChangePincodeButton, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 44);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(157, 107);
            this.tableLayoutPanel1.TabIndex = 82;
            // 
            // ChangePincodeButton
            // 
            this.ChangePincodeButton.BackColor = System.Drawing.Color.White;
            this.ChangePincodeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(142)))), ((int)(((byte)(149)))));
            this.ChangePincodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePincodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePincodeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(142)))), ((int)(((byte)(149)))));
            this.ChangePincodeButton.Location = new System.Drawing.Point(0, 70);
            this.ChangePincodeButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChangePincodeButton.Name = "ChangePincodeButton";
            this.ChangePincodeButton.Size = new System.Drawing.Size(130, 29);
            this.ChangePincodeButton.TabIndex = 53;
            this.ChangePincodeButton.Text = "wijzigen";
            this.ChangePincodeButton.UseVisualStyleBackColor = false;
            this.ChangePincodeButton.Click += new System.EventHandler(this.ChangePincodeClick);
            // 
            // ListOfAlternativeDays
            // 
            this.ListOfAlternativeDays.BackColor = System.Drawing.SystemColors.Control;
            this.ListOfAlternativeDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ListOfAlternativeDays.FormattingEnabled = true;
            this.ListOfAlternativeDays.ItemHeight = 20;
            this.ListOfAlternativeDays.Location = new System.Drawing.Point(7, 43);
            this.ListOfAlternativeDays.Name = "ListOfAlternativeDays";
            this.ListOfAlternativeDays.Size = new System.Drawing.Size(251, 304);
            this.ListOfAlternativeDays.TabIndex = 84;
            // 
            // AddAlternativeDay
            // 
            this.AddAlternativeDay.BackColor = System.Drawing.SystemColors.Control;
            this.AddAlternativeDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAlternativeDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(142)))), ((int)(((byte)(149)))));
            this.AddAlternativeDay.Location = new System.Drawing.Point(278, 148);
            this.AddAlternativeDay.Name = "AddAlternativeDay";
            this.AddAlternativeDay.Size = new System.Drawing.Size(183, 44);
            this.AddAlternativeDay.TabIndex = 87;
            this.AddAlternativeDay.Text = "Datum toevoegen";
            this.AddAlternativeDay.UseVisualStyleBackColor = false;
            this.AddAlternativeDay.Click += new System.EventHandler(this.AddAlternativeDay_Click);
            // 
            // DatePlanner
            // 
            this.DatePlanner.Location = new System.Drawing.Point(278, 19);
            this.DatePlanner.Name = "DatePlanner";
            this.DatePlanner.Size = new System.Drawing.Size(183, 20);
            this.DatePlanner.TabIndex = 91;
            // 
            // OpenAlternative
            // 
            this.OpenAlternative.Location = new System.Drawing.Point(275, 66);
            this.OpenAlternative.Name = "OpenAlternative";
            this.OpenAlternative.Size = new System.Drawing.Size(76, 23);
            this.OpenAlternative.TabIndex = 94;
            this.OpenAlternative.Text = "Geopend";
            this.OpenAlternative.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClosedAlternative
            // 
            this.ClosedAlternative.Location = new System.Drawing.Point(385, 66);
            this.ClosedAlternative.Name = "ClosedAlternative";
            this.ClosedAlternative.Size = new System.Drawing.Size(76, 23);
            this.ClosedAlternative.TabIndex = 95;
            this.ClosedAlternative.Text = "Gesloten";
            this.ClosedAlternative.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelAlternativeDay
            // 
            this.PanelAlternativeDay.Controls.Add(this.AlternativeDayClosedPicker);
            this.PanelAlternativeDay.Controls.Add(this.AlternativeDayOpenPicker);
            this.PanelAlternativeDay.Controls.Add(this.DeleteAlternativeDay);
            this.PanelAlternativeDay.Controls.Add(this.label3);
            this.PanelAlternativeDay.Controls.Add(this.ListOfAlternativeDays);
            this.PanelAlternativeDay.Controls.Add(this.ClosedAlternative);
            this.PanelAlternativeDay.Controls.Add(this.AddAlternativeDay);
            this.PanelAlternativeDay.Controls.Add(this.OpenAlternative);
            this.PanelAlternativeDay.Controls.Add(this.DatePlanner);
            this.PanelAlternativeDay.Location = new System.Drawing.Point(576, 82);
            this.PanelAlternativeDay.Name = "PanelAlternativeDay";
            this.PanelAlternativeDay.Size = new System.Drawing.Size(471, 356);
            this.PanelAlternativeDay.TabIndex = 97;
            // 
            // DeleteAlternativeDay
            // 
            this.DeleteAlternativeDay.BackColor = System.Drawing.SystemColors.Control;
            this.DeleteAlternativeDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteAlternativeDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(142)))), ((int)(((byte)(149)))));
            this.DeleteAlternativeDay.Location = new System.Drawing.Point(278, 236);
            this.DeleteAlternativeDay.Name = "DeleteAlternativeDay";
            this.DeleteAlternativeDay.Size = new System.Drawing.Size(183, 44);
            this.DeleteAlternativeDay.TabIndex = 99;
            this.DeleteAlternativeDay.Text = "Datum verwijderen";
            this.DeleteAlternativeDay.UseVisualStyleBackColor = false;
            this.DeleteAlternativeDay.Click += new System.EventHandler(this.DeleteAlternativeDayClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.label3.Location = new System.Drawing.Point(3, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 20);
            this.label3.TabIndex = 98;
            this.label3.Text = "Alternatieve openingstijden:";
            // 
            // MondayClosedCheck
            // 
            this.MondayClosedCheck.AutoSize = true;
            this.MondayClosedCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MondayClosedCheck.Location = new System.Drawing.Point(406, 184);
            this.MondayClosedCheck.Name = "MondayClosedCheck";
            this.MondayClosedCheck.Size = new System.Drawing.Size(164, 24);
            this.MondayClosedCheck.TabIndex = 98;
            this.MondayClosedCheck.Text = "Maandag Gesloten";
            this.MondayClosedCheck.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBox1.Location = new System.Drawing.Point(406, 220);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(164, 24);
            this.checkBox1.TabIndex = 99;
            this.checkBox1.Text = "Maandag Gesloten";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBox2.Location = new System.Drawing.Point(406, 255);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(164, 24);
            this.checkBox2.TabIndex = 100;
            this.checkBox2.Text = "Maandag Gesloten";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // SundayText
            // 
            this.SundayText.AutoSize = true;
            this.SundayText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SundayText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.SundayText.Location = new System.Drawing.Point(3, 241);
            this.SundayText.Name = "SundayText";
            this.SundayText.Size = new System.Drawing.Size(64, 20);
            this.SundayText.TabIndex = 60;
            this.SundayText.Text = "Zondag";
            this.SundayText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SaturdayText
            // 
            this.SaturdayText.AutoSize = true;
            this.SaturdayText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SaturdayText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.SaturdayText.Location = new System.Drawing.Point(3, 205);
            this.SaturdayText.Name = "SaturdayText";
            this.SaturdayText.Size = new System.Drawing.Size(74, 20);
            this.SaturdayText.TabIndex = 59;
            this.SaturdayText.Text = "Zaterdag";
            this.SaturdayText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FridayText
            // 
            this.FridayText.AutoSize = true;
            this.FridayText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FridayText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.FridayText.Location = new System.Drawing.Point(3, 169);
            this.FridayText.Name = "FridayText";
            this.FridayText.Size = new System.Drawing.Size(58, 20);
            this.FridayText.TabIndex = 58;
            this.FridayText.Text = "Vrijdag";
            this.FridayText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ThursdayText
            // 
            this.ThursdayText.AutoSize = true;
            this.ThursdayText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ThursdayText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.ThursdayText.Location = new System.Drawing.Point(3, 133);
            this.ThursdayText.Name = "ThursdayText";
            this.ThursdayText.Size = new System.Drawing.Size(89, 20);
            this.ThursdayText.TabIndex = 57;
            this.ThursdayText.Text = "Donderdag";
            this.ThursdayText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WednesdayText
            // 
            this.WednesdayText.AutoSize = true;
            this.WednesdayText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.WednesdayText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.WednesdayText.Location = new System.Drawing.Point(3, 97);
            this.WednesdayText.Name = "WednesdayText";
            this.WednesdayText.Size = new System.Drawing.Size(86, 20);
            this.WednesdayText.TabIndex = 56;
            this.WednesdayText.Text = "Woensdag";
            this.WednesdayText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TuesdayText
            // 
            this.TuesdayText.AutoSize = true;
            this.TuesdayText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TuesdayText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.TuesdayText.Location = new System.Drawing.Point(3, 61);
            this.TuesdayText.Name = "TuesdayText";
            this.TuesdayText.Size = new System.Drawing.Size(68, 20);
            this.TuesdayText.TabIndex = 55;
            this.TuesdayText.Text = "Dinsdag";
            this.TuesdayText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MondayText
            // 
            this.MondayText.AutoSize = true;
            this.MondayText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MondayText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.MondayText.Location = new System.Drawing.Point(3, 25);
            this.MondayText.Name = "MondayText";
            this.MondayText.Size = new System.Drawing.Size(76, 20);
            this.MondayText.TabIndex = 54;
            this.MondayText.Text = "Maandag";
            this.MondayText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TuesdayDot
            // 
            this.TuesdayDot.AutoSize = true;
            this.TuesdayDot.Location = new System.Drawing.Point(211, 61);
            this.TuesdayDot.Name = "TuesdayDot";
            this.TuesdayDot.Size = new System.Drawing.Size(10, 13);
            this.TuesdayDot.TabIndex = 62;
            this.TuesdayDot.Text = "-";
            // 
            // WednesdayDot
            // 
            this.WednesdayDot.AutoSize = true;
            this.WednesdayDot.Location = new System.Drawing.Point(211, 97);
            this.WednesdayDot.Name = "WednesdayDot";
            this.WednesdayDot.Size = new System.Drawing.Size(10, 13);
            this.WednesdayDot.TabIndex = 63;
            this.WednesdayDot.Text = "-";
            // 
            // MondayDot
            // 
            this.MondayDot.AutoSize = true;
            this.MondayDot.Location = new System.Drawing.Point(211, 25);
            this.MondayDot.Name = "MondayDot";
            this.MondayDot.Size = new System.Drawing.Size(10, 13);
            this.MondayDot.TabIndex = 61;
            this.MondayDot.Text = "-";
            // 
            // FridayDot
            // 
            this.FridayDot.AutoSize = true;
            this.FridayDot.Location = new System.Drawing.Point(211, 169);
            this.FridayDot.Name = "FridayDot";
            this.FridayDot.Size = new System.Drawing.Size(10, 13);
            this.FridayDot.TabIndex = 64;
            this.FridayDot.Text = "-";
            // 
            // RegularTimesText
            // 
            this.RegularTimesText.AutoSize = true;
            this.RegularTimesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RegularTimesText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.RegularTimesText.Location = new System.Drawing.Point(3, 0);
            this.RegularTimesText.Name = "RegularTimesText";
            this.RegularTimesText.Size = new System.Drawing.Size(123, 20);
            this.RegularTimesText.TabIndex = 53;
            this.RegularTimesText.Text = "Openingstijden: ";
            this.RegularTimesText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SaturdayDot
            // 
            this.SaturdayDot.AutoSize = true;
            this.SaturdayDot.Location = new System.Drawing.Point(211, 205);
            this.SaturdayDot.Name = "SaturdayDot";
            this.SaturdayDot.Size = new System.Drawing.Size(10, 13);
            this.SaturdayDot.TabIndex = 65;
            this.SaturdayDot.Text = "-";
            // 
            // ThursdayDot
            // 
            this.ThursdayDot.AutoSize = true;
            this.ThursdayDot.Location = new System.Drawing.Point(211, 133);
            this.ThursdayDot.Name = "ThursdayDot";
            this.ThursdayDot.Size = new System.Drawing.Size(10, 13);
            this.ThursdayDot.TabIndex = 67;
            this.ThursdayDot.Text = "-";
            // 
            // SundayDot
            // 
            this.SundayDot.AutoSize = true;
            this.SundayDot.Location = new System.Drawing.Point(211, 241);
            this.SundayDot.Name = "SundayDot";
            this.SundayDot.Size = new System.Drawing.Size(10, 13);
            this.SundayDot.TabIndex = 66;
            this.SundayDot.Text = "-";
            // 
            // Opentimes
            // 
            this.Opentimes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Opentimes.ColumnCount = 4;
            this.Opentimes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Opentimes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Opentimes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Opentimes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Opentimes.Controls.Add(this.MondayOpenPicker, 1, 1);
            this.Opentimes.Controls.Add(this.SundayDot, 2, 7);
            this.Opentimes.Controls.Add(this.ThursdayDot, 2, 4);
            this.Opentimes.Controls.Add(this.SaturdayDot, 2, 6);
            this.Opentimes.Controls.Add(this.RegularTimesText, 0, 0);
            this.Opentimes.Controls.Add(this.FridayDot, 2, 5);
            this.Opentimes.Controls.Add(this.MondayDot, 2, 1);
            this.Opentimes.Controls.Add(this.WednesdayDot, 2, 3);
            this.Opentimes.Controls.Add(this.TuesdayDot, 2, 2);
            this.Opentimes.Controls.Add(this.MondayText, 0, 1);
            this.Opentimes.Controls.Add(this.TuesdayText, 0, 2);
            this.Opentimes.Controls.Add(this.WednesdayText, 0, 3);
            this.Opentimes.Controls.Add(this.ThursdayText, 0, 4);
            this.Opentimes.Controls.Add(this.FridayText, 0, 5);
            this.Opentimes.Controls.Add(this.SaturdayText, 0, 6);
            this.Opentimes.Controls.Add(this.SundayText, 0, 7);
            this.Opentimes.Controls.Add(this.MondayClosedPicker, 3, 1);
            this.Opentimes.Controls.Add(this.TuesdayOpenPicker, 1, 2);
            this.Opentimes.Controls.Add(this.TuesdayClosedPicker, 3, 2);
            this.Opentimes.Controls.Add(this.WednesdayOpenPicker, 1, 3);
            this.Opentimes.Controls.Add(this.WednesdayClosedPicker, 3, 3);
            this.Opentimes.Controls.Add(this.ThursdayOpenPicker, 1, 4);
            this.Opentimes.Controls.Add(this.ThursdayClosedPicker, 3, 4);
            this.Opentimes.Controls.Add(this.FridayOpenPicker, 1, 5);
            this.Opentimes.Controls.Add(this.FridayClosedPicker, 3, 5);
            this.Opentimes.Controls.Add(this.SaturdayOpenPicker, 1, 6);
            this.Opentimes.Controls.Add(this.SaturdayClosedPicker, 3, 6);
            this.Opentimes.Controls.Add(this.SundayOpenPicker, 1, 7);
            this.Opentimes.Controls.Add(this.SundayClosedPicker, 3, 7);
            this.Opentimes.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.Opentimes.Location = new System.Drawing.Point(12, 157);
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
            this.Opentimes.Size = new System.Drawing.Size(307, 281);
            this.Opentimes.TabIndex = 83;
            // 
            // MondayOpenPicker
            // 
            this.MondayOpenPicker.CustomFormat = "HH:mm";
            this.MondayOpenPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.MondayOpenPicker.Location = new System.Drawing.Point(132, 28);
            this.MondayOpenPicker.Name = "MondayOpenPicker";
            this.MondayOpenPicker.ShowUpDown = true;
            this.MondayOpenPicker.Size = new System.Drawing.Size(73, 20);
            this.MondayOpenPicker.TabIndex = 101;
            // 
            // MondayClosedPicker
            // 
            this.MondayClosedPicker.CustomFormat = "HH:mm";
            this.MondayClosedPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.MondayClosedPicker.Location = new System.Drawing.Point(227, 28);
            this.MondayClosedPicker.Name = "MondayClosedPicker";
            this.MondayClosedPicker.ShowUpDown = true;
            this.MondayClosedPicker.Size = new System.Drawing.Size(73, 20);
            this.MondayClosedPicker.TabIndex = 102;
            // 
            // TuesdayOpenPicker
            // 
            this.TuesdayOpenPicker.CustomFormat = "HH:mm";
            this.TuesdayOpenPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TuesdayOpenPicker.Location = new System.Drawing.Point(132, 64);
            this.TuesdayOpenPicker.Name = "TuesdayOpenPicker";
            this.TuesdayOpenPicker.ShowUpDown = true;
            this.TuesdayOpenPicker.Size = new System.Drawing.Size(73, 20);
            this.TuesdayOpenPicker.TabIndex = 103;
            // 
            // TuesdayClosedPicker
            // 
            this.TuesdayClosedPicker.CustomFormat = "HH:mm";
            this.TuesdayClosedPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TuesdayClosedPicker.Location = new System.Drawing.Point(227, 64);
            this.TuesdayClosedPicker.Name = "TuesdayClosedPicker";
            this.TuesdayClosedPicker.ShowUpDown = true;
            this.TuesdayClosedPicker.Size = new System.Drawing.Size(73, 20);
            this.TuesdayClosedPicker.TabIndex = 104;
            // 
            // WednesdayOpenPicker
            // 
            this.WednesdayOpenPicker.CustomFormat = "HH:mm";
            this.WednesdayOpenPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.WednesdayOpenPicker.Location = new System.Drawing.Point(132, 100);
            this.WednesdayOpenPicker.Name = "WednesdayOpenPicker";
            this.WednesdayOpenPicker.ShowUpDown = true;
            this.WednesdayOpenPicker.Size = new System.Drawing.Size(73, 20);
            this.WednesdayOpenPicker.TabIndex = 105;
            // 
            // WednesdayClosedPicker
            // 
            this.WednesdayClosedPicker.CustomFormat = "HH:mm";
            this.WednesdayClosedPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.WednesdayClosedPicker.Location = new System.Drawing.Point(227, 100);
            this.WednesdayClosedPicker.Name = "WednesdayClosedPicker";
            this.WednesdayClosedPicker.ShowUpDown = true;
            this.WednesdayClosedPicker.Size = new System.Drawing.Size(73, 20);
            this.WednesdayClosedPicker.TabIndex = 106;
            // 
            // ThursdayOpenPicker
            // 
            this.ThursdayOpenPicker.CustomFormat = "HH:mm";
            this.ThursdayOpenPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ThursdayOpenPicker.Location = new System.Drawing.Point(132, 136);
            this.ThursdayOpenPicker.Name = "ThursdayOpenPicker";
            this.ThursdayOpenPicker.ShowUpDown = true;
            this.ThursdayOpenPicker.Size = new System.Drawing.Size(73, 20);
            this.ThursdayOpenPicker.TabIndex = 107;
            // 
            // ThursdayClosedPicker
            // 
            this.ThursdayClosedPicker.CustomFormat = "HH:mm";
            this.ThursdayClosedPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ThursdayClosedPicker.Location = new System.Drawing.Point(227, 136);
            this.ThursdayClosedPicker.Name = "ThursdayClosedPicker";
            this.ThursdayClosedPicker.ShowUpDown = true;
            this.ThursdayClosedPicker.Size = new System.Drawing.Size(73, 20);
            this.ThursdayClosedPicker.TabIndex = 108;
            // 
            // FridayOpenPicker
            // 
            this.FridayOpenPicker.CustomFormat = "HH:mm";
            this.FridayOpenPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FridayOpenPicker.Location = new System.Drawing.Point(132, 172);
            this.FridayOpenPicker.Name = "FridayOpenPicker";
            this.FridayOpenPicker.ShowUpDown = true;
            this.FridayOpenPicker.Size = new System.Drawing.Size(73, 20);
            this.FridayOpenPicker.TabIndex = 109;
            // 
            // FridayClosedPicker
            // 
            this.FridayClosedPicker.CustomFormat = "HH:mm";
            this.FridayClosedPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FridayClosedPicker.Location = new System.Drawing.Point(227, 172);
            this.FridayClosedPicker.Name = "FridayClosedPicker";
            this.FridayClosedPicker.ShowUpDown = true;
            this.FridayClosedPicker.Size = new System.Drawing.Size(73, 20);
            this.FridayClosedPicker.TabIndex = 110;
            // 
            // SaturdayOpenPicker
            // 
            this.SaturdayOpenPicker.CustomFormat = "HH:mm";
            this.SaturdayOpenPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SaturdayOpenPicker.Location = new System.Drawing.Point(132, 208);
            this.SaturdayOpenPicker.Name = "SaturdayOpenPicker";
            this.SaturdayOpenPicker.ShowUpDown = true;
            this.SaturdayOpenPicker.Size = new System.Drawing.Size(73, 20);
            this.SaturdayOpenPicker.TabIndex = 111;
            // 
            // SaturdayClosedPicker
            // 
            this.SaturdayClosedPicker.CustomFormat = "HH:mm";
            this.SaturdayClosedPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SaturdayClosedPicker.Location = new System.Drawing.Point(227, 208);
            this.SaturdayClosedPicker.Name = "SaturdayClosedPicker";
            this.SaturdayClosedPicker.ShowUpDown = true;
            this.SaturdayClosedPicker.Size = new System.Drawing.Size(73, 20);
            this.SaturdayClosedPicker.TabIndex = 112;
            // 
            // SundayOpenPicker
            // 
            this.SundayOpenPicker.CustomFormat = "HH:mm";
            this.SundayOpenPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SundayOpenPicker.Location = new System.Drawing.Point(132, 244);
            this.SundayOpenPicker.Name = "SundayOpenPicker";
            this.SundayOpenPicker.ShowUpDown = true;
            this.SundayOpenPicker.Size = new System.Drawing.Size(73, 20);
            this.SundayOpenPicker.TabIndex = 113;
            // 
            // SundayClosedPicker
            // 
            this.SundayClosedPicker.CustomFormat = "HH:mm";
            this.SundayClosedPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SundayClosedPicker.Location = new System.Drawing.Point(227, 244);
            this.SundayClosedPicker.Name = "SundayClosedPicker";
            this.SundayClosedPicker.ShowUpDown = true;
            this.SundayClosedPicker.Size = new System.Drawing.Size(73, 20);
            this.SundayClosedPicker.TabIndex = 114;
            // 
            // AlternativeDayOpenPicker
            // 
            this.AlternativeDayOpenPicker.CustomFormat = "HH:mm";
            this.AlternativeDayOpenPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AlternativeDayOpenPicker.Location = new System.Drawing.Point(278, 99);
            this.AlternativeDayOpenPicker.Name = "AlternativeDayOpenPicker";
            this.AlternativeDayOpenPicker.ShowUpDown = true;
            this.AlternativeDayOpenPicker.Size = new System.Drawing.Size(73, 20);
            this.AlternativeDayOpenPicker.TabIndex = 115;
            this.AlternativeDayOpenPicker.Value = new System.DateTime(2020, 4, 20, 0, 0, 0, 0);
            // 
            // AlternativeDayClosedPicker
            // 
            this.AlternativeDayClosedPicker.CustomFormat = "HH:mm";
            this.AlternativeDayClosedPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AlternativeDayClosedPicker.Location = new System.Drawing.Point(388, 99);
            this.AlternativeDayClosedPicker.Name = "AlternativeDayClosedPicker";
            this.AlternativeDayClosedPicker.ShowUpDown = true;
            this.AlternativeDayClosedPicker.Size = new System.Drawing.Size(73, 20);
            this.AlternativeDayClosedPicker.TabIndex = 116;
            this.AlternativeDayClosedPicker.Value = new System.DateTime(2020, 4, 20, 0, 0, 0, 0);
            // 
            // SettingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1067, 828);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.MondayClosedCheck);
            this.Controls.Add(this.PanelAlternativeDay);
            this.Controls.Add(this.Opentimes);
            this.Controls.Add(this.Pincode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SettingsPage";
            this.Text = "Settings";
            this.Leave += new System.EventHandler(this.PageLeave);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.PanelAlternativeDay.ResumeLayout(false);
            this.PanelAlternativeDay.PerformLayout();
            this.Opentimes.ResumeLayout(false);
            this.Opentimes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Pincode;
        private System.Windows.Forms.TextBox PincodeInput;
        private System.Windows.Forms.Label PincodeText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox ListOfAlternativeDays;
        private System.Windows.Forms.Button ChangePincodeButton;
        private System.Windows.Forms.Button AddAlternativeDay;
        private System.Windows.Forms.DateTimePicker DatePlanner;
        private System.Windows.Forms.Label OpenAlternative;
        private System.Windows.Forms.Label ClosedAlternative;
        private System.Windows.Forms.Panel PanelAlternativeDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DeleteAlternativeDay;
        private System.Windows.Forms.CheckBox MondayClosedCheck;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label SundayText;
        private System.Windows.Forms.Label SaturdayText;
        private System.Windows.Forms.Label FridayText;
        private System.Windows.Forms.Label ThursdayText;
        private System.Windows.Forms.Label WednesdayText;
        private System.Windows.Forms.Label TuesdayText;
        private System.Windows.Forms.Label MondayText;
        private System.Windows.Forms.Label TuesdayDot;
        private System.Windows.Forms.Label WednesdayDot;
        private System.Windows.Forms.Label MondayDot;
        private System.Windows.Forms.Label FridayDot;
        private System.Windows.Forms.Label RegularTimesText;
        private System.Windows.Forms.Label SaturdayDot;
        private System.Windows.Forms.Label ThursdayDot;
        private System.Windows.Forms.Label SundayDot;
        private System.Windows.Forms.TableLayoutPanel Opentimes;
        private System.Windows.Forms.DateTimePicker MondayOpenPicker;
        private System.Windows.Forms.DateTimePicker MondayClosedPicker;
        private System.Windows.Forms.DateTimePicker TuesdayOpenPicker;
        private System.Windows.Forms.DateTimePicker TuesdayClosedPicker;
        private System.Windows.Forms.DateTimePicker WednesdayOpenPicker;
        private System.Windows.Forms.DateTimePicker WednesdayClosedPicker;
        private System.Windows.Forms.DateTimePicker ThursdayOpenPicker;
        private System.Windows.Forms.DateTimePicker ThursdayClosedPicker;
        private System.Windows.Forms.DateTimePicker FridayOpenPicker;
        private System.Windows.Forms.DateTimePicker FridayClosedPicker;
        private System.Windows.Forms.DateTimePicker SaturdayOpenPicker;
        private System.Windows.Forms.DateTimePicker SaturdayClosedPicker;
        private System.Windows.Forms.DateTimePicker SundayOpenPicker;
        private System.Windows.Forms.DateTimePicker SundayClosedPicker;
        private System.Windows.Forms.DateTimePicker AlternativeDayClosedPicker;
        private System.Windows.Forms.DateTimePicker AlternativeDayOpenPicker;
    }
}