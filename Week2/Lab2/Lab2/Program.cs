using System;
using System.Collections.Generic;
using System.Linq;
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
            List<string> Fvariable = PG2Sorting.fileReader();
            while (options != 5)
            {
  
                Input.GetMenuChoice("", sortOr, out options);
                Console.Clear();
                switch (options)
                {
                    case 1:
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
                        Fvariable.Sort();
                        int high = Fvariable.Count;
                        int callC = 0;
                        foreach (string s in Fvariable)
                        {
                            int indexC = Fvariable.IndexOf(s);
                            Console.Write("\n" + s);
                            Console.CursorLeft = 43;
                            Console.Write("Index: " + indexC);
                            Console.CursorLeft = 60;
                            Console.Write($"Index Found: {PG2Sorting.BinarySearch(Fvariable, s, 0, high, ref callC)}");
                            Console.CursorLeft = 80;
                            Console.Write("Method Call: " + callC);
                        }
                        break;

                    case 4:
                        List<string> c4Un = new (Fvariable);
                        PG2Sorting.SaveJson(PG2Sorting.MergeSort(c4Un));
                        
                        break;


                }
                Console.ReadLine();
                Console.Clear();
            }






        }


    }
}
