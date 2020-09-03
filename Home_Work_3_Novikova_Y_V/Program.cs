using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_3_Novikova_Y_V
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Complex z1 = new Complex(12,34);
            Complex z2 = new Complex(21, 38);

            Complex result = z1.Sum(z2);
            Console.WriteLine("Результом операции сложения чисел: " + z1.ToString() + " и " + z2.ToString() + " является "
                + result.ToString());
  
            result = z1.Minus(z2);
            Console.WriteLine("Результом операции вычитания чисел: " + z1.ToString() + " и " + z2.ToString() + " является "
               + result.ToString());

        }
    }
}
