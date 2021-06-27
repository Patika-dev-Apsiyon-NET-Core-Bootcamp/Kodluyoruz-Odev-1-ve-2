using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RoleManagement.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace RoleManagement.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<User> _userManager;
        public HomeController(ILogger<HomeController> logger, UserManager<User> userManager)
        {
            _logger = logger;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            _userManager.GetRolesAsync(new User());

            return View();
        }

        [AllowAnonymous]
        public async Task<IActionResult> Privacy()
        {
           await _userManager.CreateAsync(new User() {Email = "a@a.com", Name = "Veysel", UserName = "a@a.com"}, "1234aT@");

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
