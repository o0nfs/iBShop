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
    public class OperationKpisController : Controller
    {
        private readonly TestHadadianContext _context;

        public OperationKpisController(TestHadadianContext context)
        {
            _context = context;
        }

        // GET: OperationKpis
      //  [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_عملیات)]
        public async Task<IActionResult> Index()
        {
              return _context.OperationKpis != null ? 
                          View(await _context.OperationKpis.ToListAsync()) :
                          Problem("Entity set 'TestHadadianContext.OperationKpis'  is null.");
        }

        // GET: OperationKpis/Details/5
      //  [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_عملیات)]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.OperationKpis == null)
            {
                return NotFound();
            }

            var operationKpi = await _context.OperationKpis
                .FirstOrDefaultAsync(m => m.Id == id);
            if (operationKpi == null)
            {
                return NotFound();
            }

            return View(operationKpi);
        }

        // GET: OperationKpis/Create
       // [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_عملیات)]
        public IActionResult Create()
        {
            return View();
        }

        // POST: OperationKpis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //[Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_عملیات)]
        public async Task<IActionResult> Create([Bind("Id,OperationKpicode,Piapp,ErrApp,AppDev,Answeringspeed,IbCardAutAvgTime,SejAutAvgTime,PayToCusAvgTime,CusAutAsset,Cus,SucOprRate")] OperationKpi operationKpi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(operationKpi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(operationKpi);
        }

        // GET: OperationKpis/Edit/5
     //   [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_عملیات)]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.OperationKpis == null)
            {
                return NotFound();
            }

            var operationKpi = await _context.OperationKpis.FindAsync(id);
            if (operationKpi == null)
            {
                return NotFound();
            }
            return View(operationKpi);
        }

        // POST: OperationKpis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
       // [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_عملیات)]
        public async Task<IActionResult> Edit(int id, [Bind("Id,OperationKpicode,Piapp,ErrApp,AppDev,Answeringspeed,IbCardAutAvgTime,SejAutAvgTime,PayToCusAvgTime,CusAutAsset,Cus,SucOprRate")] OperationKpi operationKpi)
        {
            if (id != operationKpi.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(operationKpi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OperationKpiExists(operationKpi.Id))
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
            return View(operationKpi);
        }

        // GET: OperationKpis/Delete/5
       // [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_عملیات)]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.OperationKpis == null)
            {
                return NotFound();
            }

            var operationKpi = await _context.OperationKpis
                .FirstOrDefaultAsync(m => m.Id == id);
            if (operationKpi == null)
            {
                return NotFound();
            }

            return View(operationKpi);
        }

        // POST: OperationKpis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
       // [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_عملیات)]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.OperationKpis == null)
            {
                return Problem("Entity set 'TestHadadianContext.OperationKpis'  is null.");
            }
            var operationKpi = await _context.OperationKpis.FindAsync(id);
            if (operationKpi != null)
            {
                _context.OperationKpis.Remove(operationKpi);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OperationKpiExists(int id)
        {
          return (_context.OperationKpis?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
