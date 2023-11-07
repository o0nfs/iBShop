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
    public class BranchRankingsController : Controller
    {
        private readonly TestHadadianContext _context;

        public BranchRankingsController(TestHadadianContext context)
        {
            _context = context;
        }

        // GET: BranchRankings
      //  [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_امور_شعب)]
        public async Task<IActionResult> Index()
        {
              return _context.BranchRankings != null ? 
                          View(await _context.BranchRankings.ToListAsync()) :
                          Problem("Entity set 'TestHadadianContext.BranchRankings'  is null.");
        }

        // GET: BranchRankings/Details/5
       // [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_امور_شعب)]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.BranchRankings == null)
            {
                return NotFound();
            }

            var branchRanking = await _context.BranchRankings
                .FirstOrDefaultAsync(m => m.Id == id);
            if (branchRanking == null)
            {
                return NotFound();
            }

            return View(branchRanking);
        }

        // GET: BranchRankings/Create
       // [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_امور_شعب)]
        public IActionResult Create()
        {
            return View();
        }

        // POST: BranchRankings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
       // [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_امور_شعب)]
        public async Task<IActionResult> Create([Bind("BranchRankingId,BranchId,GanjinehRank,Andokhtehrank,ServatRank,Bimehrank,IBcrowdrank,Productrank,Sandoghrank,SatisfactionRank,Servicerank,TotalRank,Id")] BranchRanking branchRanking)
        {
            if (ModelState.IsValid)
            {
                _context.Add(branchRanking);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(branchRanking);
        }

        // GET: BranchRankings/Edit/5
     //   [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_امور_شعب)]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.BranchRankings == null)
            {
                return NotFound();
            }

            var branchRanking = await _context.BranchRankings.FindAsync(id);
            if (branchRanking == null)
            {
                return NotFound();
            }
            return View(branchRanking);
        }

        // POST: BranchRankings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
       // [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_امور_شعب)]
        public async Task<IActionResult> Edit(int id, [Bind("BranchRankingId,BranchId,GanjinehRank,Andokhtehrank,ServatRank,Bimehrank,IBcrowdrank,Productrank,Sandoghrank,SatisfactionRank,Servicerank,TotalRank,Id")] BranchRanking branchRanking)
        {
            if (id != branchRanking.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(branchRanking);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BranchRankingExists(branchRanking.Id))
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
            return View(branchRanking);
        }

        // GET: BranchRankings/Delete/5
       // [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_امور_شعب)]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.BranchRankings == null)
            {
                return NotFound();
            }

            var branchRanking = await _context.BranchRankings
                .FirstOrDefaultAsync(m => m.Id == id);
            if (branchRanking == null)
            {
                return NotFound();
            }

            return View(branchRanking);
        }

        // POST: BranchRankings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        //[Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_امور_شعب)]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.BranchRankings == null)
            {
                return Problem("Entity set 'TestHadadianContext.BranchRankings'  is null.");
            }
            var branchRanking = await _context.BranchRankings.FindAsync(id);
            if (branchRanking != null)
            {
                _context.BranchRankings.Remove(branchRanking);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BranchRankingExists(int id)
        {
          return (_context.BranchRankings?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
