using System;
namespace Calculator
{
    class Program2

    {
        static int result;
        static int Sum(int x, int y) => x + y;
        static int Sub(int x, int y) => x - y;
        static int Mul(int x, int y) => x * y;
        static int Div(int x, int y) => x / y;

        static void Main(string[] args)
        {

            Console.WriteLine("Enter the first number");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int y = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the first operator");
            char op = char.Parse(Console.ReadLine());
            switch (op)
            {
                case '+': result = Sum(x, y); break;
                case '-': result = Sub(x, y); break;
                case '*': result = Mul(x, y); break;
                case '/': result = Div(x, y); break;
            }
            Console.WriteLine(result);
            Console.ReadLine();
            while (true)
            {
                Console.WriteLine("Enter the  next operator");
                char nextop = char.Parse(Console.ReadLine());
                Console.WriteLine("Enter the  next number");
                int z= Int32.Parse(Console.ReadLine());
                switch (nextop)
                {
                    case '+': result = Sum(result, z); break;
                    case '-': result = Sub(result,z); break;
                    case '*': result = Mul(result,z); break;
                    case '/': result = Div(result ,z); break;
                }
                Console.WriteLine(result);
                Console.ReadLine();
            } 
        }
    }
}