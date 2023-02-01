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
    public class VerhuurlijnsController : Controller
    {
        private readonly ASP_NET_Opdracht1Context _context;

        public VerhuurlijnsController(ASP_NET_Opdracht1Context context)
        {
            _context = context;
        }

        // GET: Verhuurlijns
        public async Task<IActionResult> Index()
        {
              return View(await _context.Verhuurlijn.ToListAsync());
        }

        // GET: Verhuurlijns/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Verhuurlijn == null)
            {
                return NotFound();
            }

            var verhuurlijn = await _context.Verhuurlijn
                .FirstOrDefaultAsync(m => m.Id == id);
            if (verhuurlijn == null)
            {
                return NotFound();
            }

            return View(verhuurlijn);
        }

        // GET: Verhuurlijns/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Verhuurlijns/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,VerhuurId,FilmId,Prijs,UitleenDatum,TerugDatum")] Verhuurlijn verhuurlijn)
        {
            if (ModelState.IsValid)
            {
                _context.Add(verhuurlijn);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(verhuurlijn);
        }

        // GET: Verhuurlijns/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Verhuurlijn == null)
            {
                return NotFound();
            }

            var verhuurlijn = await _context.Verhuurlijn.FindAsync(id);
            if (verhuurlijn == null)
            {
                return NotFound();
            }
            return View(verhuurlijn);
        }

        // POST: Verhuurlijns/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,VerhuurId,FilmId,Prijs,UitleenDatum,TerugDatum")] Verhuurlijn verhuurlijn)
        {
            if (id != verhuurlijn.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(verhuurlijn);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VerhuurlijnExists(verhuurlijn.Id))
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
            return View(verhuurlijn);
        }

        // GET: Verhuurlijns/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Verhuurlijn == null)
            {
                return NotFound();
            }

            var verhuurlijn = await _context.Verhuurlijn
                .FirstOrDefaultAsync(m => m.Id == id);
            if (verhuurlijn == null)
            {
                return NotFound();
            }

            return View(verhuurlijn);
        }

        // POST: Verhuurlijns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Verhuurlijn == null)
            {
                return Problem("Entity set 'ASP_NET_Opdracht1Context.Verhuurlijn'  is null.");
            }
            var verhuurlijn = await _context.Verhuurlijn.FindAsync(id);
            if (verhuurlijn != null)
            {
                verhuurlijn.visible = false;
                //_context.Verhuurlijn.Remove(verhuurlijn);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VerhuurlijnExists(int id)
        {
          return _context.Verhuurlijn.Any(e => e.Id == id);
        }
    }
}
