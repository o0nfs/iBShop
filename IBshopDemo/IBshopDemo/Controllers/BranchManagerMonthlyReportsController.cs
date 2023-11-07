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
    public class BranchManagerMonthlyReportsController : Controller
    {
        private readonly TestHadadianContext _context;

        public BranchManagerMonthlyReportsController(TestHadadianContext context)
        {
            _context = context;
        }

        // GET: BranchManagerMonthlyReports
        //[Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_امور_شعب)]
        public async Task<IActionResult> Index()
        {
              return _context.BranchManagerMonthlyReports != null ? 
                          View(await _context.BranchManagerMonthlyReports.ToListAsync()) :
                          Problem("Entity set 'TestHadadianContext.BranchManagerMonthlyReports'  is null.");
        }

        // GET: BranchManagerMonthlyReports/Details/5
        //[Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_امور_شعب)]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.BranchManagerMonthlyReports == null)
            {
                return NotFound();
            }

            var branchManagerMonthlyReport = await _context.BranchManagerMonthlyReports
                .FirstOrDefaultAsync(m => m.BranchManagerMonthlyReportIdBranchManagerMonthlyReportId == id);
            if (branchManagerMonthlyReport == null)
            {
                return NotFound();
            }

            return View(branchManagerMonthlyReport);
        }

        // GET: BranchManagerMonthlyReports/Create
       // [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_امور_شعب)]
        public IActionResult Create()
        {
            return View();
        }

        // POST: BranchManagerMonthlyReports/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
      //  [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_امور_شعب)]
        public async Task<IActionResult> Create([Bind("BranchManagerMonthlyReportIdBranchManagerMonthlyReportId,Year,Month,MonthNumber,BranchCode,BranchLocation,IBcardMrkmtgqty,IBcardSuccessMtgqty,IBcrowdMrkmtgqty,IBcrowdSuccessMtgqty,AssuranceMrkmtgqty,AssuranceSuccessMtgqty,DebtSharesMrkmtgqty,DebtSharesSuccessMtgqty,InvestmentMrkmtgqty,InvesmentSuccessMtgqty,CoursesReq,CoursesMrkmtgqty,CoursesMrkmtgfirstAgreementQty,ComplainantQty,Conciliation")] BranchManagerMonthlyReport branchManagerMonthlyReport)
        {
            if (ModelState.IsValid)
            {
                _context.Add(branchManagerMonthlyReport);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(branchManagerMonthlyReport);
        }

        // GET: BranchManagerMonthlyReports/Edit/5
       // [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_امور_شعب)]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.BranchManagerMonthlyReports == null)
            {
                return NotFound();
            }

            var branchManagerMonthlyReport = await _context.BranchManagerMonthlyReports.FindAsync(id);
            if (branchManagerMonthlyReport == null)
            {
                return NotFound();
            }
            return View(branchManagerMonthlyReport);
        }

        // POST: BranchManagerMonthlyReports/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
       // [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_امور_شعب)]
        public async Task<IActionResult> Edit(int id, [Bind("BranchManagerMonthlyReportIdBranchManagerMonthlyReportId,Year,Month,MonthNumber,BranchCode,BranchLocation,IBcardMrkmtgqty,IBcardSuccessMtgqty,IBcrowdMrkmtgqty,IBcrowdSuccessMtgqty,AssuranceMrkmtgqty,AssuranceSuccessMtgqty,DebtSharesMrkmtgqty,DebtSharesSuccessMtgqty,InvestmentMrkmtgqty,InvesmentSuccessMtgqty,CoursesReq,CoursesMrkmtgqty,CoursesMrkmtgfirstAgreementQty,ComplainantQty,Conciliation")] BranchManagerMonthlyReport branchManagerMonthlyReport)
        {
            if (id != branchManagerMonthlyReport.BranchManagerMonthlyReportIdBranchManagerMonthlyReportId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(branchManagerMonthlyReport);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BranchManagerMonthlyReportExists(branchManagerMonthlyReport.BranchManagerMonthlyReportIdBranchManagerMonthlyReportId))
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
            return View(branchManagerMonthlyReport);
        }

        // GET: BranchManagerMonthlyReports/Delete/5
     //   [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_امور_شعب)]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.BranchManagerMonthlyReports == null)
            {
                return NotFound();
            }

            var branchManagerMonthlyReport = await _context.BranchManagerMonthlyReports
                .FirstOrDefaultAsync(m => m.BranchManagerMonthlyReportIdBranchManagerMonthlyReportId == id);
            if (branchManagerMonthlyReport == null)
            {
                return NotFound();
            }

            return View(branchManagerMonthlyReport);
        }

        // POST: BranchManagerMonthlyReports/Delete/5
       // [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_امور_شعب)]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.BranchManagerMonthlyReports == null)
            {
                return Problem("Entity set 'TestHadadianContext.BranchManagerMonthlyReports'  is null.");
            }
            var branchManagerMonthlyReport = await _context.BranchManagerMonthlyReports.FindAsync(id);
            if (branchManagerMonthlyReport != null)
            {
                _context.BranchManagerMonthlyReports.Remove(branchManagerMonthlyReport);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BranchManagerMonthlyReportExists(int id)
        {
          return (_context.BranchManagerMonthlyReports?.Any(e => e.BranchManagerMonthlyReportIdBranchManagerMonthlyReportId == id)).GetValueOrDefault();
        }
    }
}
