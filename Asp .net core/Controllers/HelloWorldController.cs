using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Asp_.net_core.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name,int numTimes=1)
        {
            ViewData["Message"] = "Hello" + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }

        // GET: /HelloWorld/Welcome/ 
       /* public string  welcome1(string name,int ID=1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name} , ID:{ID}");
        }*/
    }
}