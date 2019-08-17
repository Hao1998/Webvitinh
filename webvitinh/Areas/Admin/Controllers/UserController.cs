using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model.Dao;
using OnlineShop.Areas.Admin.Controllers;
using StackExchange.Redis;
using Model;
using Newtonsoft.Json;
using webvitinh.Common;

namespace webvitinh.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]")]
    public class UserController : Controller
    {

        OnlineShop1Context db = null;
        public UserController()
        {
            db = new OnlineShop1Context();
        }

        [Route("[action]")]
        public IActionResult Index()
        {
            var model = new UserDao();
            var result = model.ListAll();
            return View(result);
        }


        [Route("[action]")]
        public JsonResult GetData()
        {
            var model = new UserDao();
            var result = model.ListAll();
            return Json(new { rows = result});
        }

        [Route("[action]")]
        public void AddUserJson(User entity)
        {
            try
            {
                var model = new UserDao();
                var encryptedMd5Pas = Encryptor.MD5Hash(entity.Password);
                entity.Password = encryptedMd5Pas;
                var result = model.AddUserJson(entity);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [Route("[action]")]
        public void EditUserJson(User entity)
        {
            try
            {
                var temp = entity;
                db.Entry(temp).State = EntityState.Modified;
                var encryptedMd5Pas = Encryptor.MD5Hash(temp.Password);
                temp.Password = encryptedMd5Pas;
                db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        [Route("[action]")]
        public void DeleteUserJson(long id)
        {
            try
            {
                var model = new UserDao();
                var result = model.DeleteUserJson(id);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}