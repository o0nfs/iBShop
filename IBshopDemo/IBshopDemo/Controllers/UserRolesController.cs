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
    public class UserRolesController : Controller
    {
        private readonly TestHadadianContext _context;

        public UserRolesController(TestHadadianContext context)
        {
            _context = context;
        }

        // GET: UserRoles
        [Authorization((int)Roles.ادمین)]
        public async Task<IActionResult> Index()
        {
            var testHadadianContext = _context.UserRoles.Include(u => u.Role).Include(u => u.User);
            return View(await testHadadianContext.ToListAsync());
        }

        // GET: UserRoles/Details/5
        [Authorization((int)Roles.ادمین)]
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null || _context.UserRoles == null)
            {
                return NotFound();
            }

            var userRole = await _context.UserRoles
                .Include(u => u.Role)
                .Include(u => u.User)
                .FirstOrDefaultAsync(m => m.UserRoleId == id);
            if (userRole == null)
            {
                return NotFound();
            }

            return View(userRole);
        }

        // GET: UserRoles/Create
        [Authorization((int)Roles.ادمین)]
        public IActionResult Create()
        {
            ViewData["RoleId"] = new SelectList(_context.Roles, "RoleId", "RoleId");
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "UserId");
            return View();
        }

        // POST: UserRoles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserRoleId,UserId,RoleId")] UserRole userRole)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userRole);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RoleId"] = new SelectList(_context.Roles, "RoleId", "RoleId", userRole.RoleId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "UserId", userRole.UserId);
            return View(userRole);
        }

        // GET: UserRoles/Edit/5
        [Authorization((int)Roles.ادمین)]
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null || _context.UserRoles == null)
            {
                return NotFound();
            }

            var userRole = await _context.UserRoles.FindAsync(id);
            if (userRole == null)
            {
                return NotFound();
            }
            ViewData["RoleId"] = new SelectList(_context.Roles, "RoleId", "RoleId", userRole.RoleId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "UserId", userRole.UserId);
            return View(userRole);
        }

        // POST: UserRoles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorization((int)Roles.ادمین)]
        public async Task<IActionResult> Edit(long id, [Bind("UserRoleId,UserId,RoleId")] UserRole userRole)
        {
            if (id != userRole.UserRoleId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userRole);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserRoleExists(userRole.UserRoleId))
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
            ViewData["RoleId"] = new SelectList(_context.Roles, "RoleId", "RoleId", userRole.RoleId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "UserId", userRole.UserId);
            return View(userRole);
        }

        // GET: UserRoles/Delete/5
        [Authorization((int)Roles.ادمین)]
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null || _context.UserRoles == null)
            {
                return NotFound();
            }

            var userRole = await _context.UserRoles
                .Include(u => u.Role)
                .Include(u => u.User)
                .FirstOrDefaultAsync(m => m.UserRoleId == id);
            if (userRole == null)
            {
                return NotFound();
            }

            return View(userRole);
        }

        // POST: UserRoles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorization((int)Roles.ادمین)]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            if (_context.UserRoles == null)
            {
                return Problem("Entity set 'TestHadadianContext.UserRoles'  is null.");
            }
            var userRole = await _context.UserRoles.FindAsync(id);
            if (userRole != null)
            {
                _context.UserRoles.Remove(userRole);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserRoleExists(long id)
        {
          return (_context.UserRoles?.Any(e => e.UserRoleId == id)).GetValueOrDefault();
        }
    }
}
