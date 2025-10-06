using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            InOut io = new InOut();
            Operations math = new Operations();

            while (true)
            {
                Console.WriteLine("\n");
                string[] init = io.Input();

                double x = Convert.ToDouble(init[0]);
                string op = init[1];
                double y = Convert.ToDouble(init[2]);

                double result = 0;

                switch (op)
                {
                    case "+": result = math.Add(x, y); break;
                    case "-": result = math.Sub(x, y); break;
                    case "*": result = math.Mul(x, y); break;
                    case "/": result = math.Div(x, y); break;
                }

                io.Output(init, result);
                Console.WriteLine("Желаете продолжить? Y/N");
                string cont = Console.ReadLine();
                if (cont.Equals("N", StringComparison.OrdinalIgnoreCase))
                    break;
            }
        }
    }
}
