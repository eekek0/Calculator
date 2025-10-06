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
                Console.WriteLine();
                var init = io.Input();

                double result = 0;

                switch (init.op)
                {
                    case "+": result = math.Add(init.x, init.y); break;
                    case "-": result = math.Sub(init.x, init.y); break;
                    case "*": result = math.Mul(init.x, init.y); break;
                    case "/": result = math.Div(init.x, init.y); break;
                }
                if(double.IsNaN(result))
                    Console.WriteLine($"{init.x} {init.op} {init.y} = inf");
                else
                    io.Output(init, result);
                Console.WriteLine("Желаете продолжить? Y/N");
                string cont = Console.ReadLine();
                if (cont.Equals("N", StringComparison.OrdinalIgnoreCase))
                    break;
            }
        }
    }
}
