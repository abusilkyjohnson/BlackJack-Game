using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.FileIO;
using System.Runtime.Intrinsics.X86;
using PG2Input;

namespace Lab1
{

    //
    //------------Lab Notes-------------
    //      Add your Read methods to the Input.cs file in the PG2Input project.
    //      Add any other methods in this file.
    //      Add the menu code to the Main method.
    //

    class Program
    {
        static void Main(string[] args)
        {

            //Part A-8: Menu Loop
            //You will need to create a loop in Main that handles the menu options for lab 1. This 
            //should be a simple while loop that loops while the menu selection is NOT exit. Inside
            //the while loop, you should 1) call GetMenuChoice to show the menu and get the
            //user’s menu selection. 2) use a switch statement that has logic for each menu option.

            int menuChoice = 1;
            string[] mainMenu = new string[] { "1. Taco", "2. Chips", "3. Fish", "4. Exit" };

            while (menuChoice != 4)
            {
                Input.GetMenuChoice("", mainMenu, out menuChoice);
                switch (menuChoice)
                {
                    case 1:
                        Console.WriteLine("Taco");
                        break;
                    case 2:
                        Console.WriteLine("Chips");
                        break ;
                    case 3:
                        Console.WriteLine("Fish");
                        break;
                     
                }break;
            }
            
        }
    }
}
