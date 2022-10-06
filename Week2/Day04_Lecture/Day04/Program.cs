using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Day04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fpath = "num.txt";
            WriteData(fpath);



        }

        static void WriteData(string filePath)
        {
            List<int> num = new List<int>() {5,12,42, 13 };
            char delimter = ':';
            bool isFirst = true;
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                for (int i = 0; i < num.Count; i++)
                {
                    if (!isFirst)
                        sw.Write(delimter);
                    sw.Write(num[i]);
                    isFirst = false;
                }

            }
        }
    }
}
