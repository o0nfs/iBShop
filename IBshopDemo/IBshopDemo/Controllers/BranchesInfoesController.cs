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
    public class BranchesInfoesController : Controller
    {
        private readonly TestHadadianContext _context;

        public BranchesInfoesController(TestHadadianContext context)
        {
            _context = context;
        }

        // GET: BranchesInfoes
        //[Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_امور_شعب)]
        public async Task<IActionResult> Index()
        {

              return _context.BranchesInfos != null ? 
                          View(await _context.BranchesInfos.ToListAsync()) :
                          Problem("Entity set 'TestHadadianContext.BranchesInfos'  is null.");
        }

        // GET: BranchesInfoes/Details/5
       // [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_امور_شعب)]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.BranchesInfos == null)
            {
                return NotFound();
            }

            var branchesInfo = await _context.BranchesInfos
                .FirstOrDefaultAsync(m => m.BranchCode == id);
            if (branchesInfo == null)
            {
                return NotFound();
            }

            return View(branchesInfo);
        }

        // GET: BranchesInfoes/Create
        //[Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_امور_شعب)]
        public IActionResult Create()
        {
            return View();
        }

        // POST: BranchesInfoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //[Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_امور_شعب)]
        public async Task<IActionResult> Create(BranchesInfo branchesInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(branchesInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(branchesInfo);
        }

        // GET: BranchesInfoes/Edit/5
       // [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_امور_شعب)]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.BranchesInfos == null)
            {
                return NotFound();
            }

            var branchesInfo = await _context.BranchesInfos.FindAsync(id);
            if (branchesInfo == null)
            {
                return NotFound();
            }
            return View(branchesInfo);
        }

        // POST: BranchesInfoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
       // [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_امور_شعب)]
        public async Task<IActionResult> Edit(int id, [Bind("BranchCode,BranchLocation,BranchManager")] BranchesInfo branchesInfo)
        {
            if (id != branchesInfo.BranchCode)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(branchesInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BranchesInfoExists(branchesInfo.BranchCode))
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
            return View(branchesInfo);
        }

        // GET: BranchesInfoes/Delete/5
       // [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_امور_شعب)]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.BranchesInfos == null)
            {
                return NotFound();
            }

            var branchesInfo = await _context.BranchesInfos
                .FirstOrDefaultAsync(m => m.BranchCode == id);
            if (branchesInfo == null)
            {
                return NotFound();
            }

            return View(branchesInfo);
        }

        // POST: BranchesInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
      //  [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_امور_شعب)]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.BranchesInfos == null)
            {
                return Problem("Entity set 'TestHadadianContext.BranchesInfos'  is null.");
            }
            var branchesInfo = await _context.BranchesInfos.FindAsync(id);
            if (branchesInfo != null)
            {
                _context.BranchesInfos.Remove(branchesInfo);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BranchesInfoExists(int id)
        {
          return (_context.BranchesInfos?.Any(e => e.BranchCode == id)).GetValueOrDefault();
        }
    }
}
