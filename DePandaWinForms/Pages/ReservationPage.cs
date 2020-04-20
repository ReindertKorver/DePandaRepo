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
        }

        // show reservations in listview
        public void LoadExistingReservations()
        {
            var Reservations = DataStorageHandler.Storage.Reservations;
            foreach (var reservation in Reservations)
            {
                ListViewItem item = new ListViewItem(reservation.OnTheNameOf);
                item.SubItems.Add(reservation.Date.ToString("dd-MM-yyyy"));
                item.SubItems.Add(reservation.Time.ToString("HH:mm"));
                item.SubItems.Add(reservation.AmountOfPeople.ToString());
                item.SubItems.Add(reservation.Table);
                item.SubItems.Add(reservation.Specifications);
                listView.Items.Add(item);
            }
        }

        public bool ReservationTimeCheck()
        {
            DayOfWeek[] days = { DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Thursday, DayOfWeek.Friday, DayOfWeek.Saturday, DayOfWeek.Sunday };
            for (int i = 0; i < days.Length - 1; i++)
            {
                if (dateTimePicker1.Value.DayOfWeek == days[i])
                {
                    var time = dateTimePicker2.Value.TimeOfDay;
                    var time2 = dateTimePicker2.Value.AddHours(1.99).TimeOfDay;
                    if (time < DataStorageHandler.Storage.Settings.WeekDays[i].OpenTime.TimeOfDay || time2 > DataStorageHandler.Storage.Settings.WeekDays[i].CloseTime.TimeOfDay)
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
            if (string.IsNullOrEmpty(txtNaam.Text) || string.IsNullOrEmpty(txtPersonen.Text) || string.IsNullOrEmpty(txtTafelnr.Text))
            {
                MessageBox.Show("Vul alle velden in");
                return;
            }
            if (dateTimePicker1.Value < DateTime.Today)
            {
                MessageBox.Show("Vul een geldige datum in");
                return;
            }

            bool x = ReservationTimeCheck();
            if (x == false)
            {
                MessageBox.Show("Vul een geldige tijd in");
                return;
            }

            DataStorageHandler.Storage.Reservations.Add(new DePandaLib.Entities.Reservation(){ OnTheNameOf = txtNaam.Text, Date = dateTimePicker1.Value.Date, Time = dateTimePicker2.Value, AmountOfPeople = int.Parse(txtPersonen.Text), Table = txtTafelnr.Text, Specifications = txtBijzonder.Text });
            listView.Items.Clear();
            LoadExistingReservations();

            txtNaam.Clear();
            txtPersonen.Clear();
            txtTafelnr.Clear();
            txtBijzonder.Clear();
            
        }

        // remove reservation
        private void button2_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                DataStorageHandler.Storage.Reservations.Remove(DataStorageHandler.Storage.Reservations[listView.SelectedItems[0].Index]);
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
    }
}