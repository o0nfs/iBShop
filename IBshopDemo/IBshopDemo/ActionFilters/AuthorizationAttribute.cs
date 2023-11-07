using IBshopDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace IBshopDemo.ActionFilters
{
    public class AuthorizationAttribute : TypeFilterAttribute
    {
        public AuthorizationAttribute(int code) : base(typeof(PermissionFilterFilter))
        {
            this.Arguments = new object[] { code.ToString() };
        }

        private class PermissionFilterFilter : IActionFilter
        {
            private readonly TestHadadianContext _db;
            private readonly string _code;
            public PermissionFilterFilter(string code, TestHadadianContext db)
            {
                _db = db;
                _code = code;

            }

            public void OnActionExecuting(ActionExecutingContext context)
            {

                var userId = context.HttpContext.Session.GetInt32("UserId");
                if (userId == null)
                {
                    context.Result = new EmptyResult();
                    context.HttpContext.Response.Redirect("/home/login");
                    return;
                }
               
                var hasRole = _db.UserRoles
                    .Include(a=>a.Role)
                    .Any(a => a.UserId == userId && _code.Contains(a.Role.RoleUniqeCode.ToString()));

                if (!hasRole)
                {
                    context.Result = new EmptyResult();
                    context.HttpContext.Response.Redirect("/home/notPermisson");
                }
             


            }
            public void OnActionExecuted(ActionExecutedContext context) { }
        }
    }
}
