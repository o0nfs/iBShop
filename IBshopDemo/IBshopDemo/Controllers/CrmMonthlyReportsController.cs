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
    public class CrmMonthlyReportsController : Controller
    {
        private readonly TestHadadianContext _context;

        public CrmMonthlyReportsController(TestHadadianContext context)
        {
            _context = context;
        }

        // GET: CrmMonthlyReports
        public async Task<IActionResult> Index()
        {
              return _context.CrmMonthlyReports != null ? 
                          View(await _context.CrmMonthlyReports.ToListAsync()) :
                          Problem("Entity set 'TestHadadianContext.CrmMonthlyReports'  is null.");
        }

        // GET: CrmMonthlyReports/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.CrmMonthlyReports == null)
            {
                return NotFound();
            }

            var crmMonthlyReport = await _context.CrmMonthlyReports
                .FirstOrDefaultAsync(m => m.Crmmrid == id);
            if (crmMonthlyReport == null)
            {
                return NotFound();
            }

            return View(crmMonthlyReport);
        }

        // GET: CrmMonthlyReports/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CrmMonthlyReports/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Crmmrid,Year,Month,MonthNumber,InChatQty,InCompCallQty,InVmQty,InCallQty,OutAccNumEditQty,OutsurveyQty,OutComTrtQty,OutVmQty,SejamQty,AvgCallDuration,AvgCallWaitingDuration,ToalCallDuration,GanjinehIssuesQty,GanjinehIssuesVol,AndookhtehIssuesQty,AndookhtehIssuesVol,GoharandServatIssuesQty,GoharandServatIssuesVol,TotalIssuesQty,TotalIssuesVol,CrmcoursesQty,TicketOnlineQty,Inticket,ComplaintTicketQty,SurveyTicketQty,InSurveyCallQty,OutSurveyCallQty,OnlineChatsurveyQty,GanjinehTicketQty,AndookhtehicketQty,ServatafarinanTicketQty,GoharTicketQty,IbCardTicketQty,IbCrowdTicketQty,BranchComplTicketQty")] CrmMonthlyReport crmMonthlyReport)
        {
            if (ModelState.IsValid)
            {
                _context.Add(crmMonthlyReport);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(crmMonthlyReport);
        }

        // GET: CrmMonthlyReports/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.CrmMonthlyReports == null)
            {
                return NotFound();
            }

            var crmMonthlyReport = await _context.CrmMonthlyReports.FindAsync(id);
            if (crmMonthlyReport == null)
            {
                return NotFound();
            }
            return View(crmMonthlyReport);
        }

        // POST: CrmMonthlyReports/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Crmmrid,Year,Month,MonthNumber,InChatQty,InCompCallQty,InVmQty,InCallQty,OutAccNumEditQty,OutsurveyQty,OutComTrtQty,OutVmQty,SejamQty,AvgCallDuration,AvgCallWaitingDuration,ToalCallDuration,GanjinehIssuesQty,GanjinehIssuesVol,AndookhtehIssuesQty,AndookhtehIssuesVol,GoharandServatIssuesQty,GoharandServatIssuesVol,TotalIssuesQty,TotalIssuesVol,CrmcoursesQty,TicketOnlineQty,Inticket,ComplaintTicketQty,SurveyTicketQty,InSurveyCallQty,OutSurveyCallQty,OnlineChatsurveyQty,GanjinehTicketQty,AndookhtehicketQty,ServatafarinanTicketQty,GoharTicketQty,IbCardTicketQty,IbCrowdTicketQty,BranchComplTicketQty")] CrmMonthlyReport crmMonthlyReport)
        {
            if (id != crmMonthlyReport.Crmmrid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(crmMonthlyReport);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CrmMonthlyReportExists(crmMonthlyReport.Crmmrid))
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
            return View(crmMonthlyReport);
        }

        // GET: CrmMonthlyReports/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.CrmMonthlyReports == null)
            {
                return NotFound();
            }

            var crmMonthlyReport = await _context.CrmMonthlyReports
                .FirstOrDefaultAsync(m => m.Crmmrid == id);
            if (crmMonthlyReport == null)
            {
                return NotFound();
            }

            return View(crmMonthlyReport);
        }

        // POST: CrmMonthlyReports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CrmMonthlyReports == null)
            {
                return Problem("Entity set 'TestHadadianContext.CrmMonthlyReports'  is null.");
            }
            var crmMonthlyReport = await _context.CrmMonthlyReports.FindAsync(id);
            if (crmMonthlyReport != null)
            {
                _context.CrmMonthlyReports.Remove(crmMonthlyReport);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CrmMonthlyReportExists(int id)
        {
          return (_context.CrmMonthlyReports?.Any(e => e.Crmmrid == id)).GetValueOrDefault();
        }
    }
}
