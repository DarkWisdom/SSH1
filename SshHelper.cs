using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Renci.SshNet;
using System.IO;

namespace SSH
{
    class SshHelper
    {
        private string log;
        private string pass;
        private List<string> list;
        private string ip;
        private string path;
        //
          /*  public void ExecSSH(List<String> ip, string log, string pass, List<String> list) {
                foreach (string ipadd in ip)
                {
                    using (var conninfo = new PasswordConnectionInfo(ipadd, log, pass))
                    {
                        Renci.SshNet.SshClient client = new Renci.SshNet.SshClient(conninfo);
                        client.Connect();
                        Renci.SshNet.ShellStream stream = client.CreateShellStream("ssh", 180, 324, 1800, 3600, 8000);
                        foreach (string command in list)
                        {
                            // var command = "show config modified";
                            stream.Write(command + "\n");
                            System.Threading.Thread.Sleep(5000);
                            string temp_string = stream.Read();
                            //  Console.Write(temp_string);
                            File.WriteAllText("C:/" + ipadd + ".txt", temp_string, Encoding.UTF8);
                            //System.Threading.Thread.Sleep(5000);

                        }
                        client.Disconnect();
                    }
                } 
            } */

       public SshHelper(string log, string pass, List<string> list, string ip, string path)
        {

            this.log = log;
            this.pass = pass;
            this.list = list;
            this.ip = ip;
            this.path = path;

        }

        public void ExeSSH(Object s)
        {
                    using (var conninfo = new PasswordConnectionInfo(ip, log, pass))
                    {
                //  try

                Renci.SshNet.SshClient client = new Renci.SshNet.SshClient(conninfo);
              
              //  conninfo.Timeout = TimeSpan.FromSeconds(50);
                     try
                    {
                client.Connect();
                }
                catch (Exception ex)
                {

                }
                try
                {
                    Renci.SshNet.ShellStream stream = client.CreateShellStream("ssh", 180, 324, 1800, 3600, 8000);
                            foreach (string command in list)
                            {
                                stream.Write(command + "\n");
                                System.Threading.Thread.Sleep(5000);
                                string temp_string = stream.Read();
                                //    File.WriteAllText(path, temp_string, Encoding.UTF8);
                                File.WriteAllText("C:/" + ip + ".txt", temp_string, Encoding.UTF8);
                                System.Threading.Thread.Sleep(5000);
                        

                            }
                            client.Disconnect();
                        }
                catch (Exception ex)
                {

                }

            }

        }

        public void ExSSH(string ip, string log, string pass, List<String> list)
        {
       //     foreach (string ipadd in ip)
       //     {
                using (var conninfo = new PasswordConnectionInfo(ip, log, pass))
                {
                    Renci.SshNet.SshClient client = new Renci.SshNet.SshClient(conninfo);
                    client.Connect();
                    Renci.SshNet.ShellStream stream = client.CreateShellStream("ssh", 180, 324, 1800, 3600, 8000);
                    foreach (string command in list)
                    {
                        // var command = "show config modified";
                        stream.Write(command + "\n");
                        System.Threading.Thread.Sleep(10000);
                        string temp_string = stream.Read();
                        //  Console.Write(temp_string);
                        File.WriteAllText("C:/" + ip +" thread n- "+System.Threading.Thread.CurrentThread.ManagedThreadId + ".txt", temp_string, Encoding.UTF8);
                   //     System.Threading.Thread.Sleep(5000);

                    }
                    client.Disconnect();
             //   }
            }
        }
    }

}