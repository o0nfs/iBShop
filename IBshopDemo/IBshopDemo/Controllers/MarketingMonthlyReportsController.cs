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
    public class MarketingMonthlyReportsController : Controller
    {
        private readonly TestHadadianContext _context;

        public MarketingMonthlyReportsController(TestHadadianContext context)
        {
            _context = context;
        }

        // GET: MarketingMonthlyReports
        ///[Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_بازاریابی)]
        public async Task<IActionResult> Index()
        {
              return _context.MarketingMonthlyReports != null ? 
                          View(await _context.MarketingMonthlyReports.ToListAsync()) :
                          Problem("Entity set 'TestHadadianContext.MarketingMonthlyReports'  is null.");
        }

        // GET: MarketingMonthlyReports/Details/5
        //[Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_بازاریابی)]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.MarketingMonthlyReports == null)
            {
                return NotFound();
            }

            var marketingMonthlyReport = await _context.MarketingMonthlyReports
                .FirstOrDefaultAsync(m => m.Mrkmrid == id);
            if (marketingMonthlyReport == null)
            {
                return NotFound();
            }

            return View(marketingMonthlyReport);
        }

        // GET: MarketingMonthlyReports/Create
        //[Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_بازاریابی)]
        public IActionResult Create()
        {
            return View();
        }

        // POST: MarketingMonthlyReports/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //[Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_بازاریابی)]
        public async Task<IActionResult> Create([Bind("Mrkmrid,Year,Month,MonthNumber,SentSmsQty,ReportAdvQty,NotifPushQty,PostMediaQty,StateMedAdvQty,BilboardQty,SrchEntQty,RefEntQty,SmedEntQty,SiteEntMonthlyAvg,InstFlwQty,EngQty,TlgPostContentQty,LinkdinContentQty,DesignQty,VideoQty,HoldQty,HoldComptQty,RecVidPostQty,TrainPostQty,InsFlwQty,NewsQty,TrainingCntrctQty,IbcrowdCalllegalCusQty,PrdSrvAdvCallQty,SucCallQty,ToalInvestVol,ConversationRate,BounceRate,KeywordsRank,GoogleEntTerRate,LinkEntTerRate")] MarketingMonthlyReport marketingMonthlyReport)
        {
            if (ModelState.IsValid)
            {
                _context.Add(marketingMonthlyReport);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(marketingMonthlyReport);
        }

        // GET: MarketingMonthlyReports/Edit/5
       // [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_بازاریابی)]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.MarketingMonthlyReports == null)
            {
                return NotFound();
            }

            var marketingMonthlyReport = await _context.MarketingMonthlyReports.FindAsync(id);
            if (marketingMonthlyReport == null)
            {
                return NotFound();
            }
            return View(marketingMonthlyReport);
        }

        // POST: MarketingMonthlyReports/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
       // [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_بازاریابی)]
        public async Task<IActionResult> Edit(int id, [Bind("Mrkmrid,Year,Month,MonthNumber,SentSmsQty,ReportAdvQty,NotifPushQty,PostMediaQty,StateMedAdvQty,BilboardQty,SrchEntQty,RefEntQty,SmedEntQty,SiteEntMonthlyAvg,InstFlwQty,EngQty,TlgPostContentQty,LinkdinContentQty,DesignQty,VideoQty,HoldQty,HoldComptQty,RecVidPostQty,TrainPostQty,InsFlwQty,NewsQty,TrainingCntrctQty,IbcrowdCalllegalCusQty,PrdSrvAdvCallQty,SucCallQty,ToalInvestVol,ConversationRate,BounceRate,KeywordsRank,GoogleEntTerRate,LinkEntTerRate")] MarketingMonthlyReport marketingMonthlyReport)
        {
            if (id != marketingMonthlyReport.Mrkmrid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(marketingMonthlyReport);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MarketingMonthlyReportExists(marketingMonthlyReport.Mrkmrid))
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
            return View(marketingMonthlyReport);
        }

        // GET: MarketingMonthlyReports/Delete/5
       // [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_بازاریابی)]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.MarketingMonthlyReports == null)
            {
                return NotFound();
            }

            var marketingMonthlyReport = await _context.MarketingMonthlyReports
                .FirstOrDefaultAsync(m => m.Mrkmrid == id);
            if (marketingMonthlyReport == null)
            {
                return NotFound();
            }

            return View(marketingMonthlyReport);
        }

        // POST: MarketingMonthlyReports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
      //  [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_بازاریابی)]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.MarketingMonthlyReports == null)
            {
                return Problem("Entity set 'TestHadadianContext.MarketingMonthlyReports'  is null.");
            }
            var marketingMonthlyReport = await _context.MarketingMonthlyReports.FindAsync(id);
            if (marketingMonthlyReport != null)
            {
                _context.MarketingMonthlyReports.Remove(marketingMonthlyReport);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MarketingMonthlyReportExists(int id)
        {
          return (_context.MarketingMonthlyReports?.Any(e => e.Mrkmrid == id)).GetValueOrDefault();
        }
    }
}
