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
    public class KpimarketsController : Controller
    {
        private readonly TestHadadianContext _context;

        public KpimarketsController(TestHadadianContext context)
        {
            _context = context;
        }

        // GET: Kpimarkets
        public async Task<IActionResult> Index()
        {
              return _context.Kpimarkets != null ? 
                          View(await _context.Kpimarkets.ToListAsync()) :
                          Problem("Entity set 'TestHadadianContext.Kpimarkets'  is null.");
        }

        // GET: Kpimarkets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Kpimarkets == null)
            {
                return NotFound();
            }

            var kpimarket = await _context.Kpimarkets
                .FirstOrDefaultAsync(m => m.Id == id);
            if (kpimarket == null)
            {
                return NotFound();
            }

            return View(kpimarket);
        }

        // GET: Kpimarkets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Kpimarkets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,KpimarketingCode,NewUser,RegistertoIssue,NewCusAsset,LegMrk,BrcMrkRti,SalePlanDsg,MrkStgDsg")] Kpimarket kpimarket)
        {
            if (ModelState.IsValid)
            {
                _context.Add(kpimarket);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(kpimarket);
        }

        // GET: Kpimarkets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Kpimarkets == null)
            {
                return NotFound();
            }

            var kpimarket = await _context.Kpimarkets.FindAsync(id);
            if (kpimarket == null)
            {
                return NotFound();
            }
            return View(kpimarket);
        }

        // POST: Kpimarkets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,KpimarketingCode,NewUser,RegistertoIssue,NewCusAsset,LegMrk,BrcMrkRti,SalePlanDsg,MrkStgDsg")] Kpimarket kpimarket)
        {
            if (id != kpimarket.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kpimarket);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KpimarketExists(kpimarket.Id))
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
            return View(kpimarket);
        }

        // GET: Kpimarkets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Kpimarkets == null)
            {
                return NotFound();
            }

            var kpimarket = await _context.Kpimarkets
                .FirstOrDefaultAsync(m => m.Id == id);
            if (kpimarket == null)
            {
                return NotFound();
            }

            return View(kpimarket);
        }

        // POST: Kpimarkets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Kpimarkets == null)
            {
                return Problem("Entity set 'TestHadadianContext.Kpimarkets'  is null.");
            }
            var kpimarket = await _context.Kpimarkets.FindAsync(id);
            if (kpimarket != null)
            {
                _context.Kpimarkets.Remove(kpimarket);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KpimarketExists(int id)
        {
          return (_context.Kpimarkets?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
