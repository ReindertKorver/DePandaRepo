using DePandaLib.DAL;
using DePandaLib.Entities;
using DePandaWinForms.Design;
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
                    if (CurrentOrder.Reservation != null)
                    {
                        TableNumberTB.Text = CurrentOrder.Reservation.Table;
                        OnTheNameOfTb.Text = CurrentOrder.Reservation.OnTheNameOf;
                        DateTb.Text = CurrentOrder.OrderDate.ToString("dd/MM/yyyy HH:mm");
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
                        OrderItem item = new OrderItem(dish, useDefaultAmount: true);
                        MenuItemList.Controls.Add(item);
                    }
                    decimal total = CurrentOrder.GetTotal();
                    TotalLbl.Text = "Totaal: \t€ " + total;
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}