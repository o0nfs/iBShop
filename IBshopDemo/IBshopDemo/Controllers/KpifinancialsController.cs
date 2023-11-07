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
    public class KpifinancialsController : Controller
    {
        private readonly TestHadadianContext _context;

        public KpifinancialsController(TestHadadianContext context)
        {
            _context = context;
        }

        // GET: Kpifinancials
   
        [Authorization((int)Roles.مدیر_امور_مالی)]
        public async Task<IActionResult> Index()
        {
              return _context.Kpifinancials != null ? 
                          View(await _context.Kpifinancials.ToListAsync()) :
                          Problem("Entity set 'TestHadadianContext.Kpifinancials'  is null.");
        }

        // GET: Kpifinancials/Details/5
      
        [Authorization((int)Roles.مدیر_امور_مالی)]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Kpifinancials == null)
            {
                return NotFound();
            }

            var kpifinancial = await _context.Kpifinancials
                .FirstOrDefaultAsync(m => m.Id == id);
            if (kpifinancial == null)
            {
                return NotFound();
            }

            return View(kpifinancial);
        }

        // GET: Kpifinancials/Create
       
        [Authorization((int)Roles.مدیر_امور_مالی)]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Kpifinancials/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
      
        [Authorization((int)Roles.مدیر_امور_مالی)]
        public async Task<IActionResult> Create([Bind("Id,KpifinCode,OtdecLegRe,RvwAccConflicts,RvwInvConflicts,DevPlnBudPer,IncBudMeetPer,DemistakeFin,AcrFinRepPer,Cnt,CtrTimeDuration,FixedAssetConflict,BillIssueAvgTime,CnrctrInvoicesMatch,OdrecintotalRec")] Kpifinancial kpifinancial)
        {
            if (ModelState.IsValid)
            {
                _context.Add(kpifinancial);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(kpifinancial);
        }

        // GET: Kpifinancials/Edit/5
       
        [Authorization((int)Roles.مدیر_امور_مالی)]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Kpifinancials == null)
            {
                return NotFound();
            }

            var kpifinancial = await _context.Kpifinancials.FindAsync(id);
            if (kpifinancial == null)
            {
                return NotFound();
            }
            return View(kpifinancial);
        }

        // POST: Kpifinancials/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
       
        [Authorization((int)Roles.مدیر_امور_مالی)]
        public async Task<IActionResult> Edit(int id, [Bind("Id,KpifinCode,OtdecLegRe,RvwAccConflicts,RvwInvConflicts,DevPlnBudPer,IncBudMeetPer,DemistakeFin,AcrFinRepPer,Cnt,CtrTimeDuration,FixedAssetConflict,BillIssueAvgTime,CnrctrInvoicesMatch,OdrecintotalRec")] Kpifinancial kpifinancial)
        {
            if (id != kpifinancial.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kpifinancial);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KpifinancialExists(kpifinancial.Id))
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
            return View(kpifinancial);
        }

        // GET: Kpifinancials/Delete/5
        
        [Authorization((int)Roles.مدیر_امور_مالی)]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Kpifinancials == null)
            {
                return NotFound();
            }

            var kpifinancial = await _context.Kpifinancials
                .FirstOrDefaultAsync(m => m.Id == id);
            if (kpifinancial == null)
            {
                return NotFound();
            }

            return View(kpifinancial);
        }

        // POST: Kpifinancials/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
       
        [Authorization((int)Roles.مدیر_امور_مالی)]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Kpifinancials == null)
            {
                return Problem("Entity set 'TestHadadianContext.Kpifinancials'  is null.");
            }
            var kpifinancial = await _context.Kpifinancials.FindAsync(id);
            if (kpifinancial != null)
            {
                _context.Kpifinancials.Remove(kpifinancial);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KpifinancialExists(int id)
        {
          return (_context.Kpifinancials?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
