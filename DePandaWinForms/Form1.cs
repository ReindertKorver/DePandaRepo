﻿using DePandaWinForms.DAL;
using DePandaWinForms.Entities;
using DePandaWinForms.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DePandaWinForms
{
    public partial class Form1 : Form
    {
        private FormDataProvider startScreen = new Login();

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            startScreen.Init();
            startScreen.Navigator.PageBound += Navigator_PageBound;
            startScreen.Navigator.PushNextPage(startScreen);
        }

        private void Navigator_PageBound(object sender, EventArgs e)
        {
            FormDataProvider form = ((FormEventArgs)e).form;
            form.TopLevel = false;
            form.AutoScroll = true;
            form.Location = new Point((PagePanel.Size.Width / 2) - (form.Size.Width / 2), 0);
            PagePanel.Controls.Clear();
            PagePanel.Controls.Add(form);
            form.Show();
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

        private void Maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
            foreach (Control ctrl in PagePanel.Controls)
            {
                ctrl.Location = new Point((PagePanel.Size.Width / 2) - (ctrl.Size.Width / 2), 0);
            }
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;
            }
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

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            FormDataProvider myForm = new Test();
            startScreen.Navigator.PushNextPage(myForm);
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            startScreen.Navigator.PushNextPage(startScreen);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startScreen.Navigator.PopPage();
        }
    }
}