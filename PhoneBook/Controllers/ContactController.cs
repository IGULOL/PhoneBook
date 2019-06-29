using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PhoneBook.DataContext;
using PhoneBook.Models.Contacts;
using PhoneBook.Models.Phones;
using PhoneBook.Models.Users;

namespace PhoneBook.Controllers
{
    public class ContactController : Controller
    {
        private readonly PhoneBookContext _context;

        public ContactController(PhoneBookContext context)
        {
            _context = context;
        }

        // GET: Contact/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = await _context.Contacts
                .Include(c => c.Group)
                .Include(c => c.Phones)
                    .ThenInclude(p => p.TypePhone)
                .Include(c => c.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contact == null)
            {
                return NotFound();
            }

            var name = User.Identity.Name;
            User user = _context.Users.FirstOrDefault(u => u.UserName == name);

            if (user != null)
            {
                ViewData["NameUser"] = user.Surname + " " + user.Name;
            }

            ViewData["ContactId"] = id;

            return View(contact);
        }

        // GET: Contact/Create
        public IActionResult Create()
        {
            ViewData["GroupId"] = new SelectList(_context.Groups, "Id", "Name");

            var name = User.Identity.Name;
            User user = _context.Users.FirstOrDefault(u => u.UserName == name);

            if (user != null)
            {
                ViewData["NameUser"] = user.Surname + " " + user.Name;
            }

            return View();
        }

        // POST: Contact/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Surname,Name,Patronymic,Address,Job,Position,Email,Skype,GroupId")] Contact contact)
        {
            var name = User.Identity.Name;

            User user = _context.Users.FirstOrDefault(u => u.UserName == name);

            if (ModelState.IsValid && user != null)
            {
                ViewData["NameUser"] = user.Surname + " " + user.Name;

                contact.UserId = user.Id;
                _context.Add(contact);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            ViewData["GroupId"] = new SelectList(_context.Groups, "Id", "Name", contact.GroupId);
            
            return View(contact);
        }

        // GET: Contact/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = await _context.Contacts.FindAsync(id);
            if (contact == null)
            {
                return NotFound();
            }

            var name = User.Identity.Name;
            User user = _context.Users.FirstOrDefault(u => u.UserName == name);

            if (user != null)
            {
                ViewData["NameUser"] = user.Surname + " " + user.Name;
            }

            ViewData["GroupId"] = new SelectList(_context.Groups, "Id", "Name", contact.GroupId);
            
            return View(contact);
        }

        // POST: Contact/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Surname,Name,Patronymic,Address,Job,Position,Email,Skype,UserId,GroupId")] Contact contact)
        {
            if (id != contact.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contact);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContactExists(contact.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index", "Home");
            }
            ViewData["ContactId"] = id;
            ViewData["GroupId"] = new SelectList(_context.Groups, "Id", "Name", contact.GroupId);
           
            return View(contact);
        }

        // GET: Contact/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = await _context.Contacts
                .Include(c => c.Group)
                .Include(c => c.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contact == null)
            {
                return NotFound();
            }

            var name = User.Identity.Name;
            User user = _context.Users.FirstOrDefault(u => u.UserName == name);

            if (user != null)
            {
                ViewData["NameUser"] = user.Surname + " " + user.Name;
            }

            return View(contact);
        }

        // POST: Contact/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contact = await _context.Contacts.FindAsync(id);
            _context.Contacts.Remove(contact);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }

        private bool ContactExists(int id)
        {
            return _context.Contacts.Any(e => e.Id == id);
        }        
    }
}
