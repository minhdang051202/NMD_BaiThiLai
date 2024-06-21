using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BaiThiLai.Models;

namespace BaiThiLai.Controllers
{
    public class NMD190Controller : Controller
    {
        private readonly LTQDD _context;

        public NMD190Controller(LTQDD context)
        {
            _context = context;
        }

       
        public async Task<IActionResult> Index()
        {
            return View(await _context.NMD190Person.ToListAsync());
        }

        
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nMD190Person = await _context.NMD190Person
                .FirstOrDefaultAsync(m => m.PersonID == id);
            if (nMD190Person == null)
            {
                return NotFound();
            }

            return View(nMD190Person);
        }

       
        public IActionResult Create()
        {
            return View();
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonID,Fullname,Address")] NMD190Person nMD190Person)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nMD190Person);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nMD190Person);
        }


        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nMD190Person = await _context.NMD190Person.FindAsync(id);
            if (nMD190Person == null)
            {
                return NotFound();
            }
            return View(nMD190Person);
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("PersonID,Fullname,Address")] NMD190Person nMD190Person)
        {
            if (id != nMD190Person.PersonID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nMD190Person);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NMD190PersonExists(nMD190Person.PersonID))
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
            return View(nMD190Person);
        }

        // GET: NMD190/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nMD190Person = await _context.NMD190Person
                .FirstOrDefaultAsync(m => m.PersonID == id);
            if (nMD190Person == null)
            {
                return NotFound();
            }

            return View(nMD190Person);
        }

 
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var nMD190Person = await _context.NMD190Person.FindAsync(id);
            if (nMD190Person != null)
            {
                _context.NMD190Person.Remove(nMD190Person);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NMD190PersonExists(string id)
        {
            return _context.NMD190Person.Any(e => e.PersonID == id);
        }
    }
}
