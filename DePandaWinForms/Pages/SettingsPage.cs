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
            // checks if a week has 7 days 
            if (WeekDayList.Count != 7)
            {
                MessageBox.Show("Er is iets fout gegaan tijdens het ophalen van de dagen.");
                WeekDayList.Clear();
                for (int i = 0; i < 7; i++)
                {
                    WeekDayList.Add(new DePandaClassLib.Entities.WeekDay(new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 9, 0, 0), new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 19, 0, 0)));
                }
            }

            // checkt in welke modus het scherm is 
            if (previousWinstate == FormWindowState.Maximized)
            {
                PanelAlternativeDay.Location = new Point(525, 82);
            }
            else
            {
                PanelAlternativeDay.Location = new Point(12, 466);
            }
            LoadWeekDays();
        }
        List<DePandaClassLib.Entities.WeekDay> WeekDayList = DataStorageHandler.Storage.Settings.WeekDays;
        private void LoadWeekDays()
        {
            // sets the dislay to the most up to date values
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
            // saves a new alternative day when pressed on the button
            int Year = DatePlanner.Value.Year;
            int Day = DatePlanner.Value.Day;
            int Month = DatePlanner.Value.Month;
            int HourOpen = AlternativeDayOpenPicker.Value.Hour;
            int MinuteOpen = AlternativeDayOpenPicker.Value.Minute;
            int HourClosed = AlternativeDayClosedPicker.Value.Hour;
            int MinuteClosed = AlternativeDayClosedPicker.Value.Minute;
            DateTime Opentijd = new DateTime(Year, Month, Day, HourOpen, MinuteOpen, 0);
            DateTime GeslotenTijd = new DateTime(Year, Month, Day, HourClosed, MinuteClosed, 0);
            DePandaClassLib.Entities.AlternativeDate NewAlternativeDate = new DePandaClassLib.Entities.AlternativeDate(Opentijd, GeslotenTijd);
            DataStorageHandler.Storage.Settings.AlternativeDates.Add(NewAlternativeDate);
            LoadAlternativeDays();
        }

        private List<DePandaClassLib.Entities.AlternativeDate> ListOfAlternativeDates = DataStorageHandler.Storage.Settings.AlternativeDates;
        public void LoadAlternativeDays()
        {
            // loads in the list of alternative days
            ListOfAlternativeDays.Items.Clear();
            ListOfAlternativeDays.Items.Add($"     Datum     Geopend     Gesloten");
            foreach (DePandaClassLib.Entities.AlternativeDate date in ListOfAlternativeDates)
            {
                ListOfAlternativeDays.Items.Add($"{date.DateString}     {date.StartTimeString}           {date.EndTimeString}");
            }
        }

        private void SaveRegularDays()
        {
            // saves the data that was given by the  current daytimepickers times
            WeekDayList[0] = new DePandaClassLib.Entities.WeekDay(MondayOpenPicker.Value, MondayClosedPicker.Value);
            WeekDayList[1] = new DePandaClassLib.Entities.WeekDay(TuesdayOpenPicker.Value, TuesdayClosedPicker.Value);
            WeekDayList[2] = new DePandaClassLib.Entities.WeekDay(WednesdayOpenPicker.Value, WednesdayClosedPicker.Value);
            WeekDayList[3] = new DePandaClassLib.Entities.WeekDay(ThursdayOpenPicker.Value, ThursdayClosedPicker.Value); 
            WeekDayList[4] = new DePandaClassLib.Entities.WeekDay(FridayOpenPicker.Value, FridayClosedPicker.Value);
            WeekDayList[5] = new DePandaClassLib.Entities.WeekDay(SaturdayOpenPicker.Value, SaturdayClosedPicker.Value);
            WeekDayList[6] = new DePandaClassLib.Entities.WeekDay(SundayOpenPicker.Value, SundayClosedPicker.Value);
            LoadWeekDays();
        }

        private void DeleteAlternativeDayClick(object sender, EventArgs e)
        {
            // deletes selected alternative dates 
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
            // Changes pincode if correct
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
            // when the page has been left it will save
            SaveRegularDays();
        }

        private void TimeChanged(object sender, KeyEventArgs e)
        {
            // when the times changed it will save
            SaveRegularDays();
        }

        private DateTime SetTimeClosed(DateTime day)
        {
            // gets daytime value and set time to 00:00 (for closing)
            TimeSpan NewTime = new TimeSpan(0, 0, 0);
            return day.Date + NewTime; ;
        }

        // When pressed on the closed button it will set the time to 00:00
        private void MondayClosedClick(object sender, EventArgs e)
        {
            WeekDayList[0] = new DePandaClassLib.Entities.WeekDay(SetTimeClosed(MondayOpenPicker.Value), SetTimeClosed(MondayClosedPicker.Value));
            LoadWeekDays();
        }

        private void TuesdayClosedClick(object sender, EventArgs e)
        {
            WeekDayList[1] = new DePandaClassLib.Entities.WeekDay(SetTimeClosed(TuesdayOpenPicker.Value), SetTimeClosed(TuesdayClosedPicker.Value));
            LoadWeekDays();
        }

        private void WednesdayClosedClick(object sender, EventArgs e)
        {
            WeekDayList[2] = new DePandaClassLib.Entities.WeekDay(SetTimeClosed(WednesdayOpenPicker.Value), SetTimeClosed(WednesdayClosedPicker.Value));
            LoadWeekDays();
        }

        private void ThursdayClosedClick(object sender, EventArgs e)
        {
            WeekDayList[3] = new DePandaClassLib.Entities.WeekDay(SetTimeClosed(ThursdayOpenPicker.Value), SetTimeClosed(ThursdayClosedPicker.Value));
            LoadWeekDays();
        }

        private void FridayClosedClick(object sender, EventArgs e)
        {
            WeekDayList[4] = new DePandaClassLib.Entities.WeekDay(SetTimeClosed(FridayOpenPicker.Value), SetTimeClosed(FridayClosedPicker.Value));
            LoadWeekDays();
        }

        private void SaturdayClosedClick(object sender, EventArgs e)
        {
            WeekDayList[5] = new DePandaClassLib.Entities.WeekDay(SetTimeClosed(SaturdayOpenPicker.Value), SetTimeClosed(SaturdayClosedPicker.Value));
            LoadWeekDays();
        }

        private void SundayClosedClick(object sender, EventArgs e)
        {
            WeekDayList[6] = new DePandaClassLib.Entities.WeekDay(SetTimeClosed(SundayOpenPicker.Value), SetTimeClosed(SundayClosedPicker.Value));
            LoadWeekDays();
        }
    }
}
