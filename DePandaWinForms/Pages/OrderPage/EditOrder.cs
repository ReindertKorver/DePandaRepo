﻿using DePandaClassLib.Entities;
using DePandaLib.DAL;
using DePandaLib.Entities;
using DePandaWinForms.Design;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DePandaWinForms.Pages.OrderPage
{
    public partial class EditOrder : Form
    {
        private PageCloseNotifier pageClose;
        private Category CurrentFilter = Category.None;
        private List<Dish> Dishes;
        private List<OrderItem> OrderItems = new List<OrderItem>();

        public EditOrder(ref Order order, PageCloseNotifier pageClose = null)
        {
            InitializeComponent();
            CurrentOrder = order;
            FillUIWithOrderData();

            panel2.Enabled = false;
            panel3.Enabled = false;
            panel4.Enabled = false;
            panel5.Enabled = false;
            SaveOrderBtn.Visible = false;
            EditMode(false);
            this.pageClose = pageClose;
            Dishes = DataStorageHandler.Storage.StockDishes;
        }

        public delegate void PageCloseNotifier(EditOrder order);

        private Order CurrentOrder { get; set; }

        public void EditMode(bool on)
        {
            panel2.Enabled = on;
            SaveOrderBtn.Visible = on;
            EditOrderBtn.Visible = !on;
            DeleteOrderBtn.Visible = !on;
            Spacer.Visible = on;
            TotalLbl.Visible = !on;
            PaymentBtn.Visible = !on;
        }

        private void DeleteOrderBtn_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Weet u zeker dat u deze bestelling wilt verwijderen?", "Let op!", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                var tempRes = DataStorageHandler.Storage.Reservations.FirstOrDefault(r => r.ID == CurrentOrder.Reservation.ID);
                if (tempRes != null)
                {
                    var amountDel = tempRes.Orders.RemoveAll(o => o.ID == CurrentOrder.ID);
                    if (amountDel > 0)
                    {
                        MessageBox.Show("Bestelling is verwijderd");
                    }
                    else
                    {
                        MessageBox.Show("Bestelling kon niet worden verwijderd, is de bestelling al verwijderd?");
                    }
                }
                else
                {
                    MessageBox.Show("Reservering kon niet worden geladen:\nMight mean data corruption");
                }
            }
        }

        private void EditOrderBtn_Click(object sender, EventArgs e)
        {
            EditMode(true);
            //Get all Dishes and get the already ordered dishes merge them together so the amount will be remembered
            Dishes = DataStorageHandler.Storage.StockDishes;
            if (Dishes != null && Dishes.Count != 0)
            {
                OrderItems.Clear();
                MenuItemList.Controls.Clear();
                if (CurrentOrder.Dishes != null && CurrentOrder.Dishes.Count != 0)
                {
                    var changedList = new List<Dish>();
                    foreach (var item in Dishes)
                    {
                        bool added = false;
                        foreach (var dish in CurrentOrder.Dishes)
                        {
                            if (dish.ID == item.ID)
                            {
                                changedList.Add(new Dish() { Amount = dish.Amount, Category = dish.Category, Description = dish.Description, ID = dish.ID, Name = dish.Name, Price = dish.Price });
                                added = true;
                                break;
                            }
                        }
                        if (!added)
                        {
                            changedList.Add(new Dish() { Amount = 0, Category = item.Category, Description = item.Description, ID = item.ID, Name = item.Name, Price = item.Price });
                        }
                    }
                    foreach (var dishItem in changedList)
                    {
                        OrderItems.Add(new OrderItem(dishItem, useDefaultAmount: true));
                    }
                }
                MenuItemList.Controls.AddRange(OrderItems.ToArray());
            }
        }

        private void FillUIWithOrderData()
        {
            var temp = Enum.GetNames(typeof(Category));
            var res = (temp as string[]).ToList();
            res.RemoveAt(0);
            CategoryCB.DataSource = res;
            CategoryCB.SelectedItem = null;
            CategoryCB.Text = "Selecteer...";
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
                        OrderItems.Add(new OrderItem(new Dish() { Amount = dish.Amount, Category = dish.Category, Description = dish.Description, ID = dish.ID, Name = dish.Name, Price = dish.Price }, useDefaultAmount: true));
                    }
                    MenuItemList.Controls.AddRange(OrderItems.ToArray());
                    decimal total = CurrentOrder.GetTotal();
                    TotalLbl.Text = "Totaal: \t€ " + total;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pageClose?.Invoke(this);
        }

        private void SaveOrderBtn_Click(object sender, EventArgs e)
        {

            var res = CurrentOrder.Reservation;
            if (MenuItemList.Controls == null || MenuItemList.Controls.Count == 0)
            {
            }
            else
            {
                var dishes = OrderItems.Select(a => a.DishItem).Where(d => d.Amount > 0).ToList();
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
                    var tempRes = DataStorageHandler.Storage.Reservations.FirstOrDefault(r => r.ID == res.ID);
                    if (tempRes != null)
                    {
                        var order = tempRes.Orders.FirstOrDefault(o => o.ID == CurrentOrder.ID);
                        if (order != null)
                        {
                            order = CurrentOrder;
                            decimal total = CurrentOrder.GetTotal();
                            TotalLbl.Text = "Totaal: \t€ " + total;
                        }
                        else
                        {
                            MessageBox.Show("Bestelling kon niet worden opgeslagen:\nDataStorage doesn't contain current Order, can mean corrupt data.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bestelling kon niet worden opgeslagen:\nDataStorage doesn't contain current Reservation, can mean corrupt data.");
                    }
                    MessageBox.Show("Bestelling is opgeslagen");
                    EditMode(false);
                }
            }
        }

        private void PaymentBtn_Click(object sender, EventArgs e)
        {
            var tempRes = DataStorageHandler.Storage.Reservations.FirstOrDefault(r => r.ID == CurrentOrder.Reservation.ID);
            if (tempRes != null)
            {
                var order = tempRes.Orders.FirstOrDefault(o => o.ID == CurrentOrder.ID);
                if (order != null)
                {
                    Form form = new PaymentOption(order);
                    form.Show();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CategoryCB.SelectedItem = null;
            CategoryCB.Text = "Selecteer...";
            MenuItemList.Controls.Clear();
            MenuItemList.Controls.AddRange(OrderItems.ToArray());
        }

        private void CategoryCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategoryCB.SelectedItem != null)
            {
                if (Enum.TryParse(CategoryCB.SelectedValue.ToString(), out Category cat))
                {
                    CurrentFilter = cat;
                    MenuItemList.Controls.Clear();

                    MenuItemList.Controls.AddRange(OrderItems.Where(o => o.DishItem.Category == cat).ToArray());
                }
            }
        }
    }
}