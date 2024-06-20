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
    public class testktraController : Controller
    {
        private readonly LTQDD _context;

        public testktraController(LTQDD context)
        {
            _context = context;
        }

        // GET: testktra
        public async Task<IActionResult> Index()
        {
            return View(await _context.testktra.ToListAsync());
        }

        // GET: testktra/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testktra = await _context.testktra
                .FirstOrDefaultAsync(m => m.Ten == id);
            if (testktra == null)
            {
                return NotFound();
            }

            return View(testktra);
        }

        // GET: testktra/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: testktra/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Ten,Lop,SinhVien")] testktra testktra)
        {
            if (ModelState.IsValid)
            {
                _context.Add(testktra);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(testktra);
        }

        // GET: testktra/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testktra = await _context.testktra.FindAsync(id);
            if (testktra == null)
            {
                return NotFound();
            }
            return View(testktra);
        }

        // POST: testktra/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Ten,Lop,SinhVien")] testktra testktra)
        {
            if (id != testktra.Ten)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(testktra);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!testktraExists(testktra.Ten))
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
            return View(testktra);
        }

        // GET: testktra/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testktra = await _context.testktra
                .FirstOrDefaultAsync(m => m.Ten == id);
            if (testktra == null)
            {
                return NotFound();
            }

            return View(testktra);
        }

        // POST: testktra/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var testktra = await _context.testktra.FindAsync(id);
            if (testktra != null)
            {
                _context.testktra.Remove(testktra);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool testktraExists(string id)
        {
            return _context.testktra.Any(e => e.Ten == id);
        }
    }
}
