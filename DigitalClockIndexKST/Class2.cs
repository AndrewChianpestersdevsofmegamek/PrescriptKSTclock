using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpsideDownTriangularButton
{
    internal class UpsideDownTriangularButton : Button
    {
        public UpsideDownTriangularButton()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                      ControlStyles.UserPaint |
                      ControlStyles.ResizeRedraw |
                      ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            float h = this.Height;
            float w = this.Width;
            PointF[] pts = { new PointF(0, 0), new PointF(w, 0), new PointF(w / 2, h) };
            g.FillPolygon(new SolidBrush(this.BackColor), pts);
            GraphicsPath gp = new GraphicsPath();
            gp.AddPolygon(pts);
            this.Region = new Region(gp);
            Pen Border = new Pen(Color.Gray, 7);
            g.DrawPolygon(Border, pts);

        }
    }
}

