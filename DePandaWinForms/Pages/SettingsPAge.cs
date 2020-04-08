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
            LoadInMenuItems();
        }

        private void AddALTDayFunc()
        {
            Int32 year = DatumPrikker.Value.Year;
            Int32 day = DatumPrikker.Value.Day;
            Int32 month = DatumPrikker.Value.Month;

            string OpenTime = OpenALTINP.Text;
            string ClosedTime = ClosedALTINP.Text;

            string[] OpenTimeList = OpenTime.Split(':');
            int HourOpen = Int32.Parse(OpenTimeList[0]);
            int MinuteOpen = Int32.Parse(OpenTimeList[1]);


            string[] ClosedTimeList = ClosedTime.Split(':');
            int HourClosed = Int32.Parse(OpenTimeList[0]);
            int MinuteClosed = Int32.Parse(ClosedTimeList[1]);

            var newAltDate = new DePandaClassLib.Entities.AlternativeDate(new DateTime(year, day, month, HourOpen, MinuteOpen, 0), new DateTime(year, day, month, HourClosed, MinuteClosed, 0));
            DataStorageHandler.Storage.Settings.AlternativeDates.Add(newAltDate);
            MessageBox.Show("Datum succesvol toegevoed");
        }
        private void AddAltDay_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0 | listBox1.SelectedItem == null)
            {
                AddALTDayFunc();
            }
            else
            {
                try
                {
                    {
                        foreach (DePandaClassLib.Entities.AlternativeDate date in Dates)
                        {
                            if (listBox1.SelectedItem.ToString().Contains(date.DateString))
                            {
                                DelALTDayFunc(date);
                                break;
                            }

                        }
                    }
                }
                finally { }
            }
        }
        private void DelALTDayFunc(DePandaClassLib.Entities.AlternativeDate date )
        {
        DataStorageHandler.Storage.Settings.AlternativeDates.Remove(date);
        MessageBox.Show("Datum succesvol verwijdert");           
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private  List<DePandaClassLib.Entities.AlternativeDate> Dates = DataStorageHandler.Storage.Settings.AlternativeDates;
        public void LoadInMenuItems()
        {
            
            listBox1.Items.Add($"     Datum     Geopend     Gesloten");
            foreach (DePandaClassLib.Entities.AlternativeDate date in Dates)
            {
                listBox1.Items.Add($"{date.DateString}     {date.StartTimeString}           {date.EndTimeString}");
            }
        }
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0 | listBox1.SelectedItem == null)
            {

                AddAltDay.Text = "Datum toevoegen";
            }
            else
            {
                AddAltDay.Text = "Datum verwijderen";
            }
                

        }

        private void button1_Click(object sender, EventArgs e)
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
