using System;
using System.Drawing;
using System.Windows.Forms;

namespace SolarEdgeGagdet
{
    //http://cboard.cprogramming.com/csharp-programming/119414-custom-tooltip.html
    class CustomToolTip : ToolTip
    {
        public CustomToolTip()
        {
            this.OwnerDraw = true;
            this.Popup += new PopupEventHandler(this.OnPopup);
            this.Draw += new DrawToolTipEventHandler(this.OnDraw);
        }

        private void OnPopup(object sender, PopupEventArgs e) // use this event to set the size of the tool tip
        {
            e.ToolTipSize = new Size(8 * ((string)Tag).Length, 25);
            //if ((double)Tag >= 100)
            //    e.ToolTipSize = new Size(100, 25);
            //else
            //    e.ToolTipSize = new Size(80,25);
            
        }

        private void OnDraw(object sender, DrawToolTipEventArgs e) // use this event to customise the tool tip
        {
            Graphics g = e.Graphics;

            g.FillRectangle(Brushes.Black, e.Bounds);

            g.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(0, 131, 255)), 1), new Rectangle(e.Bounds.X, e.Bounds.Y,
                e.Bounds.Width - 1, e.Bounds.Height - 1));

            g.DrawString(e.ToolTipText, new Font(e.Font, FontStyle.Bold), Brushes.White, new PointF(e.Bounds.X + 5, e.Bounds.Y + 5)); // top layer
        }
    }
}
