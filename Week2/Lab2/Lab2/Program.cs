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
            while (options != 7)
            {
  
                Input.GetMenuChoice("", sortOr, out options);
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
                        List<string> comicList = PG2Sorting.fileReader();
                        List<string> cloneComic = PG2Sorting.MergeSort(comicList.ToList());
                        string term = string.Empty;
                        int high = cloneComic.Count - 1;
                        int callC = 0;
                        for (int i = 0; i < cloneComic.Count; i++)
                        {
                            int indexC = cloneComic.IndexOf(cloneComic[i]);
                            Console.Write("\n" + cloneComic[i]);
                            Console.CursorLeft = 43;
                            Console.Write($"Index Found: {PG2Sorting.BinarySearch(cloneComic, term, 0, high, ref callC)}");
                            Console.CursorLeft = 60;
                            Console.Write("Index:" + indexC);
                            Console.CursorLeft = 80;
                            Console.Write("Method Call:"+ callC);

                        }
                        break;

                    case 4:
                        string file = "";
                        List<string> c4Un = PG2Sorting.fileReader();
                        List<string> c4Sort = PG2Sorting.MergeSort(c4Un.ToList());
                        Input.GetString("The name of the save file ?", ref file);
                        PG2Sorting.SaveJson(c4Sort);
                        
                        break;

                    case 5:
                        break;
                }
            }






        }


    }
}
