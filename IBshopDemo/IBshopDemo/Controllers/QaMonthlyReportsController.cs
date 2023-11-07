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
    public class QaMonthlyReportsController : Controller
    {
        private readonly TestHadadianContext _context;

        public QaMonthlyReportsController(TestHadadianContext context)
        {
            _context = context;
        }

        // GET: QaMonthlyReports
       // [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_امور_مشتریان_و_کنترل_کیفی)]
        public async Task<IActionResult> Index()
        {
              return _context.QaMonthlyReports != null ? 
                          View(await _context.QaMonthlyReports.ToListAsync()) :
                          Problem("Entity set 'TestHadadianContext.QaMonthlyReports'  is null.");
        }

        // GET: QaMonthlyReports/Details/5
      //  [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_امور_مشتریان_و_کنترل_کیفی)]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.QaMonthlyReports == null)
            {
                return NotFound();
            }

            var qaMonthlyReport = await _context.QaMonthlyReports
                .FirstOrDefaultAsync(m => m.Qamrid == id);
            if (qaMonthlyReport == null)
            {
                return NotFound();
            }

            return View(qaMonthlyReport);
        }

        // GET: QaMonthlyReports/Create
       // [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_امور_مشتریان_و_کنترل_کیفی)]
        public IActionResult Create()
        {
            return View();
        }

        // POST: QaMonthlyReports/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
      //  [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_امور_مشتریان_و_کنترل_کیفی)]
        public async Task<IActionResult> Create([Bind("Qamrid,Year,Month,MonthNumber,TotalPersonnelIncCallQty,TotalChcIncCallQty,WelFailPerIncQty,WelFailIncQty,SurFailPerIncQty,SurFailIncQty,KnwFailPerIncQty,KnwFailIncQty,ProFailPerIncQty,ProFailIncQty,TicFailPerIncQty,TicFailIncQty,CalMgtPerIncQty,CalMgtIncQty,SysFailPerIncQty,SysFailIncQty,TotalPersonnelOutCallQty,TotalChcOutCallQty,SurFailPerOutQty,SurFailOutQty,ProFailPerOutQty,ProFailOutQty,TicFailPerOutQty,TicFailOutQty,CalMgtPerOutQty,CalMgtOutQty,ToalOnlineChat,TotalCheckedOnlineChat,SurFailPerChatQty,SurFailChatQty,ProFailPerChatQty,ProFailChatQty,TicFailPerChatQty,TicFailChatQty,TimFailPerChatQty,TimFailChatQty,SurveyChatOnline,HgradeQty,GgradeQty,FgradeQty,EgradeQty,DgradeQty,CgradeQty,BgradeQty,AgradeQty,ApgradeQty,RepFail")] QaMonthlyReport qaMonthlyReport)
        {
            if (ModelState.IsValid)
            {
                _context.Add(qaMonthlyReport);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(qaMonthlyReport);
        }

        // GET: QaMonthlyReports/Edit/5
       // [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_امور_مشتریان_و_کنترل_کیفی)]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.QaMonthlyReports == null)
            {
                return NotFound();
            }

            var qaMonthlyReport = await _context.QaMonthlyReports.FindAsync(id);
            if (qaMonthlyReport == null)
            {
                return NotFound();
            }
            return View(qaMonthlyReport);
        }

        // POST: QaMonthlyReports/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
     //   [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_امور_مشتریان_و_کنترل_کیفی)]
        public async Task<IActionResult> Edit(int id, [Bind("Qamrid,Year,Month,MonthNumber,TotalPersonnelIncCallQty,TotalChcIncCallQty,WelFailPerIncQty,WelFailIncQty,SurFailPerIncQty,SurFailIncQty,KnwFailPerIncQty,KnwFailIncQty,ProFailPerIncQty,ProFailIncQty,TicFailPerIncQty,TicFailIncQty,CalMgtPerIncQty,CalMgtIncQty,SysFailPerIncQty,SysFailIncQty,TotalPersonnelOutCallQty,TotalChcOutCallQty,SurFailPerOutQty,SurFailOutQty,ProFailPerOutQty,ProFailOutQty,TicFailPerOutQty,TicFailOutQty,CalMgtPerOutQty,CalMgtOutQty,ToalOnlineChat,TotalCheckedOnlineChat,SurFailPerChatQty,SurFailChatQty,ProFailPerChatQty,ProFailChatQty,TicFailPerChatQty,TicFailChatQty,TimFailPerChatQty,TimFailChatQty,SurveyChatOnline,HgradeQty,GgradeQty,FgradeQty,EgradeQty,DgradeQty,CgradeQty,BgradeQty,AgradeQty,ApgradeQty,RepFail")] QaMonthlyReport qaMonthlyReport)
        {
            if (id != qaMonthlyReport.Qamrid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(qaMonthlyReport);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QaMonthlyReportExists(qaMonthlyReport.Qamrid))
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
            return View(qaMonthlyReport);
        }

        // GET: QaMonthlyReports/Delete/5
       // [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_امور_مشتریان_و_کنترل_کیفی)]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.QaMonthlyReports == null)
            {
                return NotFound();
            }

            var qaMonthlyReport = await _context.QaMonthlyReports
                .FirstOrDefaultAsync(m => m.Qamrid == id);
            if (qaMonthlyReport == null)
            {
                return NotFound();
            }

            return View(qaMonthlyReport);
        }

        // POST: QaMonthlyReports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
       // [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_امور_مشتریان_و_کنترل_کیفی)]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.QaMonthlyReports == null)
            {
                return Problem("Entity set 'TestHadadianContext.QaMonthlyReports'  is null.");
            }
            var qaMonthlyReport = await _context.QaMonthlyReports.FindAsync(id);
            if (qaMonthlyReport != null)
            {
                _context.QaMonthlyReports.Remove(qaMonthlyReport);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QaMonthlyReportExists(int id)
        {
          return (_context.QaMonthlyReports?.Any(e => e.Qamrid == id)).GetValueOrDefault();
        }
    }
}
