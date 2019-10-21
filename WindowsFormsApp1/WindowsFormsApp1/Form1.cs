using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void plus_Click_1(object sender, EventArgs e) //кнопка сложения
        {
            Rational r1 = new Rational();
            Rational r2 = new Rational();
            Rational answer = new Rational();

            r1.num = Convert.ToInt32(numerator1.Text);
            r1.denom = Convert.ToInt32(denomerator1.Text);

            r2.num = Convert.ToInt32(numerator2.Text);
            r2.denom = Convert.ToInt32(denomerator2.Text);

            if (denomerator1.Text == "0" || denomerator2.Text == "0")
            {
                MessageBox.Show("Ошибочка,а как бы на ноль делить нельзя");
            }


            answer = r1 + r2;

            Rational result = answer;
            resl.Text = result.ToString();
        }

        private void minus_Click(object sender, EventArgs e) //кнопка вычитания
        {
            Rational r1 = new Rational();
            Rational r2 = new Rational();
            Rational answer = new Rational();

            r1.num = Convert.ToInt32(numerator1.Text);
            r1.denom = Convert.ToInt32(denomerator1.Text);

            r2.num = Convert.ToInt32(numerator2.Text);
            r2.denom = Convert.ToInt32(denomerator2.Text);

            if (denomerator1.Text == "0" || denomerator2.Text == "0")
            {
                MessageBox.Show("Ошибочка,а как бы на ноль делить нельзя");
            }

            answer = r1 - r2;

            Rational result = answer;
            resl.Text = result.ToString();
        }

        private void multiplication_Click(object sender, EventArgs e) //кнопка умножения
        {
            Rational r1 = new Rational();
            Rational r2 = new Rational();
            Rational answer = new Rational();

            r1.num = Convert.ToInt32(numerator1.Text);
            r1.denom = Convert.ToInt32(denomerator1.Text);

            r2.num = Convert.ToInt32(numerator2.Text);
            r2.denom = Convert.ToInt32(denomerator2.Text);

            if (denomerator1.Text == "0" || denomerator2.Text == "0")
            {
                MessageBox.Show("Ошибочка,а как бы на ноль делить нельзя");
            }

            answer = r1 * r2;

            Rational result = answer;
            resl.Text = result.ToString();
        }

        private void division_Click(object sender, EventArgs e) //кнопка деления
        {
            Rational r1 = new Rational();
            Rational r2 = new Rational();
            Rational answer = new Rational();

            r1.num = Convert.ToInt32(numerator1.Text);
            r1.denom = Convert.ToInt32(denomerator1.Text);

            r2.num = Convert.ToInt32(numerator2.Text);
            r2.denom = Convert.ToInt32(denomerator2.Text);

            if (denomerator1.Text == "0" || denomerator2.Text == "0")
            {
                MessageBox.Show("Ошибочка,а как бы на ноль делить нельзя");
            }

            answer = r1 / r2;

            Rational result = answer;
            resl.Text = result.ToString();
        }

        private void clear_Click(object sender, EventArgs e) //кнопка очистки
        {
            numerator1.Text = "";
            numerator1.Clear();
            denomerator1.Clear();
            numerator2.Clear();
            denomerator2.Clear();
            resl.Clear();
        }

        //public void Reduction(ref Rational r) //проверка на деление
        //{
        //    int r1 = r.num;
        //    int r2 = r.denom;
        //    while (r2 != 0)
        //    {
        //        r2 = r1 % (r1 = r2);
        //    }

        //    r.num = r.num / r1;
        //    r.denom = r.denom / r1;

        //}

    }
}
