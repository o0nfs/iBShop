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
    public class BranchKpisController : Controller
    {
        private readonly TestHadadianContext _context;

        public BranchKpisController(TestHadadianContext context)
        {
            _context = context;
        }

        // GET: BranchKpis
        public async Task<IActionResult> Index()
        {
              return _context.BranchKpis != null ? 
                          View(await _context.BranchKpis.ToListAsync()) :
                          Problem("Entity set 'TestHadadianContext.BranchKpis'  is null.");
        }

        // GET: BranchKpis/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.BranchKpis == null)
            {
                return NotFound();
            }

            var branchKpi = await _context.BranchKpis
                .FirstOrDefaultAsync(m => m.KpibranchCode == id);
            if (branchKpi == null)
            {
                return NotFound();
            }

            return View(branchKpi);
        }

        // GET: BranchKpis/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BranchKpis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("KpibranchCode,WrsupReq,WrongIssue,BrcCnf,WrongQty,BrnReqQty,BranchCap,PurchaseAvgTime,Kllevel,ConIntMonPercentage,ClienttoIssue,BrcClient,MrkSpv,NewUser")] BranchKpi branchKpi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(branchKpi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(branchKpi);
        }

        // GET: BranchKpis/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.BranchKpis == null)
            {
                return NotFound();
            }

            var branchKpi = await _context.BranchKpis.FindAsync(id);
            if (branchKpi == null)
            {
                return NotFound();
            }
            return View(branchKpi);
        }

        // POST: BranchKpis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("KpibranchCode,WrsupReq,WrongIssue,BrcCnf,WrongQty,BrnReqQty,BranchCap,PurchaseAvgTime,Kllevel,ConIntMonPercentage,ClienttoIssue,BrcClient,MrkSpv,NewUser")] BranchKpi branchKpi)
        {
            if (id != branchKpi.KpibranchCode)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(branchKpi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BranchKpiExists(branchKpi.KpibranchCode))
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
            return View(branchKpi);
        }

        // GET: BranchKpis/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.BranchKpis == null)
            {
                return NotFound();
            }

            var branchKpi = await _context.BranchKpis
                .FirstOrDefaultAsync(m => m.KpibranchCode == id);
            if (branchKpi == null)
            {
                return NotFound();
            }

            return View(branchKpi);
        }

        // POST: BranchKpis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.BranchKpis == null)
            {
                return Problem("Entity set 'TestHadadianContext.BranchKpis'  is null.");
            }
            var branchKpi = await _context.BranchKpis.FindAsync(id);
            if (branchKpi != null)
            {
                _context.BranchKpis.Remove(branchKpi);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BranchKpiExists(string id)
        {
          return (_context.BranchKpis?.Any(e => e.KpibranchCode == id)).GetValueOrDefault();
        }
    }
}
