using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Text.Json;
using System.ComponentModel.DataAnnotations;

namespace ConsoleTest
{
    
    class Program
    {
        public static void Main()
        {
             List<List<int>> l = new List<List<int>>(){new(){1,2,3}, new(){4,5,6}};
             System.Console.WriteLine(l[1][1]);
        }       
    
    }

}