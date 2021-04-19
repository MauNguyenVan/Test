using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Text.Json;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Diagnostics;
using System.Threading;
using System.ComponentModel;

namespace ConsoleTest
{

    class Program
    {
        private const string uriTextVersion = "https://drive.google.com/drive/folders/10KUAF7nrogEtV8v2jLCDO9uJ8UlXbJG0";


        public void  Main()
        {
            // Process.Start()
            ListProcesses();

            string content = GetLatestVersion();
            var vs = Convert.ToDouble(content);
            if (vs > 1)
            {
              WebClient  webClient = new WebClient();
                // webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(Wc_DownloadProgressChanged);
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Wc_DownloadFileCompleted);

                    Uri uri = new Uri("https://drive.google.com/uc?export=download&id=19WKnk8OvD9peNbEO_wdREnEcAuM6klTp");
                    Thread thread = new Thread(() => { webClient.DownloadFileAsync(uri, "setup.msi"); }) { IsBackground = true };
                    thread.Start();
                
            }
            string s = "Revit";
            KillApplication(s);

        }

        private void Wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            Console.WriteLine("OK");
            Console.ReadKey();
        }


        public static bool IsValidUri(string url)
        {
            try
            {
                var request = WebRequest.Create(url);
                request.Timeout = 90000;

                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    response.Close();
                    return response.StatusCode == HttpStatusCode.OK;
                }
            }
            catch (Exception)
            {
                return false;
            }
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

        private static void ListProcesses()
        {
            Process[] processCollection = Process.GetProcesses();
            foreach (Process p in processCollection)
            {
                if (p.ProcessName == "notepad")//Revit
                {
                    p.Kill();
                }
                Console.WriteLine(p.ProcessName);
            }
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