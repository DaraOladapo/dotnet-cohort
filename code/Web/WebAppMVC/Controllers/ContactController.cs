using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMVC.Controllers
{
    [Route("Contact-Us")]
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("Request-A-Quote")]
        public IActionResult Quote()
        {
            return View();
        }

    }
}
