using System.Diagnostics;
using System.Dynamic;

namespace Question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");
            //Console.WriteLine(args[0]);
            //Console.WriteLine(args[1]);

            int a = int.Parse(args[0]);
            int b = int.Parse(args[1]);
            String operand = args[2];

            switch (operand)
            {
                case "+":
                    Console.WriteLine(a + b);
                    break;

                case "-":Console.WriteLine(a - b);
                    break;

                case "*":
                    Console.WriteLine(a * b);
                    break;
                case "/":
                    Console.WriteLine(a / b);
                    break;

                default:Console.WriteLine("Invalid Argument");
                    break;



                

            }

        }
    }
}
