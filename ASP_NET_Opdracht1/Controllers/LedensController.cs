using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASP_NET_Opdracht1.Data;
using ASP_NET_Opdracht1.Models;

namespace ASP_NET_Opdracht1.Controllers
{
    public class LedensController : Controller
    {
        private readonly ASP_NET_Opdracht1Context _context;

        public LedensController(ASP_NET_Opdracht1Context context)
        {
            _context = context;
        }

        // GET: Ledens
        public async Task<IActionResult> Index()
        {
              return View(await _context.Leden.ToListAsync());
        }

        // GET: Ledens/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Leden == null)
            {
                return NotFound();
            }

            var leden = await _context.Leden
                .FirstOrDefaultAsync(m => m.Id == id);
            if (leden == null)
            {
                return NotFound();
            }

            return View(leden);
        }

        // GET: Ledens/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ledens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Naam,Adres,TelNr,Email")] Leden leden)
        {
            if (ModelState.IsValid)
            {
                _context.Add(leden);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(leden);
        }

        // GET: Ledens/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Leden == null)
            {
                return NotFound();
            }

            var leden = await _context.Leden.FindAsync(id);
            if (leden == null)
            {
                return NotFound();
            }
            return View(leden);
        }

        // POST: Ledens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Naam,Adres,TelNr,Email")] Leden leden)
        {
            if (id != leden.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(leden);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LedenExists(leden.Id))
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
            return View(leden);
        }

        // GET: Ledens/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Leden == null)
            {
                return NotFound();
            }

            var leden = await _context.Leden
                .FirstOrDefaultAsync(m => m.Id == id);
            if (leden == null)
            {
                return NotFound();
            }

            return View(leden);
        }

        // POST: Ledens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Leden == null)
            {
                return Problem("Entity set 'ASP_NET_Opdracht1Context.Leden'  is null.");
            }
            var leden = await _context.Leden.FindAsync(id);
            if (leden != null)
            {
                leden.visible = false;
                //_context.Leden.Remove(leden);
            } 
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LedenExists(int id)
        {
          return _context.Leden.Any(e => e.Id == id);
        }
    }
}
