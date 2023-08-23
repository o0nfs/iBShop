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
    public class BranchesMonthlyReportsController : Controller
    {
        private readonly TestHadadianContext _context;

        public BranchesMonthlyReportsController(TestHadadianContext context)
        {
            _context = context;
        }

        // GET: BranchesMonthlyReports
        public async Task<IActionResult> Index()
        {
              return _context.BranchesMonthlyReports != null ? 
                          View(await _context.BranchesMonthlyReports.ToListAsync()) :
                          Problem("Entity set 'TestHadadianContext.BranchesMonthlyReports'  is null.");
        }

        // GET: BranchesMonthlyReports/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.BranchesMonthlyReports == null)
            {
                return NotFound();
            }

            var branchesMonthlyReport = await _context.BranchesMonthlyReports
                .FirstOrDefaultAsync(m => m.BranchMonthlyReportId == id);
            if (branchesMonthlyReport == null)
            {
                return NotFound();
            }

            return View(branchesMonthlyReport);
        }

        // GET: BranchesMonthlyReports/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BranchesMonthlyReports/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BranchMonthlyReportId,Year,Month,MonthNumber,IbcardConflictBranchQty,IbcrowdConflictBranchQty,IBcrowdKpiconflictQty,CoursesQty,OnlineExamsQty,CoursesNeedQty,ServicesToBranchQty,CandstoDevelopmentQty,ReportsConflictsToBranchQty,InvestmentCapitalConflicts,FacilityReqQty,SwsolvedQty,FundSettlementQty,FundsConflictsQty,SendtoBranch,MrkpacTobranchQty,CrttoCusQty,InpersonBranchQty,BranchTickects,TicketConflictsQty,BranchInfractionQty,BranchReformQty,BranchMonQty,BranchCompCheckedQty,AccBranchQty,BranchCompQty,BranchpersonnelQty,PersonnelAssuranceReqQty,PersonnelAdReqQty")] BranchesMonthlyReport branchesMonthlyReport)
        {
            if (ModelState.IsValid)
            {
                _context.Add(branchesMonthlyReport);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(branchesMonthlyReport);
        }

        // GET: BranchesMonthlyReports/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.BranchesMonthlyReports == null)
            {
                return NotFound();
            }

            var branchesMonthlyReport = await _context.BranchesMonthlyReports.FindAsync(id);
            if (branchesMonthlyReport == null)
            {
                return NotFound();
            }
            return View(branchesMonthlyReport);
        }

        // POST: BranchesMonthlyReports/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BranchMonthlyReportId,Year,Month,MonthNumber,IbcardConflictBranchQty,IbcrowdConflictBranchQty,IBcrowdKpiconflictQty,CoursesQty,OnlineExamsQty,CoursesNeedQty,ServicesToBranchQty,CandstoDevelopmentQty,ReportsConflictsToBranchQty,InvestmentCapitalConflicts,FacilityReqQty,SwsolvedQty,FundSettlementQty,FundsConflictsQty,SendtoBranch,MrkpacTobranchQty,CrttoCusQty,InpersonBranchQty,BranchTickects,TicketConflictsQty,BranchInfractionQty,BranchReformQty,BranchMonQty,BranchCompCheckedQty,AccBranchQty,BranchCompQty,BranchpersonnelQty,PersonnelAssuranceReqQty,PersonnelAdReqQty")] BranchesMonthlyReport branchesMonthlyReport)
        {
            if (id != branchesMonthlyReport.BranchMonthlyReportId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(branchesMonthlyReport);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BranchesMonthlyReportExists(branchesMonthlyReport.BranchMonthlyReportId))
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
            return View(branchesMonthlyReport);
        }

        // GET: BranchesMonthlyReports/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.BranchesMonthlyReports == null)
            {
                return NotFound();
            }

            var branchesMonthlyReport = await _context.BranchesMonthlyReports
                .FirstOrDefaultAsync(m => m.BranchMonthlyReportId == id);
            if (branchesMonthlyReport == null)
            {
                return NotFound();
            }

            return View(branchesMonthlyReport);
        }

        // POST: BranchesMonthlyReports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.BranchesMonthlyReports == null)
            {
                return Problem("Entity set 'TestHadadianContext.BranchesMonthlyReports'  is null.");
            }
            var branchesMonthlyReport = await _context.BranchesMonthlyReports.FindAsync(id);
            if (branchesMonthlyReport != null)
            {
                _context.BranchesMonthlyReports.Remove(branchesMonthlyReport);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BranchesMonthlyReportExists(int id)
        {
          return (_context.BranchesMonthlyReports?.Any(e => e.BranchMonthlyReportId == id)).GetValueOrDefault();
        }
    }
}
