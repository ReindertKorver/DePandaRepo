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

        List<Int32> data;
        private List<Int32> SplitStrings(string Time)
        {
            string[] TimeList = Time.Split(':');
            int Hour = Int32.Parse(TimeList[0]);
            int Minute = Int32.Parse(TimeList[1]);
            List<Int32> data  = new List<Int32> { Hour, Minute};
            return data;
           
        }

        private bool ValidString(string Time)
        {
            string[] TimeList = Time.Split(':');
            if (TimeList.Length != 2)
            {
                return false;
            }
            if (TimeList[0].All(char.IsDigit) && TimeList[1].All(char.IsDigit))
            {
                int Hour = Int32.Parse(TimeList[0]);
                int Minute = Int32.Parse(TimeList[1]);

                List<Int32> data = new List<Int32> { Hour, Minute };
                bool allPositive = data.All(x => x > 0);
                if (Hour < 24 && Minute < 60 && allPositive)
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
         
            Int32 year = DatumPrikker.Value.Year;
            Int32 day = DatumPrikker.Value.Day;
            Int32 month = DatumPrikker.Value.Month;
            var newAltDate = new DePandaClassLib.Entities.AlternativeDate(new DateTime(year, day, month, SplitStrings(OpenALTINP.Text)[0], SplitStrings(OpenALTINP.Text)[1], 0), new DateTime(year, day, month, SplitStrings(ClosedALTINP.Text)[0], SplitStrings(ClosedALTINP.Text)[1], 0));
            DataStorageHandler.Storage.Settings.AlternativeDates.Add(newAltDate);
            MessageBox.Show("Datum succesvol toegevoed");
        }
        private void AddAltDay_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0 | listBox1.SelectedItem == null)
            {
                if (ValidString(OpenALTINP.Text) && ValidString(ClosedALTINP.Text))
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
            var maandag = new DePandaClassLib.Entities.WeekDay(MondayOpen.Text, MondayClosed.Text);
            WeekDayList.RemoveAt(0);
            WeekDayList.Insert(0, maandag);

            var dinsdag = new DePandaClassLib.Entities.WeekDay(TuesDayOpen.Text, TuesDayClosed.Text);
            WeekDayList.RemoveAt(1);
            WeekDayList.Insert(1, dinsdag);

            var woensdag = new DePandaClassLib.Entities.WeekDay(WednesDayOpen.Text, WednesDayClosed.Text);
            WeekDayList.RemoveAt(2);
            WeekDayList.Insert(2, woensdag);

            var donderdag = new DePandaClassLib.Entities.WeekDay(ThursDayOpen.Text, ThursDayClosed.Text);
            WeekDayList.RemoveAt(3);
            WeekDayList.Insert(3, donderdag);

            var vrijdag = new DePandaClassLib.Entities.WeekDay(FridayOpen.Text, FridayClosed.Text);
            WeekDayList.RemoveAt(4);
            WeekDayList.Insert(4, vrijdag);

            var zaterdag = new DePandaClassLib.Entities.WeekDay(SaturDayOpen.Text, SaturDayClosed.Text);
            WeekDayList.RemoveAt(5);
            WeekDayList.Insert(5, zaterdag);

            var zondag = new DePandaClassLib.Entities.WeekDay(SunDayOpen.Text, SunDayClosed.Text);
            WeekDayList.RemoveAt(6);
            WeekDayList.Insert(6, zondag);
        }


        private void DayINP_leave(object sender, EventArgs e)
        {
            if (!ValidString((sender as TextBox).Text))
            {
                (sender as TextBox).Text = "xx:xx";
                MessageBox.Show("De tijd die u heeft opgegeven is onjuist");
            }
            
        }

        private void DayINP_Enter(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text != "" | (sender as TextBox).Text != "xx:xx")
            {
                (sender as TextBox).Text = "";
            }
        }

        
    }
}





