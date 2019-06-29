using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PhoneBook.DataContext;
using PhoneBook.Models.Phones;

namespace PhoneBook.Controllers
{
    public class PhoneController : Controller
    {
        private readonly PhoneBookContext _context;

        public PhoneController(PhoneBookContext context)
        {
            _context = context;
        }                

        // GET: Phone/Create
        public IActionResult Create(int? contactId)
        {        
            ViewData["ContactId"] = new SelectList(_context.Contacts.Where(p => p.Id == contactId), "Id", "Name");
            ViewData["TypePhoneId"] = new SelectList(_context.TypePhones, "Id", "Name");
            return PartialView();
        }

        // POST: Phone/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Number,ContactId,TypePhoneId")] Phone phone)
        {
            if (ModelState.IsValid)
            {
                _context.Add(phone);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", "Contact", new { id = phone.ContactId });
            }
            ViewData["TypePhoneId"] = new SelectList(_context.TypePhones, "Id", "Name", phone.TypePhoneId);
            return PartialView(phone);
        }

        // GET: Phone/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phone = await _context.Phones.FindAsync(id);
            if (phone == null)
            {
                return NotFound();
            }
            ViewData["ContactId"] = new SelectList(_context.Contacts, "Id", "Name", phone.ContactId);
            ViewData["TypePhoneId"] = new SelectList(_context.TypePhones, "Id", "Name", phone.TypePhoneId);
            return PartialView(phone);
        }

        // POST: Phone/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Number,TypePhoneId,ContactId")] Phone phone)
        {
            if (id != phone.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(phone);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhoneExists(phone.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", "Contact", new { id = phone.ContactId });
            }
            ViewData["ContactId"] = new SelectList(_context.Contacts, "Id", "Name", phone.ContactId);
            ViewData["TypePhoneId"] = new SelectList(_context.TypePhones, "Id", "Name", phone.TypePhoneId);
            return PartialView(phone);
        }

        // GET: Phone/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phone = await _context.Phones
                .Include(p => p.Contact)
                .Include(p => p.TypePhone)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (phone == null)
            {
                return NotFound();
            }

            return PartialView(phone);
        }

        // POST: Phone/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var phone = await _context.Phones.FindAsync(id);
            //phone = _context.Phones.Include(p => p.Contact).FirstOrDefault(m => m.Id == id); 
            int contactId = phone.ContactId;
            _context.Phones.Remove(phone);
            await _context.SaveChangesAsync();
            return RedirectToAction("Details", "Contact", new { id = contactId });
        }

        private bool PhoneExists(int id)
        {
            return _context.Phones.Any(e => e.Id == id);
        }
    }
}
