using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Outbreak.Data;
using Outbreak.Models;

namespace Outbreak.Controllers
{
    public class HomeController : Controller
    {
        //подключаемся к данным проекта
        private ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _context = context;
            _userManager = userManager;
        }


        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                ApplicationUser me = _context.Users.SingleOrDefault(m => m.UserName == User.Identity.Name);
                ViewData["currentUserId"] = me.Id;
            }
            else
            {
                ViewData["currentUserId"] = "";
            }
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
