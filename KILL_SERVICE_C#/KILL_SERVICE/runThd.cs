using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using utility;
using KILL_SERVICE;
using System.Windows.Forms;
using System.Diagnostics;
namespace runThd_namespace
{
    class runThd
    {
        myinclude my = new myinclude();
        private Thread Thd = null;
        //private int Value = 0;

        public runThd()
        {

        }

        public void Start()
        {
            if (Thd != null)
                throw (new Exception("Thread Already Running"));
            Thd = new Thread(new ParameterizedThreadStart(Run));
            Thd.Start();
        }

        public void Stop()
        {
            if (Thd != null)
            {
                Thd.Abort();
                Thd = null;
            }
            else
            {
                //throw (new Exception("Thread Already Stopped"));
            }
        }

        private void Run(object args)
        {

            try
            {
                while (true)
                {
                    //Value++;
                    //Console.WriteLine("Value: {0}", Value);
                    //MessageBox.Show(Form1.setting_path);
                    string data = my.trim(my.b2s(my.file_get_contents(Form1.setting_path)));
                    string[] mdata = my.explode(",", data);
                    Array.Sort<string>(mdata);
                    Process[] processlist = Process.GetProcesses();
                    foreach (Process theprocess in processlist)
                    {
                        for (int i = 0, max_i = mdata.Length; i < max_i; i++)
                        {
                            //MessageBox.Show(theprocess.ProcessName);                            
                            if (my.trim(my.mainname(mdata[i])).ToLower() == theprocess.ProcessName.ToLower())
                            {
                                try
                                {
                                    //theprocess.Kill();
                                    my.KillProcessAndChildrens(theprocess.Id);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                                break;
                            }
                        }
                    }
                    Thread.Sleep(100);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            Thd = null;
        }
    }
}
