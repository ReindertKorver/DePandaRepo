using DePandaLib.DAL;
using DePandaLib.Entities;
using DePandaWinForms.Design;
using DePandaWinForms.Pages.OrderPage;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DePandaWinForms.Pages
{
    public partial class OrdersPage : Form
    {
        public Order CurrentOrder;

        public OrdersPage()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LeftPanel.Size = new Size(MainPanel.Width / 3, LeftPanel.Size.Height);
            FillList();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            LeftPanel.Size = new Size(MainPanel.Width / 3, LeftPanel.Size.Height);
            foreach (var control in OrderItemList.Controls)
            {
                OrderItem item = (control as OrderItem);
                item.Size = new Size(OrderItemList.Size.Width - 23, 50);
            }
        }

        public void EditOrder()
        {
            RightEditPanel.Controls.Clear();
            EditOrder editOrder = new EditOrder(ref CurrentOrder, EditOrder_PageClose);
            editOrder.TopLevel = false;
            editOrder.Dock = DockStyle.Fill;
            RightEditPanel.Controls.Add(editOrder);
            editOrder.Show();
        }

        public void NewOrder()
        {
            RightEditPanel.Controls.Clear();

            NewOrder newOrder = new NewOrder(ref CurrentOrder);
            newOrder.TopLevel = false;
            newOrder.Dock = DockStyle.Fill;
            RightEditPanel.Controls.Add(newOrder);
            newOrder.OrderSaved += NewOrder_OrderSaved;
            newOrder.Show();
        }

        public void SearchSelectAllText()
        {
            SearchBox.SelectAll();
        }

        private void CheckOrderAndContinue(Action continueation, Order order)
        {
            if (CurrentOrder != null)
            {
                DialogResult res = MessageBox.Show("U bent al een bestelling aan het aanmaken/wijzigen, wilt u doorgaan zonder op te slaan?", "Let op!", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    CurrentOrder = order;
                    continueation();
                }
            }
            else
            {
                CurrentOrder = order;
                continueation();
            }
        }

        private void EditOrder_PageClose(EditOrder form)
        {
            form.Hide();
            form = null;
            CurrentOrder = null;
            FillList();
        }

        private void FillList()
        {
            List<Order> orders = DataStorageHandler.Storage.GetAllOrders();
            if (orders != null && orders.Count != 0)
            {
                //prevent glitching ui

                List<OrderItem> items = new List<OrderItem>();
                foreach (var order in orders)
                {
                    if (order.OrderDate.Date == DateTime.Today) { 
                    OrderItem item = new OrderItem(order);
                    item.Size = new Size(OrderItemList.Size.Width - 23, 50);
                    item.UseCounter = false;
                    item.ItemSelected += Item_Click;
                    items.Add(item);
                        }
                }

                OrderItemList.Controls.Clear();
                OrderItemList.Controls.AddRange(items.ToArray());
            }
        }

        private void Item_Click(object sender, EventArgs e)
        {
            var order = (sender as OrderItem).Order;
            if (order != null)
            {
                CheckOrderAndContinue(EditOrder, order);
            }
        }

        private void NewOrder_OrderSaved(object sender, EventArgs e)
        {
            var form = ((NewOrder)sender);
            //Clear the listener so the garbagecollector can collect it
            form.OrderSaved -= NewOrder_OrderSaved;
            form.Hide();
            form = null;
            CurrentOrder = null;
            FillList();
        }

        private void NewOrderBtn_Click(object sender, EventArgs e)
        {
            CheckOrderAndContinue(NewOrder, new Order());
        }

        private void SearchBox_Click(object sender, EventArgs e)
        {
            SearchSelectAllText();
        }

        private void SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (SearchBox.Text == "Zoeken...")
                SearchSelectAllText();
        }

        private void SearchBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SearchBox.Text))
            {
                SearchBox.Text = "Zoeken...";
            }
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchBox.Text != "Zoeken...")
            {
                string searchTerm = SearchBox.Text;
                foreach (var control in OrderItemList.Controls)
                {
                    OrderItem item = (control as OrderItem);
                    bool visible = false;
                    if (item.Order != null
                        && item.Order.Reservation != null
                        && item.Order.Reservation.OnTheNameOf != null
                        && item.Order.Reservation.Table != null
                        && item.Order.OrderDate != null)
                    {
                        if (item.Order.Reservation.Table.ToLower().Contains(searchTerm.ToLower())
                            || ("Tafel: " + item.Order.Reservation.Table).ToLower().Contains(searchTerm.ToLower())
                            || item.Order.Reservation.OnTheNameOf.ToLower().Contains(searchTerm.ToLower())
                            || item.Order.OrderDate.ToString("HH:mm").ToLower().Contains(searchTerm.ToLower()))
                        {
                            visible = true;
                        }
                    }
                    item.Visible = visible;
                }
            }
        }
    }
}