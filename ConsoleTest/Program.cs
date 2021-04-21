using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Text.Json;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Diagnostics;
//#nullable disable
namespace ConsoleTest
{
    
    class Program
    {
enum ee 
{a=321,b=3,c=4}
        public static void Main()
        {
            
     var x=ee.GetNames();
            List<int> ii=new() {10,20,30};
            var e = ii.GetEnumerator();
           System.Console.WriteLine(e.GetType().Name);
            foreach (var i in ii)
            {
               
               // ii.Remove(i);
                // ii.Remove(20);
                 // ii.Remove(30);
                 
                // i=6;
               // ii.Remove(10);
               System.Console.WriteLine(ii.Count);
                 System.Console.WriteLine(i);

            }
             System.Console.WriteLine(ii.Count);
             foreach (var i in ii)
            {
               
            
                 System.Console.WriteLine(i);

            }
           
        }


    }


}