using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Text.Json;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Diagnostics;

namespace ConsoleTest
{

    class Program
    {
        private const string uriTextVersion = "https://drive.google.com/drive/folders/10KUAF7nrogEtV8v2jLCDO9uJ8UlXbJG0";

        public static void Main()
        {
           nint yt =4;
            string content = GetLatestVersion();
            var vs=  Convert.ToDouble(content);
            if(vs>1)
            {
                 WebClient client = new WebClient{};
                 //client.DownloadFile("https://drive.google.com/uc?export=download&id=19WKnk8OvD9peNbEO_wdREnEcAuM6klTp","SetupRevitExpressTools.msi");
               // client.DownloadFile("https://drive.google.com/uc?export=download&id=1181v4UEzouQKvsgRR6rxfmvZuzX98srM","1.exe");
               
            }
string s = "Revit 2020";
     KillApplication(s);
            Console.WriteLine(content);
        }
        public static string GetLatestVersion()
        {
            string latestVersion = string.Empty;

            try
            {

                    WebClient client = new WebClient
                    {
                        Encoding = Encoding.UTF8
                    };
                    string reply = client.DownloadString("https://drive.google.com/uc?export=download&id=1i-BeOoS7bljmU1DGLUh7RJJZxjJcW9Da");
                return reply;
            }
            catch (Exception)
            {
            }

            return latestVersion;
        }
        
       
        public static void KillApplication(string names)
        {
            System.Diagnostics.Process[] procs = null;

            try
            {
                procs = Process.GetProcessesByName(names);
foreach (var item in procs)
{
    System.Console.WriteLine(item.MachineName);
}
                // Process mspaintProc = procs[0];

                // if (!mspaintProc.HasExited)
                // {
                //     mspaintProc.Kill();
                // }
            }
            finally
            {
                if (procs != null)
                {
                    foreach (Process p in procs)
                    {
                        p.Dispose();
                    }
                }
            }
        }

    }
    

}