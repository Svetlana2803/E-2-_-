using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics g;

        List<MyRectangle> rects = new List<MyRectangle>();
        List<MyCircle> cercls = new List<MyCircle>();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)//нарисовать прямоугольник
        {
            MyRectangle r = new MyRectangle();
            g = CreateGraphics();
            rects.Add(r);
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (MyRectangle r in rects)
            {
                r.Draw(g);
            }

            foreach (MyCircle c in cercls)
            {
                c.Draw(g);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyCircle c = new MyCircle();
            g = CreateGraphics();
            cercls.Add(c);
            Refresh();
        }
    }
}
