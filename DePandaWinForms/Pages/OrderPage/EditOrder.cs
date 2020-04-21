using DePandaLib.DAL;
using DePandaLib.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DePandaWinForms.Pages.OrderPage
{
    public partial class EditOrder : Form
    {
        private Order CurrentOrder { get; set; }

        public EditOrder(ref Order order)
        {
            InitializeComponent();
            CurrentOrder = order;
            FillUIWithOrderData();
        }

        private void FillUIWithOrderData()
        {
            if (CurrentOrder != null)
            {
                if (CurrentOrder.Reservation != null && CurrentOrder.Reservation.ID != null)
                {
                    Reservation reservation = DataStorageHandler.Storage.Reservations.FirstOrDefault(r => r.ID == CurrentOrder.Reservation.ID);
                    if (reservation != null)
                    {
                        TableNumberLBL.Text = reservation.Table;
                    }
                    else
                    {
                        //Couldnt retrieve reservation by order
                    }
                }
                else
                {
                    //something is wrong with the order
                }
                if (CurrentOrder.Dishes != null && CurrentOrder.Dishes.Count != 0)
                {
                    foreach (var dish in CurrentOrder.Dishes)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = dish.Name;
                        OrderMenuItemsView.Items.Add(item);
                    }
                }
            }
        }
    }
}