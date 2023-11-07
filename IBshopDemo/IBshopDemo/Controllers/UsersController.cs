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
    public class UsersController : Controller
    {
        private readonly TestHadadianContext _context;

        public UsersController(TestHadadianContext context)
        {
            _context = context;
        }

        // GET: Users
        [Authorization((int)Roles.ادمین)]
        public async Task<IActionResult> Index()
        {
              return _context.Users != null ? 
                          View(await _context.Users.ToListAsync()) :
                          Problem("Entity set 'TestHadadianContext.Users'  is null.");
        }

        // GET: Users/Details/5
        [Authorization((int)Roles.ادمین)]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Users == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: Users/Create
        [Authorization((int)Roles.ادمین)]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorization((int)Roles.ادمین)]
        public async Task<IActionResult> Create([Bind("UserId,NationalCode,LastName,FirstName,PhoneNumber,Password")] User user)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: Users/Edit/5
        [Authorization((int)Roles.ادمین)]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Users == null)
            {
                return NotFound();
            }

            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorization((int)Roles.ادمین)]
        public async Task<IActionResult> Edit(int id, [Bind("UserId,NationalCode,LastName,FirstName,PhoneNumber,Password")] User user)
        {
            if (id != user.UserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.UserId))
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
            return View(user);
        }

        // GET: Users/Delete/5
        [Authorization((int)Roles.ادمین)]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Users == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorization((int)Roles.ادمین)]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Users == null)
            {
                return Problem("Entity set 'TestHadadianContext.Users'  is null.");
            }
            var user = await _context.Users.FindAsync(id);
            if (user != null)
            {
                _context.Users.Remove(user);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(int id)
        {
          return (_context.Users?.Any(e => e.UserId == id)).GetValueOrDefault();
        }
        [HttpGet]
        [Route("/Users/GetUserRoles/{userId}")]
        public IActionResult UserRolse(int userId)
        {
            var allRoles = _context.Roles.ToList();
            var userRoles = _context.UserRoles
                .Where(a => a.UserId == userId)
                .Select(s=>s.RoleId)
                .ToList();

            ViewBag.UserRoles = userRoles;
            ViewBag.UserID = userId;
            return PartialView(allRoles);
        }
        [HttpPost]
        public IActionResult SetUserRoles(int userId,List<int> roleId)
        {
          var roels =  roleId.Select(a => new UserRole
            {
                UserId = userId,
                RoleId = a,
            });

            var oldRoles = _context.UserRoles
				.Where(a => a.UserId == userId)
				.ToList();

            _context.UserRoles.RemoveRange(oldRoles);
            _context.UserRoles.AddRange(roels);
            _context.SaveChanges();
            return Redirect("/Users/Index");
		}
    }
}
