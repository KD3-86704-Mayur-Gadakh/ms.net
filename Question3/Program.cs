namespace Question3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int a = int.Parse(args[0]);
            int b = int.Parse(args[1]);
            String operand = args[2];
            int c=int.Parse(args[3]);
            do
            {
                switch (operand) {

                    case "+":
                        Console.WriteLine(a+b);
                        break;
                        case "-":
                        Console.WriteLine(a-b);
                        break;
                        case "*":
                        Console.WriteLine(a*b);
                        break;
                        case "/":
                        Console.WriteLine(a/b);
                        break;
                }

            }while (c!=0);
            
        }
    }
}
