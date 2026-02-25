using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Даны три различных целых числа. Определить, какое из них (первое, второе или третье):
//а) самое большое; б) самое маленькое; в) является средним (средним назовем число, которое больше наименьшего из данных чисел, но меньше наибольшего).

namespace task1
{

    public class Logic
    {

        public static string Task(int a, int b, int c)
        {
            string message = "";
            if (!(a == b || b == c || c == a))
            {
                message = Logic.Message(a, b, c);
            }
            else
            {
                message = "Числа не разные.";
            }
            return message;
        }

        public static string Message(int a, int b, int c )
        {
            int max1 = Math.Max(a, Math.Max(b, c));
            int min1 = Math.Min(a, Math.Min(b, c));
            string message = "";
            if (max1 == a)
            {
                message = $"Самое большое первое число:{a}. ";
                if (min1 == b)
                {
                    message+= $"Самое минимальное второе число:{b}. Среднее число:{c}";
                }
                else
                {
                    message += $"Самое минимальное третье число:{c}. Среднее число:{b}";
                }
            }
            else if (max1 == b)
            {
                message = $"Самое большое второе число:{b}. ";
                if (min1 == a)
                {
                    message += $"Самое минимальное первое число:{a}. Среднее число:{c}";
                }
                else
                {
                    message += $"Самое минимальное третье число:{c}. Среднее число:{a}";
                }

            }
            else
            {
                message = $"Самое большое третье число:{c}. ";
                if (min1 == a)
                {
                    message += $"Самое минимальное первое число:{a}. Среднее число:{b}";
                }
                else
                {
                    message += $"Самое минимальное второе число:{b}. Среднее число:{a}";
                }
            }
            return message;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Введите последовательно а, b, c: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            string message = Logic.Task( a,  b,  c);
            Console.WriteLine(message);
        }
    }
}