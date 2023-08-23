using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;


namespace IBshopDemo.ActionFilters
{
    public class AuthenticationAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.HttpContext.Session.Keys.Contains("UserId"))
            {
                context.Result=new EmptyResult();
                context.HttpContext.Response.Redirect("/home/login");
            }
           
        }
    }
}
