using System;

namespace Day01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor backColor;
            RandomColor(out backColor);
            int sum = 0;
            int factor = Factor(3, ref sum);// b/c of ref when we reference it again that variable sum can change
            Console.WriteLine($" 3 * {factor} = {sum}");


            int x1 = 0;
            int y2 = 0;
            //for (int i = 0; i < 20; i++)
            while(true)
            {
                RandomColor(out backColor);
                RandomPosition(ref x1, ref y2);
                DrawBlock(x1, y2, backColor);
                Factor(x1);//though factor took in two one of the was optional and would defualt to the option we gave it 
            }
            RandomPosition(ref x1, ref y2);
            Console.ReadKey();
        }
        static bool IntTryParse(string input, out int number)
        {
            bool isANumber = false;
            number = 0;
            // int.tryParse is a bool that return a 0 for false if what put in is not an int
            //use try-catch to handle excepetion for parse
            try
            {
                number = int.Parse(input);
            }
            catch(Exception)// This will catch it 
            {
                //can tell the program what we want it to do then
                Console.WriteLine("error");
            }
            return isANumber;
        }
        
        static int Factor(int num, int factor = 2)// The equal say we will take a second paramenter but if we dont pass it in we can take 2
        {
            return num * factor;
        }
        
        // creat a method to randomly generate a color
        // use an out parameter
        // call it in DrawBlock to change the color of the block
        static void RandomColor(out ConsoleColor color)
        {
            Random random = new Random();

            color = (ConsoleColor)random.Next(16);
        }

        static int Factor(int num, ref int result)// now it will change value of the ref variable
        {
            Random random = new Random();
            int factor = random.Next(10); 
            result = num * factor;
            return factor;
        }

        static void RandomPosition(ref int x, ref int y)
        {
            Random random = new Random();
             x = random.Next(Console.WindowHeight);
            y = random.Next(Console.WindowWidth);
        }
        static void DrawBlock(int x, int y, ConsoleColor color = ConsoleColor.Magenta)
        {
            //int x = Console.WindowWidth / 2;
            //int y = Console.WindowHeight / 2;

            Console.SetCursorPosition(x, y);
            ConsoleColor backColor;
            RandomColor(out backColor);
            Console.BackgroundColor = color;

            Console.Write("     ");

            Console.ResetColor();
        }

    }
}
