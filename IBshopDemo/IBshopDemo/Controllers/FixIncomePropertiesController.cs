using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IBshopDemo.Models;
using IBshopDemo.ActionFilters;
using IBshopDemo.Enums;

namespace IBshopDemo.Controllers
{
    public class FixIncomePropertiesController : Controller
    {
        private readonly TestHadadianContext _context;

        public FixIncomePropertiesController(TestHadadianContext context)
        {
            _context = context;
        }

		// GET: FixIncomeProperties

		[Authorization((int)Roles.مدیر_عملیات)]
		[Authorization((int)Roles.مدیرعامل)]

		public async Task<IActionResult> Index()
        {
            var testHadadianContext = _context.FixIncomeProperties.Include(f => f.BrancheCodeNavigation).Include(f => f.InComeCenter);
            return View(await testHadadianContext.ToListAsync());
        }

        // GET: FixIncomeProperties/Details/5
     
        [Authorization((int)Roles.مدیر_عملیات)]
        [Authorization((int)Roles.مدیرعامل)]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.FixIncomeProperties == null)
            {
                return NotFound();
            }

            var fixIncomeProperty = await _context.FixIncomeProperties
                .Include(f => f.BrancheCodeNavigation)
                .Include(f => f.InComeCenter)
                .FirstOrDefaultAsync(m => m.FixIncomeId == id);
            if (fixIncomeProperty == null)
            {
                return NotFound();
            }

            return View(fixIncomeProperty);
        }

        // GET: FixIncomeProperties/Create
      
        [Authorization((int)Roles.مدیر_عملیات)]
        [Authorization((int)Roles.مدیرعامل)]
        public IActionResult Create()
        {
            ViewData["BrancheCode"] = new SelectList(_context.BranchesInfos, "BranchCode", "BranchCode");
            ViewData["InComeCenterId"] = new SelectList(_context.IncomeCenters, "IncomecenterId", "IncomecenterId");
            return View();
        }

        // POST: FixIncomeProperties/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
       
        [Authorization((int)Roles.مدیر_عملیات)]
        [Authorization((int)Roles.مدیرعامل)]
        public async Task<IActionResult> Create([Bind("FixIncomeId,BrancheCode,InComeCenterId,MonthNumber,MonthName,CustomerQty,GanjinehIssue,GanjinehRev,AndookhtehIssue,AndookhtehRev,VirIssueBillQty,VirIssueBillVol,TotalIssue,TotalRev")] FixIncomeProperty fixIncomeProperty)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fixIncomeProperty);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BrancheCode"] = new SelectList(_context.BranchesInfos, "BranchCode", "BranchCode", fixIncomeProperty.BrancheCode);
            ViewData["InComeCenterId"] = new SelectList(_context.IncomeCenters, "IncomecenterId", "IncomecenterId", fixIncomeProperty.InComeCenterId);
            return View(fixIncomeProperty);
        }

        // GET: FixIncomeProperties/Edit/5
       
        [Authorization((int)Roles.مدیر_عملیات)]
        [Authorization((int)Roles.مدیرعامل)]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.FixIncomeProperties == null)
            {
                return NotFound();
            }

            var fixIncomeProperty = await _context.FixIncomeProperties.FindAsync(id);
            if (fixIncomeProperty == null)
            {
                return NotFound();
            }
            ViewData["BrancheCode"] = new SelectList(_context.BranchesInfos, "BranchCode", "BranchCode", fixIncomeProperty.BrancheCode);
            ViewData["InComeCenterId"] = new SelectList(_context.IncomeCenters, "IncomecenterId", "IncomecenterId", fixIncomeProperty.InComeCenterId);
            return View(fixIncomeProperty);
        }

        // POST: FixIncomeProperties/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
      
        [Authorization((int)Roles.مدیر_عملیات)]
        [Authorization((int)Roles.مدیرعامل)]
        public async Task<IActionResult> Edit(int id, [Bind("FixIncomeId,BrancheCode,InComeCenterId,MonthNumber,MonthName,CustomerQty,GanjinehIssue,GanjinehRev,AndookhtehIssue,AndookhtehRev,VirIssueBillQty,VirIssueBillVol,TotalIssue,TotalRev")] FixIncomeProperty fixIncomeProperty)
        {
            if (id != fixIncomeProperty.FixIncomeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fixIncomeProperty);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FixIncomePropertyExists(fixIncomeProperty.FixIncomeId))
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
            ViewData["BrancheCode"] = new SelectList(_context.BranchesInfos, "BranchCode", "BranchCode", fixIncomeProperty.BrancheCode);
            ViewData["InComeCenterId"] = new SelectList(_context.IncomeCenters, "IncomecenterId", "IncomecenterId", fixIncomeProperty.InComeCenterId);
            return View(fixIncomeProperty);
        }

        // GET: FixIncomeProperties/Delete/5
       
        [Authorization((int)Roles.مدیر_عملیات)]
        [Authorization((int)Roles.مدیرعامل)]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.FixIncomeProperties == null)
            {
                return NotFound();
            }

            var fixIncomeProperty = await _context.FixIncomeProperties
                .Include(f => f.BrancheCodeNavigation)
                .Include(f => f.InComeCenter)
                .FirstOrDefaultAsync(m => m.FixIncomeId == id);
            if (fixIncomeProperty == null)
            {
                return NotFound();
            }

            return View(fixIncomeProperty);
        }

        // POST: FixIncomeProperties/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        
        [Authorization((int)Roles.مدیر_عملیات)]
        [Authorization((int)Roles.مدیرعامل)]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.FixIncomeProperties == null)
            {
                return Problem("Entity set 'TestHadadianContext.FixIncomeProperties'  is null.");
            }
            var fixIncomeProperty = await _context.FixIncomeProperties.FindAsync(id);
            if (fixIncomeProperty != null)
            {
                _context.FixIncomeProperties.Remove(fixIncomeProperty);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FixIncomePropertyExists(int id)
        {
          return (_context.FixIncomeProperties?.Any(e => e.FixIncomeId == id)).GetValueOrDefault();
        }
    }
}
