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
                item.SubItems.Add(reservation.Date.Day + "-" + reservation.Date.Month + "-" + reservation.Date.Year.ToString());
                item.SubItems.Add(reservation.Time);
                item.SubItems.Add(reservation.AmountOfPeople.ToString());
                item.SubItems.Add(reservation.Table);
                item.SubItems.Add(reservation.Specifications);
                listView.Items.Add(item);
            }
        }

        // add reservation
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNaam.Text) || string.IsNullOrEmpty(txtTijd.Text) || string.IsNullOrEmpty(txtPersonen.Text) || string.IsNullOrEmpty(txtTafelnr.Text) || string.IsNullOrEmpty(txtBijzonder.Text))
            {
                MessageBox.Show("Vul alle velden in");
                return;
            }

            DataStorageHandler.Storage.Reservations.Add(new DePandaLib.Entities.Reservation(){ OnTheNameOf = txtNaam.Text, Date = dateTimePicker1.Value, Time = txtTijd.Text, AmountOfPeople = int.Parse(txtPersonen.Text), Table = txtTafelnr.Text, Specifications = txtBijzonder.Text });
            listView.Items.Clear();
            LoadExistingReservations();

            txtNaam.Clear();
            txtTijd.Clear();
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