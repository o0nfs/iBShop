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
    public class ProcessDesignMonthlyReportsController : Controller
    {
        private readonly TestHadadianContext _context;

        public ProcessDesignMonthlyReportsController(TestHadadianContext context)
        {
            _context = context;
        }

        // GET: ProcessDesignMonthlyReports
       
        [Authorization((int)Roles.مدیر_برنامه_ریزی)]
        public async Task<IActionResult> Index()
        {
              return _context.ProcessDesignMonthlyReports != null ? 
                          View(await _context.ProcessDesignMonthlyReports.ToListAsync()) :
                          Problem("Entity set 'TestHadadianContext.ProcessDesignMonthlyReports'  is null.");
        }

        // GET: ProcessDesignMonthlyReports/Details/5
      
        [Authorization((int)Roles.مدیر_برنامه_ریزی)]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ProcessDesignMonthlyReports == null)
            {
                return NotFound();
            }

            var processDesignMonthlyReport = await _context.ProcessDesignMonthlyReports
                .FirstOrDefaultAsync(m => m.ProcessDesignMrid == id);
            if (processDesignMonthlyReport == null)
            {
                return NotFound();
            }

            return View(processDesignMonthlyReport);
        }

        // GET: ProcessDesignMonthlyReports/Create
       
        [Authorization((int)Roles.مدیر_برنامه_ریزی)]
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProcessDesignMonthlyReports/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
      
        [Authorization((int)Roles.مدیر_برنامه_ریزی)]
        public async Task<IActionResult> Create([Bind("ProcessDesignMrid,Year,Month,MonthNumber,PrcdQty,RelPrcdQty,InsQty,RelInsQty,RegQty,RelReqQty,FormQty,PrcDesign,ReviewPrc,AsmPrc,DlgQty,IndexQty,ReviwIndxQty,KpimonitoringQty,MrkcommHold,MrkDoneCmm,MrkFailCmm,DevCommHold,DevDoneCmm,DevFailCmm,CrmcommHold,CrmdoneCmm,CrmfailCmm")] ProcessDesignMonthlyReport processDesignMonthlyReport)
        {
            if (ModelState.IsValid)
            {
                _context.Add(processDesignMonthlyReport);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(processDesignMonthlyReport);
        }

        // GET: ProcessDesignMonthlyReports/Edit/5
       
        [Authorization((int)Roles.مدیر_برنامه_ریزی)]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ProcessDesignMonthlyReports == null)
            {
                return NotFound();
            }

            var processDesignMonthlyReport = await _context.ProcessDesignMonthlyReports.FindAsync(id);
            if (processDesignMonthlyReport == null)
            {
                return NotFound();
            }
            return View(processDesignMonthlyReport);
        }

        // POST: ProcessDesignMonthlyReports/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
       
        [Authorization((int)Roles.مدیر_برنامه_ریزی)]
        public async Task<IActionResult> Edit(int id, [Bind("ProcessDesignMrid,Year,Month,MonthNumber,PrcdQty,RelPrcdQty,InsQty,RelInsQty,RegQty,RelReqQty,FormQty,PrcDesign,ReviewPrc,AsmPrc,DlgQty,IndexQty,ReviwIndxQty,KpimonitoringQty,MrkcommHold,MrkDoneCmm,MrkFailCmm,DevCommHold,DevDoneCmm,DevFailCmm,CrmcommHold,CrmdoneCmm,CrmfailCmm")] ProcessDesignMonthlyReport processDesignMonthlyReport)
        {
            if (id != processDesignMonthlyReport.ProcessDesignMrid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(processDesignMonthlyReport);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProcessDesignMonthlyReportExists(processDesignMonthlyReport.ProcessDesignMrid))
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
            return View(processDesignMonthlyReport);
        }

        // GET: ProcessDesignMonthlyReports/Delete/5
       
        [Authorization((int)Roles.مدیر_برنامه_ریزی)]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ProcessDesignMonthlyReports == null)
            {
                return NotFound();
            }

            var processDesignMonthlyReport = await _context.ProcessDesignMonthlyReports
                .FirstOrDefaultAsync(m => m.ProcessDesignMrid == id);
            if (processDesignMonthlyReport == null)
            {
                return NotFound();
            }

            return View(processDesignMonthlyReport);
        }

        // POST: ProcessDesignMonthlyReports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
       
        [Authorization((int)Roles.مدیر_برنامه_ریزی)]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ProcessDesignMonthlyReports == null)
            {
                return Problem("Entity set 'TestHadadianContext.ProcessDesignMonthlyReports'  is null.");
            }
            var processDesignMonthlyReport = await _context.ProcessDesignMonthlyReports.FindAsync(id);
            if (processDesignMonthlyReport != null)
            {
                _context.ProcessDesignMonthlyReports.Remove(processDesignMonthlyReport);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProcessDesignMonthlyReportExists(int id)
        {
          return (_context.ProcessDesignMonthlyReports?.Any(e => e.ProcessDesignMrid == id)).GetValueOrDefault();
        }
    }
}
