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
    public class MixPropertiesController : Controller
    {
        private readonly TestHadadianContext _context;

        public MixPropertiesController(TestHadadianContext context)
        {
            _context = context;
        }

        // GET: MixProperties
        //[Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_عملیات)]
        public async Task<IActionResult> Index()
        {
            var testHadadianContext = _context.MixProperties.Include(m => m.BrancheCodeNavigation).Include(m => m.IncomeCenter);
            return View(await testHadadianContext.ToListAsync());
        }

        // GET: MixProperties/Details/5
      //  [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_عملیات)]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.MixProperties == null)
            {
                return NotFound();
            }

            var mixProperty = await _context.MixProperties
                .Include(m => m.BrancheCodeNavigation)
                .Include(m => m.IncomeCenter)
                .FirstOrDefaultAsync(m => m.MixIncomeId == id);
            if (mixProperty == null)
            {
                return NotFound();
            }

            return View(mixProperty);
        }

        // GET: MixProperties/Create
      //  [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_عملیات)]
        public IActionResult Create()
        {
            ViewData["BrancheCode"] = new SelectList(_context.BranchesInfos, "BranchCode", "BranchCode");
            ViewData["IncomeCenterId"] = new SelectList(_context.IncomeCenters, "IncomecenterId", "IncomecenterId");
            return View();
        }

        // POST: MixProperties/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
      //  [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_عملیات)]
        public async Task<IActionResult> Create([Bind("MixIncomeId,BrancheCode,IncomeCenterId,MonthNumber,MonthName,ServatIssue,ServatRev,GoharIssue,GoharRev,TotalIssue,TotalRev")] MixProperty mixProperty)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mixProperty);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BrancheCode"] = new SelectList(_context.BranchesInfos, "BranchCode", "BranchCode", mixProperty.BrancheCode);
            ViewData["IncomeCenterId"] = new SelectList(_context.IncomeCenters, "IncomecenterId", "IncomecenterId", mixProperty.IncomeCenterId);
            return View(mixProperty);
        }

        // GET: MixProperties/Edit/5
       // [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_عملیات)]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.MixProperties == null)
            {
                return NotFound();
            }

            var mixProperty = await _context.MixProperties.FindAsync(id);
            if (mixProperty == null)
            {
                return NotFound();
            }
            ViewData["BrancheCode"] = new SelectList(_context.BranchesInfos, "BranchCode", "BranchCode", mixProperty.BrancheCode);
            ViewData["IncomeCenterId"] = new SelectList(_context.IncomeCenters, "IncomecenterId", "IncomecenterId", mixProperty.IncomeCenterId);
            return View(mixProperty);
        }

        // POST: MixProperties/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
       // [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_عملیات)]
        public async Task<IActionResult> Edit(int id, [Bind("MixIncomeId,BrancheCode,IncomeCenterId,MonthNumber,MonthName,ServatIssue,ServatRev,GoharIssue,GoharRev,TotalIssue,TotalRev")] MixProperty mixProperty)
        {
            if (id != mixProperty.MixIncomeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mixProperty);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MixPropertyExists(mixProperty.MixIncomeId))
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
            ViewData["BrancheCode"] = new SelectList(_context.BranchesInfos, "BranchCode", "BranchCode", mixProperty.BrancheCode);
            ViewData["IncomeCenterId"] = new SelectList(_context.IncomeCenters, "IncomecenterId", "IncomecenterId", mixProperty.IncomeCenterId);
            return View(mixProperty);
        }

        // GET: MixProperties/Delete/5
       // [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_عملیات)]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.MixProperties == null)
            {
                return NotFound();
            }

            var mixProperty = await _context.MixProperties
                .Include(m => m.BrancheCodeNavigation)
                .Include(m => m.IncomeCenter)
                .FirstOrDefaultAsync(m => m.MixIncomeId == id);
            if (mixProperty == null)
            {
                return NotFound();
            }

            return View(mixProperty);
        }

        // POST: MixProperties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
      //  [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_عملیات)]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.MixProperties == null)
            {
                return Problem("Entity set 'TestHadadianContext.MixProperties'  is null.");
            }
            var mixProperty = await _context.MixProperties.FindAsync(id);
            if (mixProperty != null)
            {
                _context.MixProperties.Remove(mixProperty);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MixPropertyExists(int id)
        {
          return (_context.MixProperties?.Any(e => e.MixIncomeId == id)).GetValueOrDefault();
        }
    }
}
