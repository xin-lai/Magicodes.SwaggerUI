using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ApiGroupTestHost.Controllers
{
    public class HomeController: ControllerBase
    {
        public IActionResult Index()
        {
            return Redirect("/swagger");
        }
    }
}
