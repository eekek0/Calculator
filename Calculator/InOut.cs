using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class InOut
    {

        public bool DigitCheck(string digit)
        {
            return double.TryParse(digit, out _);
        }

        public string[] Input()
        {
            string[] ops = { "+", "-", "*", "/" };

            string x;
            while (true)
            {
                Console.WriteLine("Введите первое число:");
                x = Console.ReadLine();
                if (DigitCheck(x)) break;
                Console.WriteLine("Ошибка: введите корректное число.");
            }

            string op;
            while (true)
            {
                Console.WriteLine("Введите операцию (+, -, *, /):");
                op = Console.ReadLine();
                if (ops.Contains(op)) break;
                Console.WriteLine("Ошибка: введите одну из операций (+, -, *, /).");
            }

            string y;
            while (true)
            {
                Console.WriteLine("Введите второе число:");
                y = Console.ReadLine();
                if (DigitCheck(y)) break;
                Console.WriteLine("Ошибка: введите корректное число.");
            }

            return new string[] { x, op, y };
        }

        public void Output(string[] init, double result)
        {
            Console.WriteLine($"{init[0]}{init[1]}{init[2]}={result}");
        }
    }
}
