using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PhoneBook.DataContext;
using PhoneBook.Models.Groups;
using PhoneBook.Models.Users;

namespace PhoneBook.Controllers
{
    public class GroupController : Controller
    {
        private readonly PhoneBookContext _context;

        public GroupController(PhoneBookContext context)
        {
            _context = context;
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            var name = User.Identity.Name;
            User user = _context.Users.FirstOrDefault(u => u.UserName == name);

            if (user != null)
            {
                ViewData["NameUser"] = user.Surname + " " + user.Name;
            }

            return View(await _context.Groups.ToListAsync());
        }

        // GET: Group/Details/5
        [Authorize]
        public async Task<IActionResult> Details(int? id)
        {
            var name = User.Identity.Name;
            User user = _context.Users.FirstOrDefault(u => u.UserName == name);

            if (user != null)
            {
                ViewData["NameUser"] = user.Surname + " " + user.Name;
            }

            if (id == null)
            {
                return NotFound();
            }

            var @group = await _context.Groups.Include(p => p.Contacts)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@group == null)
            {
                return NotFound();
            }

            return View(@group);
        }

        // GET: Group/Create
        [Authorize]
        public IActionResult Create()
        {
            var name = User.Identity.Name;
            User user = _context.Users.FirstOrDefault(u => u.UserName == name);

            if (user != null)
            {
                ViewData["NameUser"] = user.Surname + " " + user.Name;
            }

            return View();
        }

        // POST: Group/Create
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] Group @group)
        {
            var name = User.Identity.Name;
            User user = _context.Users.FirstOrDefault(u => u.UserName == name);

            if (user != null)
            {
                ViewData["NameUser"] = user.Surname + " " + user.Name;
            }

            if (ModelState.IsValid)
            {
                _context.Add(@group);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(@group);
        }

        // GET: Group/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            var name = User.Identity.Name;
            User user = _context.Users.FirstOrDefault(u => u.UserName == name);

            if (user != null)
            {
                ViewData["NameUser"] = user.Surname + " " + user.Name;
            }

            if (id == null)
            {
                return NotFound();
            }

            var @group = await _context.Groups.FindAsync(id);
            if (@group == null)
            {
                return NotFound();
            }
            return View(@group);
        }

        // POST: Group/Edit/5
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] Group @group)
        {
            var name = User.Identity.Name;
            User user = _context.Users.FirstOrDefault(u => u.UserName == name);

            if (user != null)
            {
                ViewData["NameUser"] = user.Surname + " " + user.Name;
            }

            if (id != @group.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(@group);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GroupExists(@group.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(@group);
        }

        // GET: Group/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            var name = User.Identity.Name;
            User user = _context.Users.FirstOrDefault(u => u.UserName == name);

            if (user != null)
            {
                ViewData["NameUser"] = user.Surname + " " + user.Name;
            }

            if (id == null)
            {
                return NotFound();
            }

            var @group = await _context.Groups
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@group == null)
            {
                return NotFound();
            }

            return View(@group);
        }

        // POST: Group/Delete/5
        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var @group = await _context.Groups.FindAsync(id);
            _context.Groups.Remove(@group);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GroupExists(int id)
        {
            return _context.Groups.Any(e => e.Id == id);
        }
    }
}
