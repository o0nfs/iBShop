using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IBshopDemo.Models;

namespace IBshopDemo.Controllers
{
    public class KpiplanningsController : Controller
    {
        private readonly TestHadadianContext _context;

        public KpiplanningsController(TestHadadianContext context)
        {
            _context = context;
        }

        // GET: Kpiplannings
        public async Task<IActionResult> Index()
        {
              return _context.Kpiplannings != null ? 
                          View(await _context.Kpiplannings.ToListAsync()) :
                          Problem("Entity set 'TestHadadianContext.Kpiplannings'  is null.");
        }

        // GET: Kpiplannings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Kpiplannings == null)
            {
                return NotFound();
            }

            var kpiplanning = await _context.Kpiplannings
                .FirstOrDefaultAsync(m => m.Id == id);
            if (kpiplanning == null)
            {
                return NotFound();
            }

            return View(kpiplanning);
        }

        // GET: Kpiplannings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Kpiplannings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,KpiplanCode,DelonPrConf,EffImpAct,OtimpPercentage,PrImPercent,KmsavePercent,ArchivePer,Nps")] Kpiplanning kpiplanning)
        {
            if (ModelState.IsValid)
            {
                _context.Add(kpiplanning);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(kpiplanning);
        }

        // GET: Kpiplannings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Kpiplannings == null)
            {
                return NotFound();
            }

            var kpiplanning = await _context.Kpiplannings.FindAsync(id);
            if (kpiplanning == null)
            {
                return NotFound();
            }
            return View(kpiplanning);
        }

        // POST: Kpiplannings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,KpiplanCode,DelonPrConf,EffImpAct,OtimpPercentage,PrImPercent,KmsavePercent,ArchivePer,Nps")] Kpiplanning kpiplanning)
        {
            if (id != kpiplanning.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kpiplanning);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KpiplanningExists(kpiplanning.Id))
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
            return View(kpiplanning);
        }

        // GET: Kpiplannings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Kpiplannings == null)
            {
                return NotFound();
            }

            var kpiplanning = await _context.Kpiplannings
                .FirstOrDefaultAsync(m => m.Id == id);
            if (kpiplanning == null)
            {
                return NotFound();
            }

            return View(kpiplanning);
        }

        // POST: Kpiplannings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Kpiplannings == null)
            {
                return Problem("Entity set 'TestHadadianContext.Kpiplannings'  is null.");
            }
            var kpiplanning = await _context.Kpiplannings.FindAsync(id);
            if (kpiplanning != null)
            {
                _context.Kpiplannings.Remove(kpiplanning);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KpiplanningExists(int id)
        {
          return (_context.Kpiplannings?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
