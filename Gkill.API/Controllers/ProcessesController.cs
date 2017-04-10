using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Gkill.API.Models;
using System.Linq;

namespace Gkill.API.Controllers{

    [Route("api/[controller]")]
    public class ProcessesController : Controller{

        [HttpGet]
        public IEnumerable<ProcessModel> Index(){
            return Utils.ProccessManager.All()
            .Select(p => new ProcessModel{
                ProcessID = p.Id,
                ProcessName = p.ProcessName,
                Memory = p.VirtualMemorySize64,
            });
        }
    }
}