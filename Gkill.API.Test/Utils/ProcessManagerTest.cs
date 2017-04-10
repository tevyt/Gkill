using Xunit;

namespace Gkill.API.Test.Utils{

    public class ProcessManagerTest{

        [Fact]
        public void AtLeastOneProcessIsRunning(){
            var runningProcesses = Gkill.API.Utils.ProccessManager.All();
            Assert.NotEmpty(runningProcesses);
        }
    }
}