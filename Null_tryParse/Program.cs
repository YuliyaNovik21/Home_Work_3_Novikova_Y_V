using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_tryParse
{
    class Program
    {
        static int GetInt()
        {
            while (true)
                if (!int.TryParse(Console.ReadLine(), out int x))
                    Console.Write("Неверный ввод (введите числовое значение).\nПожалуйста, повторите ввод: ");
                else return x;
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Вводите числа по одному, для завершения введите 0: ");

            int Numbers = 0;
            int sum = 0;
            while (true)
            {
                int number = GetInt();
                if (number == 0)
                {
                    break;
                }
                else if ( number % 2 != 0)
                {
                    sum += number;
                    Numbers++;
                }
            }

            Console.WriteLine("Количество чисел: " + Numbers);
            Console.WriteLine("Сумма нечетных чисел: " + sum);
            Console.ReadKey();
        }
    }
}
