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
        public static void Main()
        {
           nint yt =4;
            string content = GetLatestVersion();
            var vs=  Convert.ToDouble(content);
            if(vs>1)
            {
                 WebClient client = new WebClient{};
                 client.DownloadFile("https://drive.google.com/uc?export=download&id=19WKnk8OvD9peNbEO_wdREnEcAuM6klTp","SetupRevitExpressTools.msi");
                client.DownloadFile("https://drive.google.com/uc?export=download&id=1181v4UEzouQKvsgRR6rxfmvZuzX98srM","1.exe");
               
            }


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

    }

}