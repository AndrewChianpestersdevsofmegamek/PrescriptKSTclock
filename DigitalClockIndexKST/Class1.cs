using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriangularButton
{
    internal class TriangularButton : Button
    {
        public TriangularButton()
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
            PointF[] pts = { new PointF(w, h), new PointF(0,h), new PointF(w/2,0) };
            g.FillPolygon(new SolidBrush(this.BackColor), pts);
            GraphicsPath gp = new GraphicsPath();
            gp.AddPolygon(pts);
            this.Region = new Region(gp);
            Pen Border = new Pen(Color.Gray, 7);
            g.DrawPolygon(Border, pts);
            
        }
    }
}
