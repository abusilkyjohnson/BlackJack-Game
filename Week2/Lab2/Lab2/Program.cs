using System;
using System.Collections.Generic;
using PG2Input;

namespace Lab2
{

    //
    //------------Lab Notes-------------
    //      Add your Sorting and Searching methods to the PG2Sorting.cs file.
    //      Add any other methods in this file.
    //      Add the menu code to the Main method.
    //

    class Program
    {
        static void Main(string[] args)
        {

            int options = 1;
            string[] sortOr = new string[] { "1. Bubble Sort", "2. Merge Sort", "3. Binary Search", "4. Save", "5. Exit", };
            Input.GetMenuChoice("", sortOr, out options);
            while (options != 7)
            {
                switch(options)
                {
                    case 1:
                        List<string> unsorted = PG2Sorting.fileReader();
                        List<string> bubbled = PG2Sorting.BubbleSort(unsorted);
                        for(int i = 0; i < unsorted.Count; i++)
                        {
                            Console.Write("\n"+ PG2Sorting.fileReader()[i]);
                            Console.CursorLeft = 50;
                            Console.Write(bubbled[i]);
                        }
                        break;
                }    
            }
            

            



        }


    }
}
