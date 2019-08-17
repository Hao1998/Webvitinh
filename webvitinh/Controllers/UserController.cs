using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Model;
using Model.Dao;
using Newtonsoft.Json.Linq;
using webvitinh.Models;
using System.Xml.Linq;
using Microsoft.AspNetCore.Hosting.Server;
using System.IO;
using System.Xml.Serialization;
using webvitinh.Common;
using Microsoft.AspNetCore.Http;
using System.ComponentModel;
using System.Xml;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;
using System.Security.Claims;

namespace webvitinh.Controllers
{
    public class UserController : Controller
    {
        private IConfiguration _configuration;

        public ILogger _logger;

        public string SessionKeyName = "_Name";

        private IHostingEnvironment _env;

        public UserController(IConfiguration iConfig)
        {
            _configuration = iConfig;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("dang-ky")]
        [Route("[action]")]
        public ActionResult Register()
        {
            ViewData["ReCaptchaKey"] = _configuration.GetSection("GoogleReCaptcha:key").Value;
            return View();
        }

       
        public IActionResult GoogleLogin(string returnUrl)
        {
            //returnUrl = "/";
            return new ChallengeResult(
                GoogleDefaults.AuthenticationScheme,
                new AuthenticationProperties
                {
                    RedirectUri = "/"
                });
        }

        //[HttpPost]
        //[Route("[action]")]
        /// <summary>
        /// Problem with the callback
        /// </summary>
        /// <param name="returnUrl"></param>
        /// <returns></returns>
        public async Task<IActionResult> LoginGoogleCallback(string returnUrl)
        {
            returnUrl = "/";
            var authenticateResult = await HttpContext.AuthenticateAsync("External");

            if (!authenticateResult.Succeeded)
                return BadRequest(); // TODO: Handle this better.

            var claimsIdentity = new ClaimsIdentity("Application");

            claimsIdentity.AddClaim(authenticateResult.Principal.FindFirst(ClaimTypes.NameIdentifier));
            claimsIdentity.AddClaim(authenticateResult.Principal.FindFirst(ClaimTypes.Email));

            await HttpContext.SignInAsync(
                "Application",
                new ClaimsPrincipal(claimsIdentity));

            return LocalRedirect(returnUrl);
        }

        [HttpGet("dang-nhap")]
        public ActionResult Login()
        {
            return View();
        }

        public IActionResult FacebookLogin()
        {
            var authProperties = new AuthenticationProperties
            {
                RedirectUri = "/"
            };
            return Challenge(authProperties, "Facebook");
        }

        [HttpPost]
        [Route("[action]")]
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                var result = dao.Login(model.Username, Encryptor.MD5Hash(model.Password));
                if (result == 1)
                {
                    var user = dao.GetByID(model.Username);
                    var userSession = new UserLogin();
                    userSession.UserName = user.Username;
                    HttpContext.Session.SetString(SessionKeyName, userSession.UserName);
                    CommonConstants.USER_SESSION = HttpContext.Session.GetString(SessionKeyName);
                    var name = CommonConstants.USER_SESSION;
                    return Redirect("/");
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
                else
                {
                    ModelState.AddModelError("", "Password or Username is incorrect !");
                }
            }
            return View(model);
        }

        [Route("[action]")]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove(SessionKeyName);
            CommonConstants.USER_SESSION = HttpContext.Session.GetString(SessionKeyName);
            foreach (string cookie in Request.Cookies.Keys)
            {
                Response.Cookies.Delete(cookie);
            }
            return Redirect("/"); ;
        }

        [Route("[action]")]
        public async Task<IActionResult> LogoutFace()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            HttpContext.Session.Remove(CookieAuthenticationDefaults.AuthenticationScheme);
            foreach (string cookie in Request.Cookies.Keys)
            {
                Response.Cookies.Delete(cookie);
            }
            return Redirect("/");
        }


        public static bool ReCaptchaPassed(string gRecaptchaResponse, string secret, ILogger logger)
        {
            HttpClient httpClient = new HttpClient();
            var res = httpClient.GetAsync($"https://www.google.com/recaptcha/api/siteverify?secret={secret}&response={gRecaptchaResponse}").Result;
            if (res.StatusCode != HttpStatusCode.OK)
            {
                logger.LogError("Error while sending request to ReCaptcha");
                return false;
            }

            string JSONres = res.Content.ReadAsStringAsync().Result;
            dynamic JSONdata = JObject.Parse(JSONres);
            if (JSONdata.success != "true")
            {
                return false;
            }

            return true;
        }

        [Route("[action]")]
        [HttpPost]
        public IActionResult Register(RegisterModel model)
        {
            ViewData["ReCaptchaKey"] = _configuration.GetSection("GoogleReCaptcha:key").Value;

            if (ModelState.IsValid)
            {
                if (!ReCaptchaPassed(
                    Request.Form["g-recaptcha-response"], // that's how you get it from the Request object
                    _configuration.GetSection("GoogleReCaptcha:secret").Value,
                    _logger
                ))
                {
                    ModelState.AddModelError(string.Empty, "You failed the CAPTCHA, stupid robot. Go play some 1x1 on SFs instead.");
                    return View(model);
                }
                var dao = new UserDao();
                if (dao.CheckUserName(model.Username))
                {
                    ModelState.AddModelError("", "Username has been used by another person !!");
                }
                else if (dao.CheckEmail(model.Email))
                {
                    ModelState.AddModelError("", "Email has been used by another person !!");
                }
                else
                {
                    var user = new User();
                    user.Username = model.Username;
                    user.Name = model.Name;
                    user.Password = Encryptor.MD5Hash(model.Password);
                    user.Phone = model.Phone;
                    user.Email = model.Email;
                    //user.Address = model.Address;
                    user.Status = true;
                    var result = dao.Insert(user);
                    if (result > 0)
                    {
                        ViewBag.Success = "Succesfully registered";
                        model = new RegisterModel();
                    }
                    else
                    {
                        ModelState.AddModelError("", "Unsucessfully registered!!");
                    }
                }
            }
            return View(model);
        }


    }
}