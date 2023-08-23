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
    public class ProductDevelopmentMontylyReportsController : Controller
    {
        private readonly TestHadadianContext _context;

        public ProductDevelopmentMontylyReportsController(TestHadadianContext context)
        {
            _context = context;
        }

        // GET: ProductDevelopmentMontylyReports
        public async Task<IActionResult> Index()
        {
              return _context.ProductDevelopmentMontylyReports != null ? 
                          View(await _context.ProductDevelopmentMontylyReports.ToListAsync()) :
                          Problem("Entity set 'TestHadadianContext.ProductDevelopmentMontylyReports'  is null.");
        }

        // GET: ProductDevelopmentMontylyReports/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ProductDevelopmentMontylyReports == null)
            {
                return NotFound();
            }

            var productDevelopmentMontylyReport = await _context.ProductDevelopmentMontylyReports
                .FirstOrDefaultAsync(m => m.DevMrid == id);
            if (productDevelopmentMontylyReport == null)
            {
                return NotFound();
            }

            return View(productDevelopmentMontylyReport);
        }

        // GET: ProductDevelopmentMontylyReports/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProductDevelopmentMontylyReports/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DevMrid,Year,Month,MonthNumber,CheckedSuggestQty,AcceptedSuggestQty,SuggestPersonnelQty,EconomicalSuggestQty,IbcCreaditCardCustQty,IbcComplQty,IbcCreadiCardReqQty,IbcCreaditCardProcessAvgTime,IbwDesignQty,IbwDesignVol,IbwDesignTime")] ProductDevelopmentMontylyReport productDevelopmentMontylyReport)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productDevelopmentMontylyReport);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(productDevelopmentMontylyReport);
        }

        // GET: ProductDevelopmentMontylyReports/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ProductDevelopmentMontylyReports == null)
            {
                return NotFound();
            }

            var productDevelopmentMontylyReport = await _context.ProductDevelopmentMontylyReports.FindAsync(id);
            if (productDevelopmentMontylyReport == null)
            {
                return NotFound();
            }
            return View(productDevelopmentMontylyReport);
        }

        // POST: ProductDevelopmentMontylyReports/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DevMrid,Year,Month,MonthNumber,CheckedSuggestQty,AcceptedSuggestQty,SuggestPersonnelQty,EconomicalSuggestQty,IbcCreaditCardCustQty,IbcComplQty,IbcCreadiCardReqQty,IbcCreaditCardProcessAvgTime,IbwDesignQty,IbwDesignVol,IbwDesignTime")] ProductDevelopmentMontylyReport productDevelopmentMontylyReport)
        {
            if (id != productDevelopmentMontylyReport.DevMrid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productDevelopmentMontylyReport);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductDevelopmentMontylyReportExists(productDevelopmentMontylyReport.DevMrid))
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
            return View(productDevelopmentMontylyReport);
        }

        // GET: ProductDevelopmentMontylyReports/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ProductDevelopmentMontylyReports == null)
            {
                return NotFound();
            }

            var productDevelopmentMontylyReport = await _context.ProductDevelopmentMontylyReports
                .FirstOrDefaultAsync(m => m.DevMrid == id);
            if (productDevelopmentMontylyReport == null)
            {
                return NotFound();
            }

            return View(productDevelopmentMontylyReport);
        }

        // POST: ProductDevelopmentMontylyReports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ProductDevelopmentMontylyReports == null)
            {
                return Problem("Entity set 'TestHadadianContext.ProductDevelopmentMontylyReports'  is null.");
            }
            var productDevelopmentMontylyReport = await _context.ProductDevelopmentMontylyReports.FindAsync(id);
            if (productDevelopmentMontylyReport != null)
            {
                _context.ProductDevelopmentMontylyReports.Remove(productDevelopmentMontylyReport);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductDevelopmentMontylyReportExists(int id)
        {
          return (_context.ProductDevelopmentMontylyReports?.Any(e => e.DevMrid == id)).GetValueOrDefault();
        }
    }
}
