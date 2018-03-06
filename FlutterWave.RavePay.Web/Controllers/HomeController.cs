using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FlutterWave.RavePay.Web.Models;
using Flutterwave.Ravepay.Net;

namespace FlutterWave.RavePay.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AccountPayment()
        {
            return View();
        }

        public IActionResult CardPayment()
        {
            var raveConfig = new RavePayConfig(false);
            return View();
        }

        [HttpPost]
        public IActionResult CardPayment(CardPayModel model)
        {
            var raveConfig = new RavePayConfig(false);
            return View();
        }
        public IActionResult TestCards()
        {
            return View();
        }

        public IActionResult TestAccounts()
        {
            return View();

        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
