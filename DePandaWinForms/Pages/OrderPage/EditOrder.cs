using DePandaClassLib.Entities;
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
                        OrderItem item = new OrderItem(dish, useDefaultAmount: true);
                        MenuItemList.Controls.Add(item);
                    }
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
                    var tempRes = DataStorageHandler.Storage.Reservations.FirstOrDefault(r => r.ID == res.ID);
                    if (tempRes != null)
                    {
                        var order = tempRes.Orders.FirstOrDefault(o => o.ID == CurrentOrder.ID);
                        if (order != null)
                        {
                            order = CurrentOrder;
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
                    PdfDocument pdfDocument = new PdfDocument();
                    pdfDocument.Info.Title = "DePanda_" + tempRes.OnTheNameOf + "_" + order.OrderDate.ToString("ddMMyyyy_HHmm");

                    PdfPage page1 = pdfDocument.AddPage();
                    XGraphics gfx = XGraphics.FromPdfPage(page1);

                    XFont font = new XFont("Verdana", 20, XFontStyle.BoldItalic);

                    gfx.DrawString("De Panda", font, XBrushes.Black, new XRect(20, 20, page1.Width, 30), XStringFormats.TopLeft);

                    XFont font1 = new XFont("Verdana", 15, XFontStyle.Bold);
                    gfx.DrawString("Bon", font1, XBrushes.Black, new XRect(20, 50, page1.Width, 30), XStringFormats.TopLeft);
                    XFont font2 = new XFont("Verdana", 12, XFontStyle.Regular);

                    gfx.DrawString("Tafel: " + tempRes.Table, font2, XBrushes.Black, new XRect(20, 75, page1.Width, 30), XStringFormats.TopLeft);
                    gfx.DrawString("Datum: " + order.OrderDate.ToString("dd-MM-yyyy HH:mm"), font2, XBrushes.Black, new XRect(20, 100, page1.Width, 30), XStringFormats.TopLeft);
                    gfx.DrawString("Reserveer datum: " + tempRes.Date.ToString("dd-MM-yyyy HH:mm"), font2, XBrushes.Black, new XRect(20, 125, page1.Width, 30), XStringFormats.TopLeft);
                    gfx.DrawString("Reserveerder: " + tempRes.OnTheNameOf, font2, XBrushes.Black, new XRect(20, 150, page1.Width, 30), XStringFormats.TopLeft);
                    gfx.DrawString("Aantal personen: " + tempRes.AmountOfPeople, font2, XBrushes.Black, new XRect(20, 175, page1.Width, 30), XStringFormats.TopLeft);
                    gfx.DrawString("Specificaties: " + (string.IsNullOrEmpty(tempRes.Specifications) ? "Geen" : tempRes.Specifications), font2, XBrushes.Black, new XRect(20, 200, page1.Width, 30), XStringFormats.TopLeft);

                    gfx.DrawString("Bestelitems:", font1, XBrushes.Black, new XRect(20, 225, page1.Width, 30), XStringFormats.TopLeft);

                    var startpos = 230;
                    for (int i = 0; i < order.Dishes.Count; i++)
                    {
                        gfx.DrawString(order.Dishes[i].Name, font2, XBrushes.Black, new XRect(25, (15 * (i + 1)) + startpos, page1.Width, 30), XStringFormats.TopLeft);
                        gfx.DrawString("€ " + order.Dishes[i].Price.ToString() + " p/s", font2, XBrushes.Black, new XRect(-175, (15 * (i + 1)) + startpos, page1.Width, 30), XStringFormats.TopRight);
                        gfx.DrawString("x" + order.Dishes[i].Amount, font2, XBrushes.Black, new XRect(-125, (15 * (i + 1)) + startpos, page1.Width, 30), XStringFormats.TopRight);
                        gfx.DrawString("€ " + order.Dishes[i].Amount * order.Dishes[i].Price, font2, XBrushes.Black, new XRect(-50, (15 * (i + 1)) + startpos, page1.Width, 30), XStringFormats.TopRight);
                    }
                    gfx.DrawString("TOTAAL:", font2, XBrushes.Black, new XRect(-125, (15 * (order.Dishes.Count + 2)) + startpos, page1.Width, 30), XStringFormats.TopRight);
                    gfx.DrawString("€ " + order.GetTotal().ToString(), font2, XBrushes.Black, new XRect(-50, (15 * (order.Dishes.Count + 2)) + startpos, page1.Width, 30), XStringFormats.TopRight);

                    string filename = "DePanda_" + tempRes.OnTheNameOf + "_" + order.OrderDate.ToString("ddMMyyyy_HHmm") + ".pdf";
                    pdfDocument.Save(filename);
                    Process.Start(filename);
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
    }
}