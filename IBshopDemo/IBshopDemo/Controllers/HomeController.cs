using IBshopDemo.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using IBshopDemo.ActionFilters;
using System.Security.Policy;
using IBshopDemo.ViewModels.Home;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using IBshopDemo.Enums;

namespace IBshopDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly TestHadadianContext _context;
        public HomeController(TestHadadianContext context)
        {
            _context=context;
        }
        [Authorization((int)Roles.ادمین)]
        public IActionResult Index()
        {
            //var hash = Encoding.UTF8.GetString(MD5.Create().ComputeHash(Encoding.UTF8.GetBytes("0000")));
            //var user = new User() { NationalCode = "5555", Password = hash };
            //_context.Users.Add(user);
            //_context.SaveChanges();

            //if (HttpContext.Session.GetString("UserId") == null)
            //{
            //    return RedirectToAction("Login");
            //}

            return View();
        }

       // [Authorization((int)Roles.ادمین)]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(InputLoginVM loginVM)
        {
            var hash = Encoding.UTF8.GetString(MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(loginVM.Password)));
            var user=_context.Users.Where(u => u.NationalCode == loginVM.NationalCode && u.Password==hash).FirstOrDefault();
            if(user != null) {
                HttpContext.Session.SetInt32("UserId", user.UserId);
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult LogOut()
        {
			HttpContext.Session.Remove("UserId");
            return RedirectToAction("Index");
		}

		[HttpGet]
        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Signup(InputSignupVM inputSignupVM)
        {
           
            if (ModelState.IsValid)
            {
                var user = _context.Users.Where(u => u.NationalCode == inputSignupVM.NationalCode).FirstOrDefault();
                if (user == null)
                {

                    if (inputSignupVM.Password == inputSignupVM.rePassword)
                    {
                        //var hash = Encoding.UTF8.GetString(MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(inputSignupVM.Password)));
                        //var hash =MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(user.Password));
                        inputSignupVM.Password = Encoding.UTF8.GetString(MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(inputSignupVM.Password)));

                        _context.Users.Add(new User { FirstName = inputSignupVM.FirstName, LastName = inputSignupVM.LastName, NationalCode = inputSignupVM.NationalCode, Password = inputSignupVM.Password, PhoneNumber = inputSignupVM.PhoneNumber });
                        _context.SaveChanges();
                        return RedirectToAction(nameof(Login));
                    }

                }
                else
                {
                    ModelState.AddModelError("NationalCode", "کدملی در سیستم ثبت شده است.");
                    
                }

            }
            return View(inputSignupVM);
        }

        public IActionResult Signout()
        {
            HttpContext.Session.Remove("UserId");
            return RedirectToAction(nameof(Login));

        }

        public IActionResult NotPermisson()
        {
            return View();
        }

    }
}