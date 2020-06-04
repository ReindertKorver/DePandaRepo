using DePandaLib.Entities;
using System;
using PdfSharp.Drawing;
using DePandaLib.DAL;
using PdfSharp.Pdf;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;

namespace DePandaWinForms.Pages.OrderPage
{
    public partial class PaymentOption : Form
    {
        public Order CurrentOrder;
        public string TotalOrderAmount;
        public PaymentOption(Order CurrentOrder)
        {
            InitializeComponent();
            this.CurrentOrder = CurrentOrder;
            decimal total = CurrentOrder.GetTotal();
            TotalOrderAmount = total.ToString();
            ProgressBar.Location = new Point(6, 41);
            ProgressText.Location = new Point(3, 12);
            ProgressPanel.Location = new Point(306, 159);
        }

        private void PinButton_Click(object sender, EventArgs e)
        {
            Timer.Start();
            Show("Pin");
        }

        private void Show(string Show)
        {
            Question.Visible = false;
            CashButton.Visible = false;
            PinButton.Visible = false;
            if (Show == "Pin")
            {
                ProgressText.Visible = true;
                ProgressBar.Visible = true;
                ProgressPanel.Visible = true;
            }
            if (Show == "Cash")
            {
                CustomerGivesLabel.Visible = true;
                TotalGivenAmountBox.Visible = true;
                ChangeLabel.Visible = true;
                ContactPanel.Visible = true;
                OutPutTextBox.Visible = true;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            if (ProgressBar.Value == 100)
            {
                Timer.Stop();
                MessageBox.Show("Betaling is gelukt");
                CreateDocument();
                this.Close();
               
            }
            else
            {
                ProgressBar.Increment(2);
            }
        }
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        private void TotalGivenAmountBox_TextChanged(object sender, EventArgs e)
        {
            string AmountGivenString = (sender as TextBox).Text;
            string PuntNaarComma = AmountGivenString.Replace(".", ",");
            if (Decimal.TryParse(PuntNaarComma, out decimal CorrectAmountGiven))
            {
                decimal TotalOrder = Decimal.Parse(TotalOrderAmount);
                OutPutTextBox.Text = (TotalOrder - CorrectAmountGiven).ToString();
            }
            else
            {
                (sender as TextBox).Text = "";
            }
        }

        private void CreateDocument()
        {
            // alle rechten voorbehouden voor Reindert.
            var tempRes = DataStorageHandler.Storage.Reservations.FirstOrDefault(r => r.ID == CurrentOrder.Reservation.ID);
            var order = tempRes.Orders.FirstOrDefault(o => o.ID == CurrentOrder.ID);
            order.Paid = true;
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


        private void CashButton_Click(object sender, EventArgs e)
        {
            Show("Cash");
        }

        private void ConfirmCashPayment_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Betaling is gelukt");
            CreateDocument();
            this.Close();
        }
        private void Close_MouseHover(object sender, EventArgs e)
        {
            Close.Image = (!closeHover) ? DePandaWinForms.Properties.Resources.closehover : DePandaWinForms.Properties.Resources.close;
            closeHover = !closeHover;
        }

        private bool closeHover = false;
        private void Close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
