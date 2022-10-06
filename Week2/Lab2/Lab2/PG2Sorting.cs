using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public static class PG2Sorting
    {
        public static List<string> fileReader()
        {
            List<string> comicTitles = null;
            char delimiters = ',';
            string filePath = "inputFile.csv";
            using (StreamReader sr = new StreamReader(filePath))
            {
                string comicRead = File.ReadAllText(filePath);
                string[] ComicArray = comicRead.Split(delimiters);
                List<string> ComicList = ComicArray.ToList();
                for (int i = 0; i < ComicList.Count; i++)
                {
                    comicTitles = ComicList;
                }

            }
            return comicTitles;

        }
        public static void Swap(List<string> comics, int c1, int c2)
        {
            string temp = comics[c1];
            comics[c1] = comics[c2];
            comics[c2] = temp;
        }

        public static List<string> BubbleSort(List<string> original)
        {
            List<string> sorted = original;
            int n = original.Count;
            bool swapComic = true;
            while (swapComic) 
            {
                swapComic = false;
                for (int i = 1; i <= n-1; i++)
                {
                    int compResult = original[i - 1].CompareTo(original[i]);
                    if (compResult == 1)
                    {
                        Swap(original, i-1, i);
                        swapComic = true;
                    }

                }
                n--;
                while(!swapComic)
                {
                    break;
                }


            }

            return sorted;
        }
    }




}
