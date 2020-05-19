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
        List<DePandaClassLib.Entities.AlternativeDate> ListOfAlternativeDates = DataStorageHandler.Storage.Settings.AlternativeDates;
        int TimesLoaded = 0;
        DateTime ValueToCache;
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


  


        private void ChangedValue(object sender, EventArgs e)
        {
            TimesLoaded++;

            if (TimesLoaded > 14)
            {
                // when the times changed it will save
                bool MondayInvalid = DateTime.Compare(MondayOpenPicker.Value, MondayClosedPicker.Value) > 0;
                bool TuesdayInvalid = DateTime.Compare(TuesdayOpenPicker.Value, TuesdayClosedPicker.Value) > 0;
                bool WednesdayInvalid = DateTime.Compare(WednesdayOpenPicker.Value, WednesdayClosedPicker.Value) > 0;
                bool ThursdayInvalid = DateTime.Compare(ThursdayOpenPicker.Value, ThursdayClosedPicker.Value) > 0;
                bool FridayInvalid = DateTime.Compare(FridayOpenPicker.Value, FridayClosedPicker.Value) > 0;
                bool SaturdayInvalid = DateTime.Compare(SaturdayOpenPicker.Value, SaturdayClosedPicker.Value) > 0;
                bool SundayInvalid = DateTime.Compare(SundayOpenPicker.Value, SundayClosedPicker.Value) > 0;

                if (MondayInvalid | TuesdayInvalid | WednesdayInvalid | ThursdayInvalid | FridayInvalid | SaturdayInvalid | SundayInvalid)
                {
                    MessageBox.Show("U heeft een verkeerde tijd ingevuld, kies een andere tijd");
                    // for setting time back if its wrong
                    (sender as DateTimePicker).Value = ValueToCache;
                    return;            
                }
                SaveRegularDays();
            }
        }


        private void DateTimePickerEnter(object sender, EventArgs e)
        {
            ValueToCache = (sender as DateTimePicker).Value;
        }


        DePandaClassLib.Entities.WeekDay DayClosed = new DePandaClassLib.Entities.WeekDay(new DateTime(2020, 04, 07, 0, 0, 0), new DateTime(2020, 04, 07, 0, 0, 0));
        private void ClosedClick(object sender, MouseEventArgs e)
        {
            string Name = ((sender as Button).Name).Replace("ClosedButton", "");

            if (Name == "Monday")
                WeekDayList[0] = DayClosed;

            else if (Name == "Tuesday")
                WeekDayList[1] = DayClosed;

            else if (Name == "Wednesday")
                WeekDayList[2] = DayClosed; 

            else if (Name == "Thursday")
                WeekDayList[3] = DayClosed;

            else if (Name == "Friday")
                WeekDayList[4] = DayClosed;

            else if (Name == "Saturday")
                WeekDayList[5] = DayClosed;

            else if (Name == "Sunday")
                WeekDayList[6] = DayClosed;

          
            LoadWeekDays();
        }
    }
}
