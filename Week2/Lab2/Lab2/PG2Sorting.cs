using Newtonsoft.Json;
using PG2Input;
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
            List<string> sorted = original.ToList();
            int n = original.Count;
            bool swapComic = true;
            int counter = 0;
            while (swapComic)
            {
                swapComic = false;
                for (int i = 1; i <= n - 1; i++)
                {
                    int compResult = sorted[i - 1].CompareTo(sorted[i]);
                    if (compResult == 1)
                    {
                        Swap(sorted, i - 1, i);
                        swapComic = true;
                    }
                    counter++;
                }
                n--;
                while (!swapComic)
                {
                    break;
                }


            }
            Console.WriteLine($" The list contains {sorted.Count} element and loops {counter}");
            return sorted;
        }

        public static List<string> MergeSort(List<string> m)
        {
            if (m.Count <= 1)
            {
                return m;
            }

            List<string> left = new List<string>();
            List<string> right = new List<string>();
            int med = (m.Count) / 2;

            for (int i = 0; i < m.Count; i++)
            {
                if (i < med)
                {
                    left.Add(m[i]);
                }
                else
                {

                    right.Add(m[i]);

                }
                left = MergeSort(left);
                right = MergeSort(right);

            }
            return Merge(left, right);
        }

        public static List<string> Merge(List<string> left, List<string> right)
        {
            List<string> result = new List<string>();
            while (left.Count != 0 && right.Count != 0)
            {
                if (left.First().CompareTo(right.First()) <= 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else
                {
                    result.Add(right.First());
                    right.Remove(right.First());
                }

            }
            while (left.Count != 0)
            {
                result.Add(left.First());
                left.Remove(left.First());

            }
            while (right.Count != 0)
            {
                result.Add(right.First());
                right.Remove(right.First());

            }

            return result;
        }

        public static int BinarySearch(List<string> comics,string searchTerm, int low, int high, ref int call)
        {
            call++;
            if (high < low)
            {
                call = 1;
                return -1;
            }
            int mid = (high + low) / 2;
            int comicComparison = searchTerm.CompareTo(comics[mid]);
            if ( comicComparison < 0)
            {
                return BinarySearch(comics, searchTerm, low, mid -1, ref call);
            }
            else if (comicComparison > 0)
            {
                return BinarySearch(comics, searchTerm,mid + 1, high, ref call);

            }
            else
            {
                return mid;
            }    
        }

        public static void SaveJson(List<string> jsonUN)
        {
            string file = "";
            string holder = "The name of the save file ?";
            Input.GetString(holder, ref file);
            

            file = Path.ChangeExtension(file, ".json");
            using(StreamWriter sw = new StreamWriter(file))
            {
                using (JsonTextWriter jtw = new JsonTextWriter(sw))
                {
                    jtw.Formatting = Formatting.Indented;
                    JsonSerializer jsonSerializer = new JsonSerializer();
                    jsonSerializer.Serialize(jtw, jsonUN);
                }
            }
            
        }
    }




}
