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
    public class HrMonthlyReportsController : Controller
    {
        private readonly TestHadadianContext _context;

        public HrMonthlyReportsController(TestHadadianContext context)
        {
            _context = context;
        }

        // GET: HrMonthlyReports
        public async Task<IActionResult> Index()
        {
              return _context.HrMonthlyReports != null ? 
                          View(await _context.HrMonthlyReports.ToListAsync()) :
                          Problem("Entity set 'TestHadadianContext.HrMonthlyReports'  is null.");
        }

        // GET: HrMonthlyReports/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.HrMonthlyReports == null)
            {
                return NotFound();
            }

            var hrMonthlyReport = await _context.HrMonthlyReports
                .FirstOrDefaultAsync(m => m.HrmonthlyreportId == id);
            if (hrMonthlyReport == null)
            {
                return NotFound();
            }

            return View(hrMonthlyReport);
        }

        // GET: HrMonthlyReports/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HrMonthlyReports/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HrmonthlyreportId,Year,Month,MonthNumber,HrpersonnelQty,LeftQty,HrmhiredQty,Obqty,Reqqty,SentCvtoDep,CoursQty,IntQty,RsgReq,UsedImp,Gcissu,SrvAsgNewPer,AsuAsgNewPer,GurReqFun,GurReqLtt,PyrDedReqLtt,SendOutLtt,SendIntLtt,RecLtt,PerEntCnfQty,PreFailQty,ReplacemntQty,Rrfail,RrfacFail,LobFailQty,FloFailQty,TblFailQty,StrFailQty,MngRfailQty,BrkFailQty,PntFailQty")] HrMonthlyReport hrMonthlyReport)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hrMonthlyReport);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hrMonthlyReport);
        }

        // GET: HrMonthlyReports/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.HrMonthlyReports == null)
            {
                return NotFound();
            }

            var hrMonthlyReport = await _context.HrMonthlyReports.FindAsync(id);
            if (hrMonthlyReport == null)
            {
                return NotFound();
            }
            return View(hrMonthlyReport);
        }

        // POST: HrMonthlyReports/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("HrmonthlyreportId,Year,Month,MonthNumber,HrpersonnelQty,LeftQty,HrmhiredQty,Obqty,Reqqty,SentCvtoDep,CoursQty,IntQty,RsgReq,UsedImp,Gcissu,SrvAsgNewPer,AsuAsgNewPer,GurReqFun,GurReqLtt,PyrDedReqLtt,SendOutLtt,SendIntLtt,RecLtt,PerEntCnfQty,PreFailQty,ReplacemntQty,Rrfail,RrfacFail,LobFailQty,FloFailQty,TblFailQty,StrFailQty,MngRfailQty,BrkFailQty,PntFailQty")] HrMonthlyReport hrMonthlyReport)
        {
            if (id != hrMonthlyReport.HrmonthlyreportId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hrMonthlyReport);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HrMonthlyReportExists(hrMonthlyReport.HrmonthlyreportId))
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
            return View(hrMonthlyReport);
        }

        // GET: HrMonthlyReports/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.HrMonthlyReports == null)
            {
                return NotFound();
            }

            var hrMonthlyReport = await _context.HrMonthlyReports
                .FirstOrDefaultAsync(m => m.HrmonthlyreportId == id);
            if (hrMonthlyReport == null)
            {
                return NotFound();
            }

            return View(hrMonthlyReport);
        }

        // POST: HrMonthlyReports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.HrMonthlyReports == null)
            {
                return Problem("Entity set 'TestHadadianContext.HrMonthlyReports'  is null.");
            }
            var hrMonthlyReport = await _context.HrMonthlyReports.FindAsync(id);
            if (hrMonthlyReport != null)
            {
                _context.HrMonthlyReports.Remove(hrMonthlyReport);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HrMonthlyReportExists(int id)
        {
          return (_context.HrMonthlyReports?.Any(e => e.HrmonthlyreportId == id)).GetValueOrDefault();
        }
    }
}
