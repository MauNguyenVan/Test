#region NameSpace
using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.ComponentModel;
using System.Numerics;
using System.Text;
using System.IO;
using System.Media;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;
using System.Diagnostics.CodeAnalysis;
#endregion
#nullable enable

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // path to the csv file
            string path = "test.csv";

            string[] lines = System.IO.File.ReadAllLines(path);
            foreach (string line in lines)
            {
                string[] columns = line.Split(',');
                foreach (string column in columns)
                {
                    System.Console.Write(column+"\t");
                }
                System.Console.WriteLine(Environment.TickCount);
            }
        }

    }
}
