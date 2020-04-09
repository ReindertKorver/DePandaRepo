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
            LoadInMenuItems();
            
            
            
            
            
            if (previousWinstate == FormWindowState.Maximized)
            {
                PanelALTDay.Location = new Point(500, 157);
            }
            else if (previousWinstate == FormWindowState.Normal)
            {
                PanelALTDay.Location = new Point(12, 466);
            }
            var Days = DataStorageHandler.Storage.Settings.WeekDays;
            //DataStorageHandler.Storage.Settings.WeekDays.Clear();
            
            Counter.Text = DataStorageHandler.Storage.Settings.WeekDays.Count.ToString();
            MondayOpen.Text = Days[0].StartTime;
            MondayClosed.Text = Days[0].EndTime;
            TuesDayOpen.Text = Days[1].StartTime;
            TuesDayClosed.Text = Days[1].EndTime;
            WednesDayOpen.Text = Days[2].StartTime;
            WednesDayClosed.Text = Days[2].EndTime;
            ThursDayOpen.Text = Days[3].StartTime;
            ThursDayClosed.Text = Days[3].EndTime;
            FridayOpen.Text = Days[4].StartTime;
            FridayClosed.Text = Days[4].EndTime;
            SaturDayOpen.Text = Days[5].StartTime;
            SaturDayClosed.Text = Days[5].EndTime;
            SunDayOpen.Text = Days[6].StartTime;
            SunDayOpen.Text = Days[6].EndTime;
            SaveWeekDays();


        }
        public  void SaveWeekDays()
        {

            var Days = DataStorageHandler.Storage.Settings.WeekDays;


            //var Monday = new DePandaClassLib.Entities.WeekDay(MondayOpen.Text, MondayClosed.Text);
            //DataStorageHandler.Storage.Settings.WeekDays.Add(Monday);
            //var Tuesday = new DePandaClassLib.Entities.WeekDay(TuesDayOpen.Text, TuesDayOpen.Text);
            //DataStorageHandler.Storage.Settings.WeekDays.Add(Tuesday);
            //var Wednesday = new DePandaClassLib.Entities.WeekDay(WednesDayOpen.Text, WednesDayClosed.Text);
            //DataStorageHandler.Storage.Settings.WeekDays.Add(Wednesday);
            //var ThursDay = new DePandaClassLib.Entities.WeekDay(ThursDayOpen.Text, ThursDayClosed.Text);
            //DataStorageHandler.Storage.Settings.WeekDays.Add(ThursDay);

            //var friday = new DePandaClassLib.Entities.WeekDay(FridayOpen.Text, FridayClosed.Text);
            //DataStorageHandler.Storage.Settings.WeekDays.Add(friday);
            //var saturday = new DePandaClassLib.Entities.WeekDay(SaturDayOpen.Text, SaturDayClosed.Text);
            //DataStorageHandler.Storage.Settings.WeekDays.Add(saturday);
            //var sunday = new DePandaClassLib.Entities.WeekDay(SunDayOpen.Text, SunDayClosed.Text);
            //DataStorageHandler.Storage.Settings.WeekDays.Add(sunday);




            DataStorageHandler.Storage.Settings.WeekDays[0].StartTime =  MondayOpen.Text;
            Days[0].EndTime = MondayClosed.Text;

            Days[1].StartTime = TuesDayOpen.Text;
            Days[1].EndTime = TuesDayClosed.Text;

            Days[2].StartTime = WednesDayOpen.Text;
            Days[2].EndTime = WednesDayClosed.Text;

            Days[3].StartTime = ThursDayOpen.Text;
            Days[3].EndTime = ThursDayClosed.Text;

            Days[4].StartTime = FridayOpen.Text;
            Days[4].EndTime = FridayClosed.Text;

            Days[5].StartTime = SaturDayOpen.Text;
            Days[5].EndTime = SaturDayClosed.Text;

            Days[6].StartTime = SunDayOpen.Text;
            Days[6].EndTime = SunDayClosed.Text;



        }
        private Int32[] data;
        private List<Int32> SplitStrings(string OpenTime, string ClosedTime)
        {
            string[] OpenTimeList = OpenTime.Split(':');
            int HourOpen = Int32.Parse(OpenTimeList[0]);
            int MinuteOpen = Int32.Parse(OpenTimeList[1]);

            string[] ClosedTimeList = ClosedTime.Split(':');
            int HourClosed = Int32.Parse(OpenTimeList[0]);
            int MinuteClosed = Int32.Parse(ClosedTimeList[1]);
            List<Int32> data = new List<Int32>{ HourOpen, MinuteOpen, HourClosed, MinuteClosed };
            
            return data;
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
                    {
                        foreach (DePandaClassLib.Entities.AlternativeDate date in days)
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
        private  List<DePandaClassLib.Entities.AlternativeDate> days = DataStorageHandler.Storage.Settings.AlternativeDates;
        public void LoadInMenuItems()
        {
            
            listBox1.Items.Add($"     Datum     Geopend     Gesloten");
            foreach (DePandaClassLib.Entities.AlternativeDate date in days)
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

        private void Counter_Click(object sender, EventArgs e)
        {
            
        }
    }
}
