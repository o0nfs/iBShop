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
    public class KpicrmsController : Controller
    {
        private readonly TestHadadianContext _context;

        public KpicrmsController(TestHadadianContext context)
        {
            _context = context;
        }

        // GET: Kpicrms
        public async Task<IActionResult> Index()
        {
              return _context.Kpicrms != null ? 
                          View(await _context.Kpicrms.ToListAsync()) :
                          Problem("Entity set 'TestHadadianContext.Kpicrms'  is null.");
        }

        // GET: Kpicrms/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Kpicrms == null)
            {
                return NotFound();
            }

            var kpicrm = await _context.Kpicrms
                .FirstOrDefaultAsync(m => m.Kpicrmcode == id);
            if (kpicrm == null)
            {
                return NotFound();
            }

            return View(kpicrm);
        }

        // GET: Kpicrms/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Kpicrms/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Kpicrmcode,NegFb,HocallQty,Fcsp,CusReqMetPer,CusSat,MissedCallPercent,AutAnsPercent,LeftCallPercent,SrvPrdSatPer,DelAvr,CallAnsSpd,Wtunder3,CallDuration,OutcallCostAvg,CallAnsSat,UsersComImpSer,TicQty,IdeCusNeed,PrdAwaPer,PerImpPrdSur,NewtooldSat,Csat,MrkOutcall,Crmiss")] Kpicrm kpicrm)
        {
            if (ModelState.IsValid)
            {
                _context.Add(kpicrm);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(kpicrm);
        }

        // GET: Kpicrms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Kpicrms == null)
            {
                return NotFound();
            }

            var kpicrm = await _context.Kpicrms.FindAsync(id);
            if (kpicrm == null)
            {
                return NotFound();
            }
            return View(kpicrm);
        }

        // POST: Kpicrms/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Kpicrmcode,NegFb,HocallQty,Fcsp,CusReqMetPer,CusSat,MissedCallPercent,AutAnsPercent,LeftCallPercent,SrvPrdSatPer,DelAvr,CallAnsSpd,Wtunder3,CallDuration,OutcallCostAvg,CallAnsSat,UsersComImpSer,TicQty,IdeCusNeed,PrdAwaPer,PerImpPrdSur,NewtooldSat,Csat,MrkOutcall,Crmiss")] Kpicrm kpicrm)
        {
            if (id != kpicrm.Kpicrmcode)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kpicrm);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KpicrmExists(kpicrm.Kpicrmcode))
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
            return View(kpicrm);
        }

        // GET: Kpicrms/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Kpicrms == null)
            {
                return NotFound();
            }

            var kpicrm = await _context.Kpicrms
                .FirstOrDefaultAsync(m => m.Kpicrmcode == id);
            if (kpicrm == null)
            {
                return NotFound();
            }

            return View(kpicrm);
        }

        // POST: Kpicrms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Kpicrms == null)
            {
                return Problem("Entity set 'TestHadadianContext.Kpicrms'  is null.");
            }
            var kpicrm = await _context.Kpicrms.FindAsync(id);
            if (kpicrm != null)
            {
                _context.Kpicrms.Remove(kpicrm);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KpicrmExists(int id)
        {
          return (_context.Kpicrms?.Any(e => e.Kpicrmcode == id)).GetValueOrDefault();
        }
    }
}
