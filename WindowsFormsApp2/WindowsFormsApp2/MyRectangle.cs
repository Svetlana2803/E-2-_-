using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class MyRectangle
    {
        int x = 10;
        int y = 5;
        int w = 100;
        int h = 50;

        public void Draw(Graphics g)
        {
            Pen k = new Pen(Color.Black);
            g.DrawRectangle(k, x, y, w, h);
        }

    }

    
}
