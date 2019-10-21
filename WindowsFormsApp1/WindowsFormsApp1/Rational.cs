using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Rational
    {
        public int num; //числитель
        public int denom; //знаменатель

        public Rational()
        {

        }

        public Rational (int num, int denom)
        {
            this.num=num;
            this.denom = denom;
         }
        
       public static Rational operator+ (Rational r1, Rational r2) //перегруз для сложения
        {             
            Rational result = new Rational();
            result.denom = r1.denom * r2.denom;
            result.num = r1.num * r2.denom + r2.num * r1.denom;
            return result;
        }

        public static Rational operator- (Rational r1, Rational r2) //перегруз для вычитания
        {
            Rational result = new Rational();
            result.denom = r1.denom * r2.denom;
            result.num = r1.num * r2.denom - r2.num * r1.denom;
            return result;
        }

        public static Rational operator* (Rational r1, Rational r2) //перегруз для умножения
        {
            Rational result = new Rational();
            result.denom = r1.denom * r2.denom;
            result.num = r1.num * r2.num;
            return result;
        }

        public static Rational operator/ (Rational r1, Rational r2) //перегруз для деления
        {
            Rational result = new Rational();
            result.denom = r1.denom * r2.num;
            result.num = r1.num * r2.denom;
            return result;
        }
        
        public override string ToString()
        {
            return Convert.ToString(num) + " / " + Convert.ToString(denom);
        }

        public static void Reduction(ref Rational r) //проверка на деление
        {
            int r1 = r.num;
            int r2 = r.denom;
            while (r2 != 0)
            {
                r2 = r1 % (r1 = r2);
            }

            r.num = r.num / r1;
            r.denom = r.denom / r1;

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
