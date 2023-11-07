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
    public class ArtMonthlyReportsController : Controller
    {
        private readonly TestHadadianContext _context;

        public ArtMonthlyReportsController(TestHadadianContext context)
        {
            _context = context;
        }

        // GET: ArtMonthlyReports
        [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_گرافیک)]
        public async Task<IActionResult> Index()
        {
              return _context.ArtMonthlyReports != null ? 
                          View(await _context.ArtMonthlyReports.ToListAsync()) :
                          Problem("Entity set 'TestHadadianContext.ArtMonthlyReports'  is null.");
        }

        // GET: ArtMonthlyReports/Details/5
        [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_گرافیک)]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ArtMonthlyReports == null)
            {
                return NotFound();
            }

            var artMonthlyReport = await _context.ArtMonthlyReports
                .FirstOrDefaultAsync(m => m.ArtMonthlyReportId == id);
            if (artMonthlyReport == null)
            {
                return NotFound();
            }

            return View(artMonthlyReport);
        }

        // GET: ArtMonthlyReports/Create
        [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_گرافیک)]
        public IActionResult Create()
        {
            return View();
        }

        // POST: ArtMonthlyReports/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_گرافیک)]
        public async Task<IActionResult> Create(ArtMonthlyReport artMonthlyReport)
        {
            if (ModelState.IsValid)
            {
                _context.Add(artMonthlyReport);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(artMonthlyReport);
        }

        // GET: ArtMonthlyReports/Edit/5
       
        [Authorization((int)Roles.مدیر_گرافیک)]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ArtMonthlyReports == null)
            {
                return NotFound();
            }

            var artMonthlyReport = await _context.ArtMonthlyReports.FindAsync(id);
            if (artMonthlyReport == null)
            {
                return NotFound();
            }
            return View(artMonthlyReport);
        }

        // POST: ArtMonthlyReports/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
       
        [Authorization((int)Roles.مدیر_گرافیک)]
        public async Task<IActionResult> Edit(int id, [Bind("ArtMonthlyReportId,Year,Month,MonthNumber,MrkReq,CompStudy,ArchiveDesignQty,MediaFailureQty,SiteBannerAvgTime,BrochureDesignAvgTime,StoryDesignAvgTime,GifDesignAvgTime,StandDesignAvgTime,BannerDesignQty,BrochureDesignQty,StoryDesignQty,GifDesignQty,StandDesigQty,MotionQty,ArchivedmotionQty,AppliedMotionAvgTime,RecordedvideoQty,RecordedQty,NarrationEditQty,VideoArchiveQty,VideoProduceAvgTime")] ArtMonthlyReport artMonthlyReport)
        {
            if (id != artMonthlyReport.ArtMonthlyReportId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(artMonthlyReport);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArtMonthlyReportExists(artMonthlyReport.ArtMonthlyReportId))
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
            return View(artMonthlyReport);
        }

        // GET: ArtMonthlyReports/Delete/5
       
        [Authorization((int)Roles.مدیر_گرافیک)]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ArtMonthlyReports == null)
            {
                return NotFound();
            }

            var artMonthlyReport = await _context.ArtMonthlyReports
                .FirstOrDefaultAsync(m => m.ArtMonthlyReportId == id);
            if (artMonthlyReport == null)
            {
                return NotFound();
            }

            return View(artMonthlyReport);
        }

        // POST: ArtMonthlyReports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
		[Authorization((int)Roles.مدیر_گرافیک)]
		public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ArtMonthlyReports == null)
            {
                return Problem("Entity set 'TestHadadianContext.ArtMonthlyReports'  is null.");
            }
            var artMonthlyReport = await _context.ArtMonthlyReports.FindAsync(id);
            if (artMonthlyReport != null)
            {
                _context.ArtMonthlyReports.Remove(artMonthlyReport);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArtMonthlyReportExists(int id)
        {
          return (_context.ArtMonthlyReports?.Any(e => e.ArtMonthlyReportId == id)).GetValueOrDefault();
        }
    }
}
