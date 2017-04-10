using System;
using System.Diagnostics;
using Gkill.API.Models;
using Xunit;

namespace Gkill.API.Test.Models{
    public class ProcessModelTest{
        
        [Fact]
        public void ProcessModelObtainsUserName(){
          /*  var processInfo = GetSingleProcess();
            var processId = Convert.ToInt32(processInfo.Item1);
            var processUser = processInfo.Item2;
            var processModel = new ProcessModel(){
                ProcessID = processId
            };

            Assert.Equal(processUser, processModel.ProcessUserName);*/
            var processModel = new ProcessModel(){
                ProcessID =  1
            };
            Assert.Equal("root", processModel.ProcessUserName);
        }

        private Tuple<string, string> GetSingleProcess(){
            Process p = new Process();
            p.StartInfo = new ProcessStartInfo("/bin/ps", $"-o pid,user --no-headers"){
                RedirectStandardOutput = true,
                UseShellExecute = false
            };

            p.Start();
            p.WaitForExit();

            string[] output =  p.StandardOutput.ReadLine().Split(' ');
            return new Tuple<string, string>(output[0], output[1]);
        }
    }
}