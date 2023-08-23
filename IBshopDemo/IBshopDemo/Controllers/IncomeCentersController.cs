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
    public class IncomeCentersController : Controller
    {
        private readonly TestHadadianContext _context;

        public IncomeCentersController(TestHadadianContext context)
        {
            _context = context;
        }

        // GET: IncomeCenters
        public async Task<IActionResult> Index()
        {
              return _context.IncomeCenters != null ? 
                          View(await _context.IncomeCenters.ToListAsync()) :
                          Problem("Entity set 'TestHadadianContext.IncomeCenters'  is null.");
        }

        // GET: IncomeCenters/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.IncomeCenters == null)
            {
                return NotFound();
            }

            var incomeCenter = await _context.IncomeCenters
                .FirstOrDefaultAsync(m => m.IncomecenterId == id);
            if (incomeCenter == null)
            {
                return NotFound();
            }

            return View(incomeCenter);
        }

        // GET: IncomeCenters/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: IncomeCenters/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IncomecenterId,IncomeCenterName")] IncomeCenter incomeCenter)
        {
            if (ModelState.IsValid)
            {
                _context.Add(incomeCenter);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(incomeCenter);
        }

        // GET: IncomeCenters/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.IncomeCenters == null)
            {
                return NotFound();
            }

            var incomeCenter = await _context.IncomeCenters.FindAsync(id);
            if (incomeCenter == null)
            {
                return NotFound();
            }
            return View(incomeCenter);
        }

        // POST: IncomeCenters/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IncomecenterId,IncomeCenterName")] IncomeCenter incomeCenter)
        {
            if (id != incomeCenter.IncomecenterId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(incomeCenter);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IncomeCenterExists(incomeCenter.IncomecenterId))
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
            return View(incomeCenter);
        }

        // GET: IncomeCenters/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.IncomeCenters == null)
            {
                return NotFound();
            }

            var incomeCenter = await _context.IncomeCenters
                .FirstOrDefaultAsync(m => m.IncomecenterId == id);
            if (incomeCenter == null)
            {
                return NotFound();
            }

            return View(incomeCenter);
        }

        // POST: IncomeCenters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.IncomeCenters == null)
            {
                return Problem("Entity set 'TestHadadianContext.IncomeCenters'  is null.");
            }
            var incomeCenter = await _context.IncomeCenters.FindAsync(id);
            if (incomeCenter != null)
            {
                _context.IncomeCenters.Remove(incomeCenter);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IncomeCenterExists(int id)
        {
          return (_context.IncomeCenters?.Any(e => e.IncomecenterId == id)).GetValueOrDefault();
        }
    }
}
