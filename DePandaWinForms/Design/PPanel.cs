using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DePandaWinForms.Design
{
    public class PPanel : Panel
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillRoundedRectangle(new SolidBrush(Color.FromArgb(235, 235, 235)), 1, 1, this.Width - 1, this.Height - 1, 15);
            //    SolidBrush brush = new SolidBrush(
            //        Color.White
            //        );
            //    g.FillRoundedRectangle(brush, 12, 12, this.Width - 44, this.Height - 64, 10);
            //    g.DrawRoundedRectangle(new Pen(ControlPaint.Light(Color.White, 0.00f)), 12, 12, this.Width - 44, this.Height - 64, 10);
            //    g.FillRoundedRectangle(new SolidBrush(Color.White), 12, 12 + ((this.Height - 64) / 2), this.Width - 44, (this.Height - 64) / 2, 10);
        }
    }
}