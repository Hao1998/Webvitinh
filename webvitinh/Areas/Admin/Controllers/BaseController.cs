using Microsoft.AspNetCore.Mvc;
using webvitinh.Common;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Http;
using webvitinh;

namespace OnlineShop.Areas.Admin.Controllers
{

    public class BaseController : Controller
    {


        //initilizing culture on controller initialization
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //var session = HttpContext.Session.GetString(CommonConstants.USER_SESSION);
            if (CommonConstants.USER_SESSION == null)
            {
                filterContext.Result = new RedirectToRouteResult(new
                    RouteValueDictionary(new { controller = "Login", action = "Index", Area = "Admin" }));
            }
            base.OnActionExecuting(filterContext);
        }


        protected void SetAlert(string message, string type)
        {
            TempData["AlertMessage"] = message;
            if (type == "success")
            {
                TempData["AlertType"] = "alert-success";
            }
            else if (type == "warning")
            {
                TempData["AlertType"] = "alert-warning";
            }
            else if (type == "error")
            {
                TempData["AlertType"] = "alert-danger";
            }
        }

    }
}