using System;

namespace Day01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int factor = Factor(3, ref sum);// b/c of ref when we reference it again that variable sum can change
            Console.WriteLine($" 3 * {factor} = {sum}");
            Console.ReadKey();
        }

        static int Factor(int num, ref int result)// now it will change value of the ref variable
        {
            Random random = new Random();
            int factor = 3; 
            result = num * factor;
            return factor;
        }

        static void DrawBlock(int x, int y)
        {
            //int x = Console.WindowWidth / 2;
            //int y = Console.WindowHeight / 2;

            Console.SetCursorPosition(x, y);
            Console.BackgroundColor = ConsoleColor.DarkCyan;

            Console.Write("     ");

            Console.ResetColor();
        }

    }
}
