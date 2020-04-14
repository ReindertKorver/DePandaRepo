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
            LoadWeekDays();

            if (previousWinstate == FormWindowState.Maximized)
            {
                PanelALTDay.Location = new Point(500, 157);
            }
            else if (previousWinstate == FormWindowState.Normal)
            {
                PanelALTDay.Location = new Point(12, 466);
            }
        }

        private List<int> data;
        private void SplitStrings(string OpenTime, string ClosedTime)
        {
            string[] OpenTimeList = OpenTime.Split(':');
            int HourOpen = int.Parse(OpenTimeList[0]);
            int MinuteOpen = int.Parse(OpenTimeList[1]);

            string[] ClosedTimeList = ClosedTime.Split(':');
            int HourClosed = int.Parse(OpenTimeList[0]);
            int MinuteClosed = int.Parse(ClosedTimeList[1]);
            data = new List<int> { HourOpen, MinuteOpen, HourClosed, MinuteClosed };
        }

        private void LoadWeekDays()
        {
            var WeekList = DataStorageHandler.Storage.Settings.WeekDays;
            MondayOpen.Text = WeekList[0].OpenTime;
            MondayClosed.Text = WeekList[0].CloseTime;

            TuesDayOpen.Text = WeekList[1].OpenTime;
            TuesDayClosed.Text = WeekList[1].CloseTime;

            WednesDayOpen.Text = WeekList[2].OpenTime;
            WednesDayClosed.Text = WeekList[2].CloseTime;

            ThursDayOpen.Text = WeekList[3].OpenTime;
            ThursDayClosed.Text = WeekList[3].CloseTime;

            FridayOpen.Text = WeekList[4].OpenTime;
            FridayClosed.Text = WeekList[4].CloseTime;

            SaturDayOpen.Text = WeekList[5].OpenTime;
            SaturDayClosed.Text = WeekList[5].CloseTime;

            SunDayOpen.Text = WeekList[6].OpenTime;
            SunDayClosed.Text = WeekList[6].CloseTime;
        }

        private bool ValidString(string OpenTime, string ClosedTime)
        {

            string[] OpenTimeList = OpenTime.Split(':');
            string[] ClosedTimeList = ClosedTime.Split(':');
            if (OpenTimeList[0].All(Char.IsDigit) && OpenTimeList[1].All(Char.IsDigit) && ClosedTimeList[0].All(Char.IsDigit) && ClosedTimeList[1].All(Char.IsDigit))
            {
                int HourOpen = int.Parse(OpenTimeList[0]);
                int MinuteOpen = int.Parse(OpenTimeList[1]);

                
                int HourClosed = int.Parse(OpenTimeList[0]);
                int MinuteClosed = int.Parse(ClosedTimeList[1]);
                data = new List<int> { HourOpen, MinuteOpen, HourClosed, MinuteClosed };
                bool allPositive = data.All(x => x > 0);
                if ((HourOpen > 24 | HourClosed > 24 | MinuteOpen > 60 | MinuteClosed > 60) && allPositive)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        private void AddALTDayFunc()
        {
            int year = DatumPrikker.Value.Year;
            int day = DatumPrikker.Value.Day;
            int month = DatumPrikker.Value.Month;
            ValidString(OpenALTINP.Text, ClosedALTINP.Text);
            SplitStrings(OpenALTINP.Text, ClosedALTINP.Text);
            var opentijd = new DateTime(year, month, day, data[0], data[1], 0);
            var geslotenTijd = new DateTime(year, month, day, data[2], data[3], 0);
            var newAltDate = new DePandaClassLib.Entities.AlternativeDate(opentijd,geslotenTijd);
            DataStorageHandler.Storage.Settings.AlternativeDates.Add(newAltDate);
            MessageBox.Show("Datum succesvol toegevoed");
            LoadALTDays();
        }


        private void AddAltDay_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0 | listBox1.SelectedItem == null)
            {
                if (!ValidString(OpenALTINP.Text, ClosedALTINP.Text))
                {
                    AddALTDayFunc();
                }
                else
                {
                    MessageBox.Show("U heeft geen correcte tijden ingevuld");
                }

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
                            LoadALTDays();
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
            listBox1.Items.Clear();
            listBox1.Items.Add($"     Datum     Geopend     Gesloten");
            foreach (DePandaClassLib.Entities.AlternativeDate date in days)
            {
                listBox1.Items.Add($"{date.DateString}     {date.StartTimeString}           {date.EndTimeString}");
            }
            if (WeekDayList.Count > 7)
            {
                WeekDayList.RemoveRange(7, (WeekDayList.Count() - 7));
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

        List<DePandaClassLib.Entities.WeekDay> WeekDayList = DataStorageHandler.Storage.Settings.WeekDays;
        private void DaysSave(object sender, EventArgs e)
        {
            //var maandag = new DePandaClassLib.Entities.WeekDay(MondayOpen.Text, MondayClosed.Text);
            //WeekDayList[0] = maandag;

            //var dinsdag = new DePandaClassLib.Entities.WeekDay(TuesDayOpen.Text, TuesDayClosed.Text);
            //WeekDayList.RemoveAt(1);
            //WeekDayList.Insert(1, dinsdag);

            //var woensdag = new DePandaClassLib.Entities.WeekDay(WednesDayOpen.Text, WednesDayClosed.Text);
            //WeekDayList.RemoveAt(2);
            //WeekDayList.Insert(2, woensdag);

            //var donderdag = new DePandaClassLib.Entities.WeekDay(ThursDayOpen.Text, ThursDayClosed.Text);
            //WeekDayList.RemoveAt(3);
            //WeekDayList.Insert(3, donderdag);

            //var vrijdag = new DePandaClassLib.Entities.WeekDay(FridayOpen.Text, FridayClosed.Text);
            //WeekDayList.RemoveAt(4);
            //WeekDayList.Insert(4, vrijdag);

            //var zaterdag = new DePandaClassLib.Entities.WeekDay(SaturDayOpen.Text, SaturDayClosed.Text);
            //WeekDayList.RemoveAt(5);
            //WeekDayList.Insert(5, zaterdag);

            //var zondag = new DePandaClassLib.Entities.WeekDay(SunDayOpen.Text, SunDayClosed.Text);
            //WeekDayList.RemoveAt(6);
            //WeekDayList.Insert(6, zondag);
            //LoadWeekDays();
        }     
    }
}
