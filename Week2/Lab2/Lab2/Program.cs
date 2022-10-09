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
            while (options != 7)
            {
                Input.GetMenuChoice("", sortOr, out options);
                switch (options)
                {
                    case 1:
                        //MUST Print total items in list and how it looks
                        //fix the way it present after it shows up 
                        List<string> unsorted = PG2Sorting.fileReader();
                        List<string> bubbled = PG2Sorting.BubbleSort(unsorted);
                        for (int i = 0; i < unsorted.Count; i++)
                        {
                            Console.Write("\n" + unsorted[i]);
                            Console.CursorLeft = 50;
                            Console.Write(bubbled[i]);
                        }
                        break;


                    case 2:
                        List<string> originalL = PG2Sorting.fileReader();
                        List<string> merger = PG2Sorting.MergeSort(originalL);
                        for (int i = 0; i < originalL.Count; i++)
                        {
                            Console.Write("\n" + originalL[i]);
                            Console.CursorLeft = 50;
                            Console.Write(merger[i]);
                        }
                        break;
                    case 3:

                        break;

                    case 4:
                        break;

                    case 5:
                        break;
                }
            }






        }


    }
}
