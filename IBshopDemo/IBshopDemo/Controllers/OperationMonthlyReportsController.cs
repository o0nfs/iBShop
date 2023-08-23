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
    public class OperationMonthlyReportsController : Controller
    {
        private readonly TestHadadianContext _context;

        public OperationMonthlyReportsController(TestHadadianContext context)
        {
            _context = context;
        }

        // GET: OperationMonthlyReports
        public async Task<IActionResult> Index()
        {
              return _context.OperationMonthlyReports != null ? 
                          View(await _context.OperationMonthlyReports.ToListAsync()) :
                          Problem("Entity set 'TestHadadianContext.OperationMonthlyReports'  is null.");
        }

        // GET: OperationMonthlyReports/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.OperationMonthlyReports == null)
            {
                return NotFound();
            }

            var operationMonthlyReport = await _context.OperationMonthlyReports
                .FirstOrDefaultAsync(m => m.Id == id);
            if (operationMonthlyReport == null)
            {
                return NotFound();
            }

            return View(operationMonthlyReport);
        }

        // GET: OperationMonthlyReports/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OperationMonthlyReports/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Oprmrid,Year,MonthNumber,Month,BillConflictReqQty,PoseConflictReqQty,SmsinternetConflictReqQty,BranchInternetConflictReqQty,IntternetEntranceConflictReq,FixedConflictQty,TotalConflictsProcess,BkgNewCustomer,BkgReqCnfqty,BkgCrdVol,BkgCrdQty,TotalIbcardIssuesVol,TotalIbcardIssuesQty,TotalTransferVol,TotalmsgQty,RemotChcAut,TotalEditAcc,TotalIdeEdit,TotalLegAut,TotalChcSejam,TotalIssuCrt,AbCganjinehTamaddon,AbCganjinehTamaddonRe,AbCganjinehShahr,AbCganjinehShahrRe,AbCganjinehSandogh,AbCganjinehSandoghRe,AbCganjinehSamaneh,AbCganjinehSamanehRe,AbCganjinehBranches,AbCganjinehBranchesRe,AbCganjinehShahrnet,AbCganjinehShahrnetRe,AbCganjinehTotal,AbCganjinehTotalRe,AbCandookhtehTamaddon,AbCandookhtehTamaddonRe,AbCandookhtehShahr,AbCandookhtehShahrRe,AbCandookhtehOtherBanks,AbCandookhtehOtherBanksRe,AbCandookhtehSandogh,AbCandookhtehSandoghRe,AbCandookhtehSamaneh,AbCandookhtehSamanehRe,AbCandookhtehBranch,AbCandookhtehBranchRe,AbCandookhtehShahrnet,AbCandookhtehShahrnetRe,AbCandookhtehTotal,AbCandookhtehTotalRe,AbCservatTamaddon,AbCservatTamaddonRe,AbCservatSamaneh,AbCservatSamanehRe,AbCservatBranch,AbCservatBranchRe,AbCservatSandogh,AbCservatSandoghRe,AbCservatTotal,AbCservatTotalRe,AbCgoharTamaddon,AbCgoharTamaddonRe,AbCgoharSamaneh,AbCgoharSamanehRe,AbCgoharBranch,AbCgoharBranchRe,AbCgoharSandogh,AbCgoharSandoghRe,AbCgoharTotal,AbCgoharTotalRe")] OperationMonthlyReport operationMonthlyReport)
        {
            if (ModelState.IsValid)
            {
                _context.Add(operationMonthlyReport);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(operationMonthlyReport);
        }

        // GET: OperationMonthlyReports/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.OperationMonthlyReports == null)
            {
                return NotFound();
            }

            var operationMonthlyReport = await _context.OperationMonthlyReports.FindAsync(id);
            if (operationMonthlyReport == null)
            {
                return NotFound();
            }
            return View(operationMonthlyReport);
        }

        // POST: OperationMonthlyReports/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Oprmrid,Year,MonthNumber,Month,BillConflictReqQty,PoseConflictReqQty,SmsinternetConflictReqQty,BranchInternetConflictReqQty,IntternetEntranceConflictReq,FixedConflictQty,TotalConflictsProcess,BkgNewCustomer,BkgReqCnfqty,BkgCrdVol,BkgCrdQty,TotalIbcardIssuesVol,TotalIbcardIssuesQty,TotalTransferVol,TotalmsgQty,RemotChcAut,TotalEditAcc,TotalIdeEdit,TotalLegAut,TotalChcSejam,TotalIssuCrt,AbCganjinehTamaddon,AbCganjinehTamaddonRe,AbCganjinehShahr,AbCganjinehShahrRe,AbCganjinehSandogh,AbCganjinehSandoghRe,AbCganjinehSamaneh,AbCganjinehSamanehRe,AbCganjinehBranches,AbCganjinehBranchesRe,AbCganjinehShahrnet,AbCganjinehShahrnetRe,AbCganjinehTotal,AbCganjinehTotalRe,AbCandookhtehTamaddon,AbCandookhtehTamaddonRe,AbCandookhtehShahr,AbCandookhtehShahrRe,AbCandookhtehOtherBanks,AbCandookhtehOtherBanksRe,AbCandookhtehSandogh,AbCandookhtehSandoghRe,AbCandookhtehSamaneh,AbCandookhtehSamanehRe,AbCandookhtehBranch,AbCandookhtehBranchRe,AbCandookhtehShahrnet,AbCandookhtehShahrnetRe,AbCandookhtehTotal,AbCandookhtehTotalRe,AbCservatTamaddon,AbCservatTamaddonRe,AbCservatSamaneh,AbCservatSamanehRe,AbCservatBranch,AbCservatBranchRe,AbCservatSandogh,AbCservatSandoghRe,AbCservatTotal,AbCservatTotalRe,AbCgoharTamaddon,AbCgoharTamaddonRe,AbCgoharSamaneh,AbCgoharSamanehRe,AbCgoharBranch,AbCgoharBranchRe,AbCgoharSandogh,AbCgoharSandoghRe,AbCgoharTotal,AbCgoharTotalRe")] OperationMonthlyReport operationMonthlyReport)
        {
            if (id != operationMonthlyReport.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(operationMonthlyReport);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OperationMonthlyReportExists(operationMonthlyReport.Id))
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
            return View(operationMonthlyReport);
        }

        // GET: OperationMonthlyReports/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.OperationMonthlyReports == null)
            {
                return NotFound();
            }

            var operationMonthlyReport = await _context.OperationMonthlyReports
                .FirstOrDefaultAsync(m => m.Id == id);
            if (operationMonthlyReport == null)
            {
                return NotFound();
            }

            return View(operationMonthlyReport);
        }

        // POST: OperationMonthlyReports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.OperationMonthlyReports == null)
            {
                return Problem("Entity set 'TestHadadianContext.OperationMonthlyReports'  is null.");
            }
            var operationMonthlyReport = await _context.OperationMonthlyReports.FindAsync(id);
            if (operationMonthlyReport != null)
            {
                _context.OperationMonthlyReports.Remove(operationMonthlyReport);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OperationMonthlyReportExists(int id)
        {
          return (_context.OperationMonthlyReports?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
