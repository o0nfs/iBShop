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
    public class FinancialSuperMarketMonthlyReportsController : Controller
    {
        private readonly TestHadadianContext _context;

        public FinancialSuperMarketMonthlyReportsController(TestHadadianContext context)
        {
            _context = context;
        }

        // GET: FinancialSuperMarketMonthlyReports
        public async Task<IActionResult> Index()
        {
              return _context.FinancialSuperMarketMonthlyReports != null ? 
                          View(await _context.FinancialSuperMarketMonthlyReports.ToListAsync()) :
                          Problem("Entity set 'TestHadadianContext.FinancialSuperMarketMonthlyReports'  is null.");
        }

        // GET: FinancialSuperMarketMonthlyReports/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.FinancialSuperMarketMonthlyReports == null)
            {
                return NotFound();
            }

            var financialSuperMarketMonthlyReport = await _context.FinancialSuperMarketMonthlyReports
                .FirstOrDefaultAsync(m => m.SuperMrid == id);
            if (financialSuperMarketMonthlyReport == null)
            {
                return NotFound();
            }

            return View(financialSuperMarketMonthlyReport);
        }

        // GET: FinancialSuperMarketMonthlyReports/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FinancialSuperMarketMonthlyReports/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SuperMrid,Year,Month,MonthNumber,CustomersReplyQty,IbshoppRegisterQty,AuthenticationQty,ActivationQty,ReportForCustomerC,ReportForCustomerF,GanjinehIssueReqQty,GanjinehIssuesVol,AndookhtehIssueReqQty,AndookhtehIssuesVol,GoharandServatIssueReqQty,GohrandServatIssuesVol,GanjinehRevokeReqQty,GanjinehRevokeVol,AndookhtehRevokeReqQty,AndookhtehRevokeVol,GoharandServatRevokeReqQty,GohrandServatRevokeVol,TotIsuuVol,TotRevVol,EditQty,LegalServQty,CardIssuanceQty,TotalIbcardVol,InvestorsQty,TotalIbcrowdVol,InsuranceIssued,CreaditQty,CreaditVol,OnlineCodeQty")] FinancialSuperMarketMonthlyReport financialSuperMarketMonthlyReport)
        {
            if (ModelState.IsValid)
            {
                _context.Add(financialSuperMarketMonthlyReport);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(financialSuperMarketMonthlyReport);
        }

        // GET: FinancialSuperMarketMonthlyReports/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.FinancialSuperMarketMonthlyReports == null)
            {
                return NotFound();
            }

            var financialSuperMarketMonthlyReport = await _context.FinancialSuperMarketMonthlyReports.FindAsync(id);
            if (financialSuperMarketMonthlyReport == null)
            {
                return NotFound();
            }
            return View(financialSuperMarketMonthlyReport);
        }

        // POST: FinancialSuperMarketMonthlyReports/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SuperMrid,Year,Month,MonthNumber,CustomersReplyQty,IbshoppRegisterQty,AuthenticationQty,ActivationQty,ReportForCustomerC,ReportForCustomerF,GanjinehIssueReqQty,GanjinehIssuesVol,AndookhtehIssueReqQty,AndookhtehIssuesVol,GoharandServatIssueReqQty,GohrandServatIssuesVol,GanjinehRevokeReqQty,GanjinehRevokeVol,AndookhtehRevokeReqQty,AndookhtehRevokeVol,GoharandServatRevokeReqQty,GohrandServatRevokeVol,TotIsuuVol,TotRevVol,EditQty,LegalServQty,CardIssuanceQty,TotalIbcardVol,InvestorsQty,TotalIbcrowdVol,InsuranceIssued,CreaditQty,CreaditVol,OnlineCodeQty")] FinancialSuperMarketMonthlyReport financialSuperMarketMonthlyReport)
        {
            if (id != financialSuperMarketMonthlyReport.SuperMrid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(financialSuperMarketMonthlyReport);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FinancialSuperMarketMonthlyReportExists(financialSuperMarketMonthlyReport.SuperMrid))
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
            return View(financialSuperMarketMonthlyReport);
        }

        // GET: FinancialSuperMarketMonthlyReports/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.FinancialSuperMarketMonthlyReports == null)
            {
                return NotFound();
            }

            var financialSuperMarketMonthlyReport = await _context.FinancialSuperMarketMonthlyReports
                .FirstOrDefaultAsync(m => m.SuperMrid == id);
            if (financialSuperMarketMonthlyReport == null)
            {
                return NotFound();
            }

            return View(financialSuperMarketMonthlyReport);
        }

        // POST: FinancialSuperMarketMonthlyReports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.FinancialSuperMarketMonthlyReports == null)
            {
                return Problem("Entity set 'TestHadadianContext.FinancialSuperMarketMonthlyReports'  is null.");
            }
            var financialSuperMarketMonthlyReport = await _context.FinancialSuperMarketMonthlyReports.FindAsync(id);
            if (financialSuperMarketMonthlyReport != null)
            {
                _context.FinancialSuperMarketMonthlyReports.Remove(financialSuperMarketMonthlyReport);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FinancialSuperMarketMonthlyReportExists(int id)
        {
          return (_context.FinancialSuperMarketMonthlyReports?.Any(e => e.SuperMrid == id)).GetValueOrDefault();
        }
    }
}
