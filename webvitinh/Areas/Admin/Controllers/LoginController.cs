using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.Dao;
using OnlineShop.Areas.Admin.Controllers;
using webvitinh.Areas.Admin.Models;
using webvitinh.Common;

namespace webvitinh.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]")]
    public class LoginController : Controller
    {

        public string SessionKeyName = "_Name";

        public string SessionCredential = "_Name";

        public string SessionInfo_Name { get; private set; }

        [Route("[action]")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("[action]")]
        public IActionResult Login(LoginModel model)
        {
            if(ModelState.IsValid)
            {
                var dao = new UserDao();
                var result = dao.Login(model.Username, Encryptor.MD5Hash(model.Password),true);
                if(result == 1)
                {
                    var user = dao.GetByID(model.Username);
                    var userSession = new UserLogin();
                    userSession.UserName = user.Username;
                    userSession.UserID = user.Id;
                    userSession.GroupID = user.GroupID;
                    HttpContext.Session.SetString(SessionKeyName, user.Name);
                    HttpContext.Session.SetString(SessionCredential, user.GroupID);
                    CommonConstants.USER_SESSION = user.Username;
                    CommonConstants.SESSION_CREDENTIALS = user.GroupID;
                    return RedirectToAction("Index","Home");
                }
                else if (result == 0)
                {
                    ModelState.AddModelError("", "Account is not existed !");
                }
                else if (result == -1)
                {
                    ModelState.AddModelError("", "Account is blocked !");
                }
                else if (result == -2)
                {
                    ModelState.AddModelError("", "Password is not correct !");
                }
                else if (result == -3)
                {
                    ModelState.AddModelError("", "You don't have the right to access this site !");
                }
                else
                {
                    ModelState.AddModelError("", "Password or Username is incorrect !");
                }
            }
            return View("Index");
        }
    }
}