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

        List<DePandaClassLib.Entities.AlternativeDate> ListOfAlternativeDates = DataStorageHandler.Storage.Settings.AlternativeDates;
        public bool ReservationTimeCheck()
        {
            DayOfWeek[] days = { DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Thursday, DayOfWeek.Friday, DayOfWeek.Saturday, DayOfWeek.Sunday };
            TimeSpan time = dateTimePicker2.Value.TimeOfDay;
            TimeSpan time2 = dateTimePicker3.Value.TimeOfDay;
            for (int i = 0; i < ListOfAlternativeDates.Count; i++)
            {
                if (dateTimePicker1.Value.Date == ListOfAlternativeDates[i].StartDate.Date)
                {
                   
                    if (time < ListOfAlternativeDates[i].StartDate.TimeOfDay || time2 > ListOfAlternativeDates[i].EndDate.TimeOfDay)
                    {
                        return false;
                    }
                    return true;
                }
            }
            for (int i = 0; i < days.Length; i++)
            {
                if (dateTimePicker1.Value.DayOfWeek == days[i])
                {
                    if (DataStorageHandler.Storage.Settings.WeekDays.Count == 0 ||  time < DataStorageHandler.Storage.Settings.WeekDays[i].OpenTime.TimeOfDay || time2 > DataStorageHandler.Storage.Settings.WeekDays[i].CloseTime.AddMinutes(1).TimeOfDay)
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
            if (dateTime.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Vul een geldige datum in");
                return;
            }
            if (tafelnr == "")
            {
                MessageBox.Show("Klik een tafel aan");
                return;
            }
            if (PersonenBox.Value > zitplaatsen)
            {
                MessageBox.Show("Deze tafel heeft niet genoeg zitplaatsen voor het aantal ingevoerde personen");
                return;
            }
            if (!ReservationTimeCheck())
            {
                MessageBox.Show("U kunt geen reservering plaatsen buiten de openingstijden");
                return;
            }

            DataStorageHandler.Storage.Reservations.Add(new DePandaLib.Entities.Reservation() { OnTheNameOf = txtNaam.Text, Date = dateTime, Time = timeSpan, AmountOfPeople = decimal.ToInt32(PersonenBox.Value), Table = tafelnr, Specifications = txtBijzonder.Text });
            listView.Items.Clear();
            LoadExistingReservations();

            Cleartables();
            Tafeltext.Text = "Klik een tafel aan";
            PersonenBox.Value = 1;

            txtNaam.Clear(); txtBijzonder.Clear();
        }

        // remove reservation
        List<DePandaLib.Entities.Reservation> Reservations = DataStorageHandler.Storage.Reservations;
        private void button2_Click(object sender, EventArgs e)
        {
            Panel[] panels = new Panel[] { panel1, panel2, panel3, panel4, panel5, panel6, panel7, panel8, panel9, panel10, panel11, panel12 };

            if (listView.SelectedItems.Count > 0)
            {
                int v = int.Parse(Reservations[listView.SelectedItems[0].Index].Table);
                panels[v - 1].BackColor = Color.Gainsboro;

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
                    ListViewItem item = listView.Items[i];
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
        private void searchBox_Enter(object sender, EventArgs e)
        {
            if (searchBox.Text == "Zoeken...")
            {
                searchBox.Text = "";
                searchBox.ForeColor = Color.Black;
            }
        }
        private void searchBox_Leave(object sender, EventArgs e)
        {
            if (searchBox.Text == "")
            {
                searchBox.Text = "Zoeken...";
                searchBox.ForeColor = Color.Silver;
                LoadExistingReservations();
            }
        }

        // restaurant tables
        string tafelnr = "";
        int zitplaatsen = 0;

        private void Cleartables()
        {
            Panel[] panels = new Panel[] { panel1, panel2, panel3, panel4, panel5, panel6, panel7, panel8, panel9, panel10, panel11, panel12 };
            for (int i = 0; i < panels.Length; i++)
            {
                if (panels[i].BackColor == Color.Green)
                {
                    panels[i].BackColor = Color.Gray;
                }
            }
            tafelnr = "";
        }

        public void CheckTableSeats(Panel panel)
        {
            if (panel.Name == "panel12" || panel.Name == "panel10" || panel.Name == "panel9")
            {
                Tafeltext.Text = "8 personen tafel geselecteerd";
                zitplaatsen = 8;
            }
            else if (panel.Name == "panel2")
            {
                Tafeltext.Text = "2 personen tafel geselecteerd";
                zitplaatsen = 2;
            }
            else
            {
                Tafeltext.Text = "4 personen tafel geselecteerd";
                zitplaatsen = 4;
            }
        }

        private void panel14_MouseClick(object sender, MouseEventArgs e)
        {
            int CurX = e.X;
            int CurY = e.Y;
            Panel[] panels = new Panel[] { panel1, panel2, panel3, panel4, panel5, panel6, panel7, panel8, panel9, panel10, panel11, panel12 };

            foreach (Panel panel in panels)
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
                        for (int i = 0; i < panels.Length; i++)
                        {
                            if (panels[i].BackColor == Color.Green)
                            {
                                TableSelected += 1;
                            }
                        }
                        if (TableSelected == 1)
                        {
                            foreach(Panel x in panels)
                            {
                                if (x.BackColor == Color.Green)
                                {
                                    x.BackColor = Color.Gainsboro;
                                }
                            }
                            CheckTableSeats(panel);
                            panel.BackColor = Color.Green;
                            tafelnr = panel.TabIndex.ToString();
                        }
                        if (TableSelected == 0)
                        {
                            CheckTableSeats(panel);
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
            List<Panel> seen = new List<Panel>();

            foreach (var reservation in Reservations)
            {
                DateTime dateTime = reservation.Date;
                DateTime dateTime2 = reservation.Date + reservation.Time;
                Panel panel = panels[int.Parse(reservation.Table) - 1];

                if (seen.Contains(panel))
                {
                    continue;
                }

                if (dateTime.Date == dateTimePicker1.Value.Date)
                {
                    if (dateTimePicker2.Value.TimeOfDay >= dateTime.TimeOfDay && dateTimePicker2.Value.AddMinutes(1).TimeOfDay < dateTime2.TimeOfDay ||
                        dateTimePicker3.Value.TimeOfDay > dateTime.TimeOfDay && dateTimePicker3.Value.TimeOfDay <= dateTime2.TimeOfDay ||
                        dateTimePicker2.Value.TimeOfDay < dateTime.TimeOfDay && dateTimePicker3.Value.TimeOfDay > dateTime2.TimeOfDay)
                    {
                        panel.BackColor = Color.Gray;
                        seen.Add(panel);
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