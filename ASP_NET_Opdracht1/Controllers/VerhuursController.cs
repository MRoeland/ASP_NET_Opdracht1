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
    public class VerhuursController : Controller
    {
        private readonly ASP_NET_Opdracht1Context _context;

        public VerhuursController(ASP_NET_Opdracht1Context context)
        {
            _context = context;
        }

        // GET: Verhuurs
        public async Task<IActionResult> Index()
        {
              return View(await _context.Verhuur.ToListAsync());
        }

        // GET: Verhuurs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Verhuur == null)
            {
                return NotFound();
            }

            var verhuur = await _context.Verhuur
                .FirstOrDefaultAsync(m => m.VerhuurId == id);
            if (verhuur == null)
            {
                return NotFound();
            }

            return View(verhuur);
        }

        // GET: Verhuurs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Verhuurs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VerhuurId,LidId,UitleenDatum,TerugDatum,TotaalPrijs")] Verhuur verhuur)
        {
            if (ModelState.IsValid)
            {
                _context.Add(verhuur);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(verhuur);
        }

        // GET: Verhuurs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Verhuur == null)
            {
                return NotFound();
            }

            var verhuur = await _context.Verhuur.FindAsync(id);
            if (verhuur == null)
            {
                return NotFound();
            }
            return View(verhuur);
        }

        // POST: Verhuurs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VerhuurId,LidId,UitleenDatum,TerugDatum,TotaalPrijs")] Verhuur verhuur)
        {
            if (id != verhuur.VerhuurId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(verhuur);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VerhuurExists(verhuur.VerhuurId))
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
            return View(verhuur);
        }

        // GET: Verhuurs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Verhuur == null)
            {
                return NotFound();
            }

            var verhuur = await _context.Verhuur
                .FirstOrDefaultAsync(m => m.VerhuurId == id);
            if (verhuur == null)
            {
                return NotFound();
            }

            return View(verhuur);
        }

        // POST: Verhuurs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Verhuur == null)
            {
                return Problem("Entity set 'ASP_NET_Opdracht1Context.Verhuur'  is null.");
            }
            var verhuur = await _context.Verhuur.FindAsync(id);
            if (verhuur != null)
            {
                verhuur.visible = false;
                //_context.Verhuur.Remove(verhuur);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VerhuurExists(int id)
        {
          return _context.Verhuur.Any(e => e.VerhuurId == id);
        }
    }
}
