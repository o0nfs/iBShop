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
    public class KpihrsController : Controller
    {
        private readonly TestHadadianContext _context;

        public KpihrsController(TestHadadianContext context)
        {
            _context = context;
        }

        // GET: Kpihrs
        public async Task<IActionResult> Index()
        {
              return _context.Kpihrs != null ? 
                          View(await _context.Kpihrs.ToListAsync()) :
                          Problem("Entity set 'TestHadadianContext.Kpihrs'  is null.");
        }

        // GET: Kpihrs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Kpihrs == null)
            {
                return NotFound();
            }

            var kpihr = await _context.Kpihrs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (kpihr == null)
            {
                return NotFound();
            }

            return View(kpihr);
        }

        // GET: Kpihrs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Kpihrs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Kpihrcode,RecEff,EduEfc,SurveyFeedback,TrnColeagPer,MistakeinPersonalInfo,SalMistakePerc,ColLoyPer,EduCap,ProEduCap,MgmEduCap,GenEduCap,PapConCap,IntColCam,ReqToNeed,IctsrvSat,ColSat,OutcallCostAvg,RecDelRat,HrRecDelRat,Sal")] Kpihr kpihr)
        {
            if (ModelState.IsValid)
            {
                _context.Add(kpihr);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(kpihr);
        }

        // GET: Kpihrs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Kpihrs == null)
            {
                return NotFound();
            }

            var kpihr = await _context.Kpihrs.FindAsync(id);
            if (kpihr == null)
            {
                return NotFound();
            }
            return View(kpihr);
        }

        // POST: Kpihrs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Kpihrcode,RecEff,EduEfc,SurveyFeedback,TrnColeagPer,MistakeinPersonalInfo,SalMistakePerc,ColLoyPer,EduCap,ProEduCap,MgmEduCap,GenEduCap,PapConCap,IntColCam,ReqToNeed,IctsrvSat,ColSat,OutcallCostAvg,RecDelRat,HrRecDelRat,Sal")] Kpihr kpihr)
        {
            if (id != kpihr.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kpihr);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KpihrExists(kpihr.Id))
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
            return View(kpihr);
        }

        // GET: Kpihrs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Kpihrs == null)
            {
                return NotFound();
            }

            var kpihr = await _context.Kpihrs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (kpihr == null)
            {
                return NotFound();
            }

            return View(kpihr);
        }

        // POST: Kpihrs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Kpihrs == null)
            {
                return Problem("Entity set 'TestHadadianContext.Kpihrs'  is null.");
            }
            var kpihr = await _context.Kpihrs.FindAsync(id);
            if (kpihr != null)
            {
                _context.Kpihrs.Remove(kpihr);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KpihrExists(int id)
        {
          return (_context.Kpihrs?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
