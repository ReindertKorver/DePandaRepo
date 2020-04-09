using DePandaWinForms.Pages;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DePandaWinForms
{
    public partial class Form1 : Form
    {
        public Form1(FormWindowState PreviousWinState)
        {
            InitializeComponent();
           
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.CenterToScreen();
            this.WindowState = PreviousWinState;
            this.KeyPreview = true; // shortcuts
           
            
        }

        private void Close_MouseHover(object sender, EventArgs e)
        {
            Close.Image = (!closeHover) ? DePandaWinForms.Properties.Resources.closehover : DePandaWinForms.Properties.Resources.close;
            closeHover = !closeHover;
        }

        private bool closeHover = false;
        private bool maxHover = false;
        private bool minHover = false;
    

        private void Maximize_MouseHover(object sender, EventArgs e)
        {
            Maximize.Image = (!maxHover) ? DePandaWinForms.Properties.Resources.maxhover : DePandaWinForms.Properties.Resources.max;
            maxHover = !maxHover;
        }

        private void Minimize_MouseHover(object sender, EventArgs e)
        {
            Minimize.Image = (!minHover) ? DePandaWinForms.Properties.Resources.minhover : DePandaWinForms.Properties.Resources.min;
            minHover = !minHover;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
     
        private void ChangeWinState()
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }

            
            if (page == "instellingen")
            {
                form = new SettingsPage(this.WindowState);
                form.TopLevel = false;
                
                form.Size = new Size(PagePanel.Size.Width, PagePanel.Size.Height);
                PagePanel.Controls.Clear();
                PagePanel.Controls.Add(form);
                form.Show();
            }



        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #region Code for dragging window and showing shadow

        private const int cGrip = 16;      // Grip size
        private const int cCaption = 32;   // Caption bar height;

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
            rc = new Rectangle(0, 0, this.ClientSize.Width, cCaption);
            e.Graphics.FillRectangle(Brushes.DarkBlue, rc);
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
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

        #endregion Code for dragging window and showing shadow

        

        private void label2_Click(object sender, EventArgs e)
        {
        }
       

        private Form form = null;
        private string page = "none";

        public void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            page = "none";
            switch (e.Item.Text)
            {
                case "Menu":
                    form = new MenuPage();   
                    break;

                case "Reserveringen":
                    form = new ReservationPage();                
                    break;

                case "Bestellingen":
                    form = new OrdersPage();
                    break;

                case "Betalingen":
                    form = new PaymentPage();
                    break;

                case "Instellingen":
                    form = new SettingsPage(this.WindowState);
                    page = "instellingen";
                    break;
                default:
                    break;
            }
            if (form != null)
            {
                
                form.TopLevel = false;
                form.AutoScroll = true;
                form.Size = new Size(PagePanel.Size.Width, PagePanel.Size.Height);
                PagePanel.Controls.Clear();
                PagePanel.Controls.Add(form);
                form.Show();
            }
        }

        public void Maximize_Click(object sender, EventArgs e)
        {  
            ChangeWinState();
        }
        private void KeyBindFullScreen(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.F)
            {
                ChangeWinState();
            }
        }
        private void panel3_Click(object sender, EventArgs e)
        {
            this.Hide();

            new Login(this.WindowState).Show();
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}