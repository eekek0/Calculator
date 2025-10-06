namespace Calculator
{
    public class InOut
    {
        private double ReadNumber(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();

                if (double.TryParse(input, out double value))
                    return value;

                Console.WriteLine("Ошибка: введите корректное число.");
            }
        }

        private string ReadOperator(string[] ops)
        {
            while (true)
            {
                Console.WriteLine("Введите операцию (+, -, *, /): ");
                string op = Console.ReadLine();
                if (ops.Contains(op))
                    return op;

                Console.WriteLine("Ошибка: введите одну из операций (+, -, *, /).");
            }
        }

        public (double x, string op, double y) Input()
        {
            string[] ops = { "+", "-", "*", "/" };

            double x = ReadNumber("Введите первое число: ");
            string op = ReadOperator(ops);
            double y = ReadNumber("Введите второе число: ");

            return (x, op, y);
        }

        public void Output((double x, string op, double y) init, double result)
        {
            Console.WriteLine($"{init.x} {init.op} {init.y} = {result}");
        }
    }
}
