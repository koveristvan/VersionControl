using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Beadando__Z86RKF
{
    public class House: Label
    {
        public House()
        {
            AutoSize = false;
            Width = 10;
            Height = Width;
            Paint += House_Paint;
        }
        private void House_Paint(object sender, PaintEventArgs e)
        {
            
                DrawImage(e.Graphics);
        }
        protected void DrawImage(Graphics g)
        {
          
                Pen mypen = new Pen(Color.Black);
            //g.DrawRectangle(mypen, 100, 100, Width, Height);
            g.FillEllipse(new SolidBrush(Color.Blue), 100, 100, Width, Height);
        }

    }
}
