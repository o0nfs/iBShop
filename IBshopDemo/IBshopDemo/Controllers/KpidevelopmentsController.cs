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
    public class KpidevelopmentsController : Controller
    {
        private readonly TestHadadianContext _context;

        public KpidevelopmentsController(TestHadadianContext context)
        {
            _context = context;
        }

        // GET: Kpidevelopments
      
        [Authorization((int)Roles.مدیر_برنامه_ریزی)]
        public async Task<IActionResult> Index()
        {
              return _context.Kpidevelopments != null ? 
                          View(await _context.Kpidevelopments.ToListAsync()) :
                          Problem("Entity set 'TestHadadianContext.Kpidevelopments'  is null.");
        }

        // GET: Kpidevelopments/Details/5
      
        [Authorization((int)Roles.مدیر_برنامه_ریزی)]
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Kpidevelopments == null)
            {
                return NotFound();
            }

            var kpidevelopment = await _context.Kpidevelopments
                .FirstOrDefaultAsync(m => m.KpidevelomentCode == id);
            if (kpidevelopment == null)
            {
                return NotFound();
            }

            return View(kpidevelopment);
        }

        // GET: Kpidevelopments/Create
      
        [Authorization((int)Roles.مدیر_برنامه_ریزی)]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Kpidevelopments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
       
        [Authorization((int)Roles.مدیر_برنامه_ریزی)]
        public async Task<IActionResult> Create([Bind("KpidevelomentCode,RdinPrdImp,IdeCusNeed,NewTooldsat,PerImpPrdSur,PrdAwaPer,NewCusinSrvPrd,SugCap,SugInc,InvSugAvgTime,SolutionAvgTime,ColRate,AccsugRate")] Kpidevelopment kpidevelopment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(kpidevelopment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(kpidevelopment);
        }

        // GET: Kpidevelopments/Edit/5
      
        [Authorization((int)Roles.مدیر_برنامه_ریزی)]
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Kpidevelopments == null)
            {
                return NotFound();
            }

            var kpidevelopment = await _context.Kpidevelopments.FindAsync(id);
            if (kpidevelopment == null)
            {
                return NotFound();
            }
            return View(kpidevelopment);
        }

        // POST: Kpidevelopments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
      
        [Authorization((int)Roles.مدیر_برنامه_ریزی)]
        public async Task<IActionResult> Edit(string id, [Bind("KpidevelomentCode,RdinPrdImp,IdeCusNeed,NewTooldsat,PerImpPrdSur,PrdAwaPer,NewCusinSrvPrd,SugCap,SugInc,InvSugAvgTime,SolutionAvgTime,ColRate,AccsugRate")] Kpidevelopment kpidevelopment)
        {
            if (id != kpidevelopment.KpidevelomentCode)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kpidevelopment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KpidevelopmentExists(kpidevelopment.KpidevelomentCode))
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
            return View(kpidevelopment);
        }

        // GET: Kpidevelopments/Delete/5
      
        [Authorization((int)Roles.مدیر_برنامه_ریزی)]
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Kpidevelopments == null)
            {
                return NotFound();
            }

            var kpidevelopment = await _context.Kpidevelopments
                .FirstOrDefaultAsync(m => m.KpidevelomentCode == id);
            if (kpidevelopment == null)
            {
                return NotFound();
            }

            return View(kpidevelopment);
        }

        // POST: Kpidevelopments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
      
        [Authorization((int)Roles.مدیر_برنامه_ریزی)]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Kpidevelopments == null)
            {
                return Problem("Entity set 'TestHadadianContext.Kpidevelopments'  is null.");
            }
            var kpidevelopment = await _context.Kpidevelopments.FindAsync(id);
            if (kpidevelopment != null)
            {
                _context.Kpidevelopments.Remove(kpidevelopment);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KpidevelopmentExists(string id)
        {
          return (_context.Kpidevelopments?.Any(e => e.KpidevelomentCode == id)).GetValueOrDefault();
        }
    }
}
