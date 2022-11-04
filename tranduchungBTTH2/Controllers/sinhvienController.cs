using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using tranduchungBTTH2.Models;

namespace tranduchungBTTH2.Controllers
{
    public class sinhvienController : Controller
    {
        private readonly ApplicationDbcontext _context;

        public sinhvienController(ApplicationDbcontext context)
        {
            _context = context;
        }

        // GET: sinhvien
        public async Task<IActionResult> Index()
        {
            return _context.sinhvien != null ?
                        View(await _context.sinhvien.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbcontext.sinhvien'  is null.");
        }

        // GET: sinhvien/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.sinhvien == null)
            {
                return View("NotFound");
            }

            var sinhvien = await _context.sinhvien
                .FirstOrDefaultAsync(m => m.masinhvien == id);
            if (sinhvien == null)
            {
                return View("NotFound");
            }

            return View(sinhvien);
        }

        // GET: sinhvien/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: sinhvien/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("masinhvien,tensinhvien,age,diachi")] sinhvien sinhvien)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sinhvien);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sinhvien);
        }

        // GET: sinhvien/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.sinhvien == null)
            {
                return View("NotFound");
            }

            var sinhvien = await _context.sinhvien.FindAsync(id);
            if (sinhvien == null)
            {
                return View("NotFound");
            }
            return View(sinhvien);
        }

        // POST: sinhvien/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("masinhvien,tensinhvien,age,diachi")] sinhvien sinhvien)
        {
            if (id != sinhvien.masinhvien)
            {
                return View("NotFound");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sinhvien);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!sinhvienExists(sinhvien.masinhvien))
                    {
                        return View("NotFound");
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(sinhvien);
        }

        // GET: sinhvien/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.sinhvien == null)
            {
                return View("NotFound");
            }

            var sinhvien = await _context.sinhvien
                .FirstOrDefaultAsync(m => m.masinhvien == id);
            if (sinhvien == null)
            {
                return View("NotFound");
            }

            return View(sinhvien);
        }

        // POST: sinhvien/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.sinhvien == null)
            {
                return Problem("Entity set 'ApplicationDbcontext.sinhvien'  is null.");
            }
            var sinhvien = await _context.sinhvien.FindAsync(id);
            if (sinhvien != null)
            {
                _context.sinhvien.Remove(sinhvien);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool sinhvienExists(int id)
        {
            return (_context.sinhvien?.Any(e => e.masinhvien == id)).GetValueOrDefault();
        }
    }
}
