using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PhoneBook.DataContext;
using PhoneBook.Models;
using PhoneBook.Models.Contacts;
using PhoneBook.Models.Users;

namespace PhoneBook.Controllers
{
    public class HomeController : Controller
    {
        private readonly PhoneBookContext _context;

        public HomeController(PhoneBookContext context)
        {
            _context = context;
        }

        [Authorize]
        public IActionResult Index(string searchString)
        {
            if (!String.IsNullOrEmpty(searchString))
            {
                searchString = searchString.Trim();
            }

            var name = User.Identity.Name;
            User user = _context.Users.FirstOrDefault(u => u.UserName == name);

            if (user != null)
            {
                user = _context.Users
                    .Include(p => p.Contacts)
                    .ThenInclude(p => p.Group)
                    .FirstOrDefault(u => u.UserName == name);

                ViewData["NameUser"] = user.Surname + " " + user.Name;

                if (!String.IsNullOrEmpty(searchString))
                {
                    if (user.Contacts != null)
                    {
                        user.Contacts = user.Contacts.Where(s => s.Surname == searchString)
                            .Union(user.Contacts.Where(s => s.Name == searchString))
                            .Union(user.Contacts.Where(s => s.Patronymic == searchString))
                            .Union(user.Contacts.Where(s => s.Job == searchString))
                            .Union(user.Contacts.Where(s => s.Address == searchString))
                            .Union(user.Contacts.Where(s => s.Email == searchString))
                            .Union(user.Contacts.Where(s => s.Skype == searchString))
                            .Union(user.Contacts.Where(s => s.Position == searchString))
                            .Union(user.Contacts.Where(s => s.Group.Name == searchString))
                            .OrderBy(p => p.Surname).ThenBy(p => p.Name).ThenBy(p => p.Patronymic).ToList();
                    }
                }
                else
                {
                    user.Contacts = user.Contacts.OrderBy(p => p.Surname).ThenBy(p => p.Name).ThenBy(p => p.Patronymic).ToList();
                }

                return View(user);
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            var name = User.Identity.Name;
            User user = _context.Users.FirstOrDefault(u => u.UserName == name);

            if (user != null)
            {
                ViewData["NameUser"] = user.Surname + " " + user.Name;

                return View();
            }

            return View();
        }
        
        [Authorize]
        public IActionResult Group()
        {
            ViewData["Message"] = "Your contact page.";

            var name = User.Identity.Name;
            User user = _context.Users.FirstOrDefault(u => u.UserName == name);

            if (user != null)
            {
                ViewData["NameUser"] = user.Surname + " " + user.Name;

                return View();
            }

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
