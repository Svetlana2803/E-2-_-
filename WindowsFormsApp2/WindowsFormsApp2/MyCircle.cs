using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class MyCircle
    {
        int x = 200;
        int y = 200;
        int rad = 60;

        public void Draw(Graphics s)
        {
            Pen kl = new Pen(Color.Black);
            s.DrawEllipse(kl, x - rad, y - rad, 2 * rad, 2 * rad);
        }
    }
}
