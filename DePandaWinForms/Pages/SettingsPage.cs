using DePandaLib.DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

using System.Windows.Forms;

namespace DePandaWinForms.Pages
{
    public partial class SettingsPage : Form
    {
        public SettingsPage(FormWindowState previousWinstate)
        {
            InitializeComponent();
            LoadAlternativeDays();
            
            if (WeekDayList.Count != 7)
            {
                WeekDayList.Clear();
                for (int i = 0; i < 7; i++)
                {
                    WeekDayList.Add(new DePandaClassLib.Entities.WeekDay(new DateTime(2020, 04, 07, 11, 0, 0), new DateTime(2020, 04, 07, 11, 0, 0)));
                }
            }
            ChangeCheckedState();
            if (previousWinstate == FormWindowState.Maximized)
            {
                PanelAlternativeDay.Location = new Point(525, 82);
            }
            else if (previousWinstate == FormWindowState.Normal)
            {
                PanelAlternativeDay.Location = new Point(12, 466);
            }

        }
        List<DePandaClassLib.Entities.WeekDay> WeekDayList = DataStorageHandler.Storage.Settings.WeekDays;
        private void LoadWeekDays()
        {
            MondayOpenPicker.Text = WeekDayList[0].OpenTime.ToString("HH:mm");
            MondayClosedPicker.Text = WeekDayList[0].CloseTime.ToString("HH:mm");

            TuesdayOpenPicker.Text = WeekDayList[1].OpenTime.ToString("HH:mm");
            TuesdayClosedPicker.Text = WeekDayList[1].CloseTime.ToString("HH:mm");

            WednesdayOpenPicker.Text = WeekDayList[2].OpenTime.ToString("HH:mm");
            WednesdayClosedPicker.Text = WeekDayList[2].CloseTime.ToString("HH:mm");

            ThursdayOpenPicker.Text = WeekDayList[3].OpenTime.ToString("HH:mm");
            ThursdayClosedPicker.Text = WeekDayList[3].CloseTime.ToString("HH:mm");

            FridayOpenPicker.Text = WeekDayList[4].OpenTime.ToString("HH:mm");
            FridayClosedPicker.Text = WeekDayList[4].CloseTime.ToString("HH:mm");

            SaturdayOpenPicker.Text = WeekDayList[5].OpenTime.ToString("HH:mm");
            SaturdayClosedPicker.Text = WeekDayList[5].CloseTime.ToString("HH:mm");

            SundayOpenPicker.Text = WeekDayList[6].OpenTime.ToString("HH:mm");
            SundayClosedPicker.Text = WeekDayList[6].CloseTime.ToString("HH:mm");
        }

       
        private void AddAlternativeDay_Click(object sender, EventArgs e)
        {
            int year = DatePlanner.Value.Year;
            int day = DatePlanner.Value.Day;
            int month = DatePlanner.Value.Month;
            int hourOpen = AlternativeDayOpenPicker.Value.Hour;
            int MinuteOpen = AlternativeDayOpenPicker.Value.Minute;
            int hourClosed = AlternativeDayClosedPicker.Value.Hour;
            int MinuteClosed = AlternativeDayClosedPicker.Value.Minute;
            var opentijd = new DateTime(year, month, day, hourOpen, MinuteOpen, 0);
            var geslotenTijd = new DateTime(year, month, day, hourClosed, MinuteClosed, 0);
            var newAlternativeDate = new DePandaClassLib.Entities.AlternativeDate(opentijd, geslotenTijd);
            DataStorageHandler.Storage.Settings.AlternativeDates.Add(newAlternativeDate);
            LoadAlternativeDays();
        }

        private List<DePandaClassLib.Entities.AlternativeDate> ListOfAlternativeDates = DataStorageHandler.Storage.Settings.AlternativeDates;
        public void LoadAlternativeDays()
        {
            ListOfAlternativeDays.Items.Clear();
            ListOfAlternativeDays.Items.Add($"     Datum     Geopend     Gesloten");
            foreach (DePandaClassLib.Entities.AlternativeDate date in ListOfAlternativeDates)
            {
                ListOfAlternativeDays.Items.Add($"{date.DateString}     {date.StartTimeString}           {date.EndTimeString}");
            }
            if (WeekDayList.Count > 7)
            {
                WeekDayList.RemoveRange(7, (WeekDayList.Count() - 7));
            }
        }

        private void SaveRegularDays()
        {
            
            var maandag = new DePandaClassLib.Entities.WeekDay(MondayOpenPicker.Value, MondayClosedPicker.Value);
            WeekDayList.RemoveAt(0);
            WeekDayList.Insert(0, maandag);

            var dinsdag = new DePandaClassLib.Entities.WeekDay(TuesdayOpenPicker.Value, TuesdayClosedPicker.Value);
            WeekDayList.RemoveAt(1);
            WeekDayList.Insert(1, dinsdag);

            var woensdag = new DePandaClassLib.Entities.WeekDay(WednesdayOpenPicker.Value, WednesdayClosedPicker.Value);
            WeekDayList.RemoveAt(2);
            WeekDayList.Insert(2, woensdag);

            var donderdag = new DePandaClassLib.Entities.WeekDay(ThursdayOpenPicker.Value, ThursdayClosedPicker.Value);
            WeekDayList.RemoveAt(3);
            WeekDayList.Insert(3, donderdag);

            var vrijdag = new DePandaClassLib.Entities.WeekDay(FridayOpenPicker.Value, FridayClosedPicker.Value);
            WeekDayList.RemoveAt(4);
            WeekDayList.Insert(4, vrijdag);

            var zaterdag = new DePandaClassLib.Entities.WeekDay(SaturdayOpenPicker.Value, SaturdayClosedPicker.Value);
            WeekDayList.RemoveAt(5);
            WeekDayList.Insert(5, zaterdag);

            var zondag = new DePandaClassLib.Entities.WeekDay(SundayOpenPicker.Value, SundayClosedPicker.Value);
            WeekDayList.RemoveAt(6);
            WeekDayList.Insert(6, zondag);
            LoadWeekDays();
        }

        private void DeleteAlternativeDayClick(object sender, EventArgs e)
        {
            foreach (DePandaClassLib.Entities.AlternativeDate date in ListOfAlternativeDates)
            {
                if (ListOfAlternativeDays.SelectedItem.ToString().Contains(date.DateString))
                {
                    DataStorageHandler.Storage.Settings.AlternativeDates.Remove(date);
                    LoadAlternativeDays();
                    break;
                }
            }
        }

        private void ChangePincodeClick(object sender, EventArgs e)
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

        private void PageLeave(object sender, EventArgs e)
        {
            SaveRegularDays();
        }

        private void CheckBox(object sender, EventArgs e)
        {
            string day = ((sender as CheckBox).Name).ToString().Replace("ClosedCheck", "");

            if ((sender as CheckBox).Checked == true)
            { 
                int i = 0;
                if (day == "Monday")
                    i = 0;
                if (day == "Tuesday")
                    i = 1;
                if (day == "Wednesday")
                    i = 2;
                if (day == "Thursday")
                    i = 3;
                if (day == "Friday")
                    i = 4;
                if (day == "Saturday")
                    i = 5;
                if (day == "Sunday")
                    i = 6;

                var ClosedDay = new DePandaClassLib.Entities.WeekDay(new DateTime(2020, 04, 07, 0, 0, 0), new DateTime(2020, 05, 07, 0, 0, 0));
                WeekDayList.RemoveAt(i);
                WeekDayList.Insert(i, ClosedDay);
                LoadWeekDays();
            }

        }

        private void TimeChanged(object sender, KeyEventArgs e)
        {
            SaveRegularDays();
            ChangeCheckedState();
        }
        private void ChangeCheckedState()
        {
            for (int i = 0; i < WeekDayList.Count(); i++)
            {
                if (WeekDayList[i].OpenTime.Hour.Equals(WeekDayList[i].CloseTime.Hour) && WeekDayList[i].OpenTime.Minute.Equals(WeekDayList[i].CloseTime.Minute))
                {
                    if (i == 0)
                    {
                        MondayClosedCheck.Checked = true;
                    }
                    else if (i == 1)
                    {
                        TuesdayClosedCheck.Checked = true;
                    }
                    else if (i == 2)
                    {
                        WednesdayClosedCheck.Checked = true;
                    }
                    else if (i == 3)
                    {
                        ThursdayClosedCheck.Checked = true;
                    }
                    else if (i == 4)
                    {
                        FridayClosedCheck.Checked = true;
                    }
                    else if (i == 5)
                    {
                        SaturdayClosedCheck.Checked = true;
                    }
                    else if (i == 6)
                    {
                        SundayClosedCheck.Checked = true;
                    }
                }
                else
                {
                    if (i == 0)
                    {
                        MondayClosedCheck.Checked = false;
                    }
                    else if (i == 1)
                    {
                        TuesdayClosedCheck.Checked = false;
                    }
                    else if (i == 2)
                    {
                        WednesdayClosedCheck.Checked = false;
                    }
                    else if (i == 3)
                    {
                        ThursdayClosedCheck.Checked = false;
                    }
                    else if (i == 4)
                    {
                        FridayClosedCheck.Checked = false;
                    }
                    else if (i == 5)
                    {
                        SaturdayClosedCheck.Checked = false;
                    }
                    else if (i == 6)
                    {
                        SundayClosedCheck.Checked = false;
                    }
                }
            }
            LoadWeekDays();
        }
    }
}
