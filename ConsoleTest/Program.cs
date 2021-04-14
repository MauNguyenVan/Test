using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Text.Json;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace ConsoleTest
{

    class Program
    {
        private const string uriTextVersion = "https://drive.google.com/drive/folders/10KUAF7nrogEtV8v2jLCDO9uJ8UlXbJG0";

        public static void Main()
        {
         WebClient client = new WebClient();
         //client.DownloadFile(uriTextVersion,"dfdfdf.txt");
         var s = client.DownloadString(uriTextVersion);
         System.Console.WriteLine(s);
        }

    }
    static class dsds
    {
        string Data(this MyClass instance)
    }

}