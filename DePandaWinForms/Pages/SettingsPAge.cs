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
        public SettingsPage(FormWindowState previousWinstate)
        {
            InitializeComponent();
            LoadALTDays();
            MondayOpen.Text = WeekDayList[0].OpenTime;
            MondayClosed.Text = WeekDayList[0].CloseTime;

            TuesDayOpen.Text = WeekDayList[1].OpenTime;
            TuesDayClosed.Text = WeekDayList[1].CloseTime;

            WednesDayOpen.Text = WeekDayList[2].OpenTime;
            WednesDayClosed.Text = WeekDayList[2].CloseTime;

            ThursDayOpen.Text = WeekDayList[3].OpenTime;
            ThursDayClosed.Text = WeekDayList[3].CloseTime;

            FridayOpen.Text = WeekDayList[4].OpenTime;
            FridayClosed.Text = WeekDayList[4].CloseTime;

            SaturDayOpen.Text = WeekDayList[5].OpenTime;
            SaturDayClosed.Text = WeekDayList[5].CloseTime;

            SunDayOpen.Text = WeekDayList[6].OpenTime;
            SunDayClosed.Text = WeekDayList[6].CloseTime;


            if (previousWinstate == FormWindowState.Maximized)
            {
                PanelALTDay.Location = new Point(500, 157);
            }
            else if (previousWinstate == FormWindowState.Normal)
            {
                PanelALTDay.Location = new Point(12, 466);
            }
        }

        private Int32[] data;
        private void SplitStrings(string OpenTime, string ClosedTime)
        {
            string[] OpenTimeList = OpenTime.Split(':');
            int HourOpen = Int32.Parse(OpenTimeList[0]);
            int MinuteOpen = Int32.Parse(OpenTimeList[1]);

            string[] ClosedTimeList = ClosedTime.Split(':');
            int HourClosed = Int32.Parse(OpenTimeList[0]);
            int MinuteClosed = Int32.Parse(ClosedTimeList[1]);
            List<Int32> data = new List<Int32> { HourOpen, MinuteOpen, HourClosed, MinuteClosed };
        }

        private bool ValidString(string OpenTime, string ClosedTime)
        {
            string[] OpenTimeList = OpenTime.Split(':');
            int HourOpen = Int32.Parse(OpenTimeList[0]);
            int MinuteOpen = Int32.Parse(OpenTimeList[1]);

            string[] ClosedTimeList = ClosedTime.Split(':');
            int HourClosed = Int32.Parse(OpenTimeList[0]);
            int MinuteClosed = Int32.Parse(ClosedTimeList[1]);
            List<Int32> data = new List<Int32> { HourOpen, MinuteOpen, HourClosed, MinuteClosed };
            bool allPositive = data.All(x => x > 0);
            if ((HourOpen > 24 | HourClosed> 24 | MinuteOpen > 60 | MinuteClosed > 60) && allPositive)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void AddALTDayFunc()
        {
            Int32 year = DatumPrikker.Value.Year;
            Int32 day = DatumPrikker.Value.Day;
            Int32 month = DatumPrikker.Value.Month;
            SplitStrings(OpenALTINP.Text, ClosedALTINP.Text);
            var newAltDate = new DePandaClassLib.Entities.AlternativeDate(new DateTime(year, day, month, data[0], data[1], 0), new DateTime(year, day, month, data[2], data[3], 0));
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

                    foreach (DePandaClassLib.Entities.AlternativeDate date in days)
                    {
                        if (listBox1.SelectedItem.ToString().Contains(date.DateString))
                        {
                            DataStorageHandler.Storage.Settings.AlternativeDates.Remove(date);
                            MessageBox.Show("Datum succesvol verwijdert");
                            break;
                        }
                    }
                }
                finally { }
            }
        }

        private List<DePandaClassLib.Entities.AlternativeDate> days = DataStorageHandler.Storage.Settings.AlternativeDates;
        public void LoadALTDays()
        {

            listBox1.Items.Add($"     Datum     Geopend     Gesloten");
            foreach (DePandaClassLib.Entities.AlternativeDate date in days)
            {
                listBox1.Items.Add($"{date.DateString}     {date.StartTimeString}           {date.EndTimeString}");
            }
            if (WeekDayList.Count > 7)
            {
                WeekDayList.RemoveRange(7, (WeekDayList.Count() - 7));
            }
            MessageBox.Show(WeekDayList.Count().ToString());
            if (WeekDayList.Count() == 0)
            {
                for (int i = 0; i < 7; i++)
                {
                    WeekDayList.Add(new DePandaClassLib.Entities.Time("", ""));


                    MessageBox.Show("lijst aangemaakt");
                }
                MessageBox.Show(WeekDayList.Count().ToString());
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

        List<DePandaClassLib.Entities.Time> WeekDayList = DataStorageHandler.Storage.Settings.Weekdays;
        private void DaysSave(object sender, EventArgs e)
        {
            var maandag = new DePandaClassLib.Entities.Time(MondayOpen.Text, MondayClosed.Text);
            WeekDayList.RemoveAt(0);
            WeekDayList.Insert(0, maandag);

            var dinsdag = new DePandaClassLib.Entities.Time(TuesDayOpen.Text, TuesDayClosed.Text);
            WeekDayList.RemoveAt(1);
            WeekDayList.Insert(1, dinsdag);

            var woensdag = new DePandaClassLib.Entities.Time(WednesDayOpen.Text, WednesDayClosed.Text);
            WeekDayList.RemoveAt(2);
            WeekDayList.Insert(2, woensdag);

            var donderdag = new DePandaClassLib.Entities.Time(ThursDayOpen.Text, ThursDayClosed.Text);
            WeekDayList.RemoveAt(3);
            WeekDayList.Insert(3, donderdag);

            var vrijdag = new DePandaClassLib.Entities.Time(FridayOpen.Text, FridayClosed.Text);
            WeekDayList.RemoveAt(4);
            WeekDayList.Insert(4, vrijdag);

            var zaterdag = new DePandaClassLib.Entities.Time(SaturDayOpen.Text, SaturDayClosed.Text);
            WeekDayList.RemoveAt(5);
            WeekDayList.Insert(5, zaterdag);

            var zondag = new DePandaClassLib.Entities.Time(SunDayOpen.Text, SunDayClosed.Text);
            WeekDayList.RemoveAt(6);
            WeekDayList.Insert(6, zondag);
            MessageBox.Show("gelukt");
        }

        private void DayINP_leave(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == "")
            {
                (sender as TextBox).Text = "xx:xx";
                (sender as TextBox).ForeColor = Color.Silver;
            }
        }

        private void DayINP_Enter(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text != "")
            {
                (sender as TextBox).Text = "";
                (sender as TextBox).ForeColor = Color.Black;
            }
        }
    }
}





