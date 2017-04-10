using System.Diagnostics;

namespace Gkill.API.Models{
    public class ProcessModel{
        public int ProcessID {get; set;}
        public string ProcessName { get; set; }
        public string ProcessUserName {
            get{
                return GetUser();
            }
        }
        public long Memory {get; set;}

        private string GetUser(){
            return "root";
        }

        /*private string GetUser(){
            Process p = new Process();
            p.StartInfo = new ProcessStartInfo("/bin/ps", $"-o user -p {ProcessID} --no-headers"){
                RedirectStandardOutput = true,
                UseShellExecute = false
            };

            p.Start();
            p.WaitForExit();

            return p.StandardOutput.ReadLine();
        }*/
    }
}