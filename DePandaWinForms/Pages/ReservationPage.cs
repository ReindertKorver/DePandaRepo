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
    public partial class ReservationPage : Form
    {
        public ReservationPage()
        {
            InitializeComponent();
            //DataStorageHandler.Storage.Reservations.Add(new DePandaLib.Entities.Reservation() { });
            LoadExistingReservations();
            dateTimePicker3.Value = dateTimePicker2.Value.AddHours(2);
        }

        // show reservations in listview
        public void LoadExistingReservations()
        {
            var Reservations = DataStorageHandler.Storage.Reservations;

            foreach (var reservation in Reservations)
            {
                ListViewItem item = new ListViewItem(reservation.OnTheNameOf);
                item.SubItems.Add(reservation.Date.ToString("dd-MM-yyyy"));
                item.SubItems.Add(reservation.Date.ToString("HH:mm") + " - " + (reservation.Date + reservation.Time).ToString("HH:mm"));
                item.SubItems.Add(reservation.AmountOfPeople.ToString());
                item.SubItems.Add(reservation.Table);
                item.SubItems.Add(reservation.Specifications);
                listView.Items.Add(item);
            }
        }
        
        public bool ReservationTimeCheck()
        {
            DayOfWeek[] days = { DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Thursday, DayOfWeek.Friday, DayOfWeek.Saturday, DayOfWeek.Sunday };
            for (int i = 0; i < days.Length; i++)
            {
                if (dateTimePicker1.Value.DayOfWeek == days[i])
                {
                    var time = dateTimePicker2.Value.TimeOfDay;
                    var time2 = dateTimePicker3.Value.TimeOfDay;
                    if (time < DataStorageHandler.Storage.Settings.WeekDays[i].OpenTime.TimeOfDay || time2 > DataStorageHandler.Storage.Settings.WeekDays[i].CloseTime.AddMinutes(1).TimeOfDay)
                    {
                        return false;
                    }
                    return true;
                }
            }
            return true;
        }

        // add reservation
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dateTime = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, dateTimePicker2.Value.Hour, dateTimePicker2.Value.Minute, dateTimePicker2.Value.Second);
            TimeSpan timeSpan = new TimeSpan(dateTimePicker3.Value.Hour - dateTimePicker2.Value.Hour, dateTimePicker3.Value.Minute - dateTimePicker2.Value.Minute, 0);

            if (string.IsNullOrEmpty(txtNaam.Text))
            {
                MessageBox.Show("Vul alle velden in");
                return;
            }
            if (dateTime.AddMinutes(1) < DateTime.Now)
            {
                MessageBox.Show("Vul een geldige datum en tijd in");
                return;
            }
            if (tafelnr == "")
            {
                MessageBox.Show("Klik een tafel aan");
                return;
            }

            bool x = ReservationTimeCheck();
            if (x == false)
            {
                MessageBox.Show("U kunt geen reservering plaatsen buiten de openingstijden");
                return;
            }

            DataStorageHandler.Storage.Reservations.Add(new DePandaLib.Entities.Reservation(){ OnTheNameOf = txtNaam.Text, Date = dateTime, Time = timeSpan, AmountOfPeople = decimal.ToInt32(PersonenBox.Value), Table = tafelnr, Specifications = txtBijzonder.Text });
            listView.Items.Clear();
            LoadExistingReservations();

            Cleartables();
            PersonenBox.Value = 1;

            txtNaam.Clear(); txtBijzonder.Clear();
            
        }

        // remove reservation
        private void button2_Click(object sender, EventArgs e)
        {
            Panel[] panels = new Panel[] { panel1, panel2, panel3, panel4, panel5, panel6, panel7, panel8, panel9, panel10, panel11, panel12 };
            var Reservations = DataStorageHandler.Storage.Reservations;

            if (listView.SelectedItems.Count > 0)
            {
                int v = int.Parse(Reservations[listView.SelectedItems[0].Index].Table);
                panels[v-1].BackColor = Color.Gainsboro;
                Reservations.Remove(Reservations[listView.SelectedItems[0].Index]);
                listView.Items.Remove(listView.SelectedItems[0]);
            }
        }

        // search reservation by name
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (searchBox.Text != "")
            {
                for (int i = listView.Items.Count - 1; i >= 0; i--)
                {
                    var item = listView.Items[i];
                    if (item.Text.ToLower().Contains(searchBox.Text.ToLower()))
                    {
                        item.BackColor = SystemColors.Highlight;
                        item.ForeColor = SystemColors.HighlightText;
                    }
                    else
                    {
                        listView.Items.Remove(item);
                    }
                }
            }
            else
            {
                listView.Items.Clear();
                LoadExistingReservations();
            }
        }

        // restaurant tables
        string tafelnr = "";

        private void Cleartables()
        {
            Panel[] panels = new Panel[] { panel1, panel2, panel3, panel4, panel5, panel6, panel7, panel8, panel9, panel10, panel11, panel12 };
            for(int i = 0; i<panels.Length; i++)
            {
                if(panels[i].BackColor == Color.Green)
                {
                    panels[i].BackColor = Color.Gray;
                }
            }
            tafelnr = "";
        }
        private void panel14_MouseClick(object sender, MouseEventArgs e)
        {
            int CurX = e.X;
            int CurY = e.Y;
            Panel[] panels = new Panel[] { panel1, panel2, panel3, panel4, panel5, panel6, panel7, panel8, panel9, panel10, panel11, panel12 };


            foreach(var panel in panels)
            {
                if (CurX > panel.Location.X && CurX < panel.Location.X + panel.Width && CurY > panel.Location.Y && CurY < panel.Location.Y + panel.Height)
                {
                    if (panel.BackColor == Color.Gray)
                    {
                        return;
                    }
                    if (panel.BackColor == Color.Gainsboro)
                    {
                        int TableSelected = 0;
                        for(int i = 0; i < panels.Length; i++)
                        {
                            if (panels[i].BackColor == Color.Green)
                            {
                                TableSelected += 1;
                            }
                        }
                        if (TableSelected == 0)
                        {
                            panel.BackColor = Color.Green;
                            tafelnr = panel.TabIndex.ToString();
                        }
                    }
                    else
                    {
                        panel.BackColor = Color.Gainsboro;
                    }

                }
            }
            
        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker3.Value = dateTimePicker2.Value.AddHours(2);
            dateTimePicker3_ValueChanged(sender, e);
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            Panel[] panels = new Panel[] { panel1, panel2, panel3, panel4, panel5, panel6, panel7, panel8, panel9, panel10, panel11, panel12 };
            var Reservations = DataStorageHandler.Storage.Reservations;
            
            foreach (var reservation in Reservations)
            {
                DateTime dateTime = reservation.Date;
                DateTime dateTime2 = reservation.Date + reservation.Time;
                Panel panel = panels[int.Parse(reservation.Table)-1];
                
                if (dateTime.Date == dateTimePicker1.Value.Date)
                {
                    if (dateTimePicker2.Value.TimeOfDay >= dateTime.TimeOfDay && dateTimePicker2.Value.TimeOfDay < dateTime2.TimeOfDay || 
                        dateTimePicker3.Value.TimeOfDay > dateTime.TimeOfDay && dateTimePicker3.Value.TimeOfDay <= dateTime2.TimeOfDay || 
                        dateTimePicker2.Value.TimeOfDay < dateTime.TimeOfDay && dateTimePicker3.Value.TimeOfDay > dateTime2.TimeOfDay)
                    {
                        panel.BackColor = Color.Gray;
                        break;
                    }
                    else
                    {
                        panel.BackColor = Color.Gainsboro;
                    }
                }
                else
                {
                    panel.BackColor = Color.Gainsboro;
                }
            }
        }
    }
}