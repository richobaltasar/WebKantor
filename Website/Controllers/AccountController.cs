using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebPerusahaan.Models;

namespace WebPerusahaan.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public AccountController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Signup()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }
    }
}
