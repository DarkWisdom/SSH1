using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SSH
{
    public class ThreadHelper
    {
        private bool stop;
        public void ExecThread(List<String> ip, List<string> log, List<string> pass, List<String> list, string path)
        {
            string logs = "skrebnev";
            string passs = "E2E4knx9";

            foreach (string ipadd in ip)
            {

                      //  stop = false;

                     //   for (var i = 0; i < ip.Count; i++)
                      //  {
                            if (stop == true) {
                                break;
                            }

                            var t = new Task(() =>
                            {

                                //  SshHelper sshs = new SshHelper(logs, passs, list, ipadd, path);

                                  // ThreadPool.QueueUserWorkItem(new WaitCallback(sshs.ExeSSH));

                                SshHelper ssh = new SshHelper(logs, passs, list, ipadd, path);
                                ssh.ExSSH(ipadd, logs, passs, list);
                           });


                                 // ThreadPool pool = new ThreadPool(obj.ThreadMain);

                                
                            

                            t.Start();
                          //  t.Wait();
                           
                     //   }
                    }
                }
            }

        } 



            

