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
    public partial class NewOrder : Form
    {
        private Order CurrentOrder { get; set; }

        public NewOrder(ref Order order)
        {
            InitializeComponent();
            CurrentOrder = order;
            var dishes = DataStorageHandler.Storage.StockDishes;
            MenuItemList.Controls.Clear();

            if (dishes != null && dishes.Count != 0)
            {
                foreach (var dish in dishes)
                {
                    OrderItem item = new OrderItem(dish);
                    MenuItemList.Controls.Add(item);
                }
            }
        }

        private void SaveOrderBtn_Click(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            //todo: change 2 to time of reservation
            Reservation res = DataStorageHandler.Storage.Reservations.FirstOrDefault(r => r.Table == TableNumberTB.Text && (now.Hour >= r.Date.Hour && now.Hour <= r.Date.Hour + 2));
            if (res != null)
            {
                CurrentOrder.Reservation = res;
            }
            else
            {
                MessageBox.Show("Kan geen reservering vinden binnen tijdsbestek en bij dit tafelnummer, is de reservering goed aangemaakt?");
            }
            if (MenuItemList.Controls != null && MenuItemList.Controls.Count != 0)
            {
                OrderItem[] arr = new OrderItem[MenuItemList.Controls.Count];
                MenuItemList.Controls.CopyTo(arr, 0);
                var dishes = arr.Select(a => a.DishItem).Where(d => d.Amount > 0).ToList();
            }
        }
    }
}