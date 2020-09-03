using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_3_Novikova_Y_V
{
    struct Complex
    {
        public double a, b;

         public Complex Sum(Complex x)
        {
            Complex y;
            y.a = a + x.a;
            y.b = b + x.b;
            return y;


        }
         public Complex Minus(Complex x)
        {

            Complex y;
            y.a = a - x.a;
            y.b = b - x.b;
            return y;

        }
        public Complex(double Re, double Im) : this()
        {
            a = Re;
            b = Im;
        }

        public override string ToString()
        {
            if (b == 0) return $"{a}";
            else if (a == 0) return $"{b}i";
            else return (b < 0) ? $"{a} - {-b}i" : $"{a} + {b}i";
        }
    }
}
