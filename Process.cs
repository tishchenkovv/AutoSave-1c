using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading;

namespace AutoSave_1c
{
  static  class ProcessOneS 
    {

        public static List<Process> GetProcess1c() 
        {

           Process[] ThinkClient = Process.GetProcessesByName("1cv8c");
           Process[] FatClient = Process.GetProcessesByName("1cv8");

            List<Process> AllClient = new List<Process>();

            foreach (Process str in ThinkClient)
            {
                AllClient.Add(str);
            }

            foreach (Process str in FatClient)
            {
                AllClient.Add(str);
            }

            return AllClient;

        }

        public static void KillProces(int[] id)
        {

            foreach (int i in id)
            {
                if (i is int || i != 0)
                {
                    try
                    {
                        Process pr = Process.GetProcessById(i);
                        if (pr != null)
                        {
                            pr.Kill();
                            pr.WaitForExit(2000);
                        }
                    }

                    catch(Exception e)
                    {
                        MessageBox.Show(e.Message);
                        continue;
                    }
                }

            }

        }

    }
}
