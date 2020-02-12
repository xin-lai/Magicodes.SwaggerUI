using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TestHost3._1.Controllers
{
    public class HomeController: ControllerBase
    {
        public IActionResult Index()
        {
            return Redirect("/swagger");
        }
    }
}
