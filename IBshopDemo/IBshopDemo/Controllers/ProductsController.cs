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
    public class ProductsController : Controller
    {
        private readonly TestHadadianContext _context;

        public ProductsController(TestHadadianContext context)
        {
            _context = context;
        }

        // GET: Products
        [Authorization((int)Roles.ادمین)]
      
        public async Task<IActionResult> Index()
        {
            var testHadadianContext = _context.Products.Include(p => p.BrancheCodeNavigation).Include(p => p.IncomeCenter);
            return View(await testHadadianContext.ToListAsync());
        }

        // GET: Products/Details/5
        [Authorization((int)Roles.ادمین)]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.BrancheCodeNavigation)
                .Include(p => p.IncomeCenter)
                .FirstOrDefaultAsync(m => m.ProductsId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        [Authorization((int)Roles.ادمین)]
        public IActionResult Create()
        {
            ViewData["BrancheCode"] = new SelectList(_context.BranchesInfos, "BranchCode", "BranchCode");
            ViewData["IncomeCenterId"] = new SelectList(_context.IncomeCenters, "IncomecenterId", "IncomecenterId");
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorization((int)Roles.ادمین)]
        public async Task<IActionResult> Create([Bind("ProductsId,BrancheCode,IncomeCenterId,MonthNumber,MonthName,IbcrowdVol,IbcardIssueQty,CardQty,KargozariBoursCode,DealValue,Income")] Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BrancheCode"] = new SelectList(_context.BranchesInfos, "BranchCode", "BranchCode", product.BrancheCode);
            ViewData["IncomeCenterId"] = new SelectList(_context.IncomeCenters, "IncomecenterId", "IncomecenterId", product.IncomeCenterId);
            return View(product);
        }

        // GET: Products/Edit/5
        [Authorization((int)Roles.ادمین)]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["BrancheCode"] = new SelectList(_context.BranchesInfos, "BranchCode", "BranchCode", product.BrancheCode);
            ViewData["IncomeCenterId"] = new SelectList(_context.IncomeCenters, "IncomecenterId", "IncomecenterId", product.IncomeCenterId);
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorization((int)Roles.ادمین)]
        public async Task<IActionResult> Edit(int id, [Bind("ProductsId,BrancheCode,IncomeCenterId,MonthNumber,MonthName,IbcrowdVol,IbcardIssueQty,CardQty,KargozariBoursCode,DealValue,Income")] Product product)
        {
            if (id != product.ProductsId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ProductsId))
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
            ViewData["BrancheCode"] = new SelectList(_context.BranchesInfos, "BranchCode", "BranchCode", product.BrancheCode);
            ViewData["IncomeCenterId"] = new SelectList(_context.IncomeCenters, "IncomecenterId", "IncomecenterId", product.IncomeCenterId);
            return View(product);
        }

        // GET: Products/Delete/5
        [Authorization((int)Roles.ادمین)]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.BrancheCodeNavigation)
                .Include(p => p.IncomeCenter)
                .FirstOrDefaultAsync(m => m.ProductsId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorization((int)Roles.ادمین)]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Products == null)
            {
                return Problem("Entity set 'TestHadadianContext.Products'  is null.");
            }
            var product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                _context.Products.Remove(product);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
          return (_context.Products?.Any(e => e.ProductsId == id)).GetValueOrDefault();
        }
    }
}
