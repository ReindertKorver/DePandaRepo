using DePandaClassLib.Entities;
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
        private Category CurrentFilter = Category.None;
        private List<Dish> Dishes;

        public NewOrder(ref Order order)
        {
            InitializeComponent();
            CurrentOrder = order;
            Dishes = DataStorageHandler.Storage.StockDishes;
            var temp = Enum.GetNames(typeof(Category));
            var res = (temp as string[]).ToList();
            res.RemoveAt(0);
            CategoryCB.DataSource = res;
            CategoryCB.SelectedItem = null;
            CategoryCB.Text = "Selecteer...";

            MenuItemList.Controls.Clear();

            if (Dishes != null && Dishes.Count != 0)
            {
                foreach (var dish in Dishes)
                {
                    OrderItem item = new OrderItem(dish);
                    MenuItemList.Controls.Add(item);
                }
            }
        }

        private void SaveOrderBtn_Click(object sender, EventArgs e)
        {
            //todo: change 2 to time of reservation
            Reservation res = DataStorageHandler.Storage.Reservations.FirstOrDefault(r => r.Table == TableNumberTB.Text && CheckResTime(r));
            if (res == null)
            {
                MessageBox.Show("Kan geen reservering vinden binnen tijdsbestek en bij dit tafelnummer, is de reservering goed aangemaakt?");
            }
            else
            {
                CurrentOrder.Reservation = res;
                if (MenuItemList.Controls == null || MenuItemList.Controls.Count == 0)
                {
                }
                else
                {
                    OrderItem[] arr = new OrderItem[MenuItemList.Controls.Count];
                    MenuItemList.Controls.CopyTo(arr, 0);
                    var dishes = arr.Select(a => a.DishItem).Where(d => d.Amount > 0).ToList();
                    if (dishes == null || dishes.Count <= 0)
                    {
                        MessageBox.Show("Er zijn geen gerechten geselecteerd, selecteer 1 of meer gerechten.");
                    }
                    else
                    {
                        CurrentOrder.Dishes = dishes;
                        //Save it to DataStorage
                        if (res.Orders == null)
                        {
                            res.Orders = new List<Order>();
                        }
                        CurrentOrder.OrderDate = DateTime.Now;
                        res.Orders.Add(CurrentOrder);
                        MessageBox.Show("Bestelling is geplaatst");
                        OrderSaved?.Invoke(this, EventArgs.Empty);
                    }
                }
            }
        }

        public event EventHandler OrderSaved;

        private bool CheckResTime(Reservation r)
        {
            var now = DateTime.Now;
            var first = r.Date;
            var last = r.Date.Add(r.Time);
            return now < last && now > first;
        }

        private void TableNumberTB_Leave(object sender, EventArgs e)
        {
        }

        private async void TableNumberTB_TextChanged(object sender, EventArgs e)
        {
            Reservation res = await Task.Run(() =>
            {
                return DataStorageHandler.Storage.Reservations.FirstOrDefault(r => r.Table == TableNumberTB.Text && CheckResTime(r));
            });
            if (res != null)
                ReservationLBL.Text = res.OnTheNameOf + " " + res.Date.ToString("HH:mm") + " - " + res.Date.Add(res.Time).ToString("HH:mm");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CurrentOrder = null;
            OrderSaved?.Invoke(this, EventArgs.Empty);
        }

        private void DeleteOrderBtn_Click(object sender, EventArgs e)
        {
            CurrentOrder = null;
            TableNumberTB.Text = "";
            CurrentOrder = new Order();
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

        private void CategoryCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategoryCB.SelectedItem != null)
            {
                if (Enum.TryParse(CategoryCB.SelectedValue.ToString(), out Category cat))
                {
                    CurrentFilter = cat;
                    MenuItemList.Controls.Clear();

                    if (Dishes != null && Dishes.Count != 0)
                    {
                        foreach (var dish in Dishes)
                        {
                            if (CurrentFilter == dish.Category)
                            {
                                OrderItem item = new OrderItem(dish);
                                MenuItemList.Controls.Add(item);
                            }
                        }
                    }
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CategoryCB.SelectedItem = null;
            CategoryCB.Text = "Selecteer...";
            MenuItemList.Controls.Clear();

            if (Dishes != null && Dishes.Count != 0)
            {
                foreach (var dish in Dishes)
                {
                    OrderItem item = new OrderItem(dish);
                    MenuItemList.Controls.Add(item);
                }
            }
        }
    }
}