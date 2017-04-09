using System.Diagnostics;
namespace Gkill.API.Utils{
    public static class ProccessManager{
        public static Process[] All(){
            return Process.GetProcesses();
        }
    }
}