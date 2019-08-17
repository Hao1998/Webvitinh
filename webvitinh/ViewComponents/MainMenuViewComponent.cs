using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model.Dao;
using webvitinh.Common;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace webvitinh.ViewComponents
{
    public class MainMenuViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.Login = CommonConstants.USER_SESSION;
            var model = new MenuDao().ListByGroupId();
            return View(model);
        }
    }
}
