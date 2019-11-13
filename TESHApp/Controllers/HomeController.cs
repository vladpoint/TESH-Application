using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using TESHApp.Models;
using TESHApp.Areas.Identity.Data;
using System.Security.Claims;

namespace TESHApp.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        UserManager<TESHAppUser> _userManager;
        [AllowAnonymous]
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = _userManager.GetUserAsync(User);
                ViewBag.RolId = user.Result.RolId;
                _ = User.Claims.ToList();
                
            }
            return View();
        }
        [AllowAnonymous]
        public IActionResult About()
        {
            ViewData["Message"] = "Esta es la página de descripción del TESH";

            return View();
        }
        [AllowAnonymous]
        public IActionResult Contact()
        {
            ViewData["Message"] = "Esta es la página de Contacto del TESH";

            return View();
        }
        [AllowAnonymous]
        public IActionResult teshhome()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult teshhome2()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
