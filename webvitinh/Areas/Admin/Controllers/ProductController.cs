using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model;
using Model.Dao;
using OnlineShop.Areas.Admin.Controllers;
using webvitinh.Common;

namespace webvitinh.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]")]
    public class ProductController : BaseController
    {
        OnlineShop1Context db = null;
        public ProductController()
        {
            db = new OnlineShop1Context();
        }

        [Route("[action]")]
        public IActionResult Index()
        {
            var model = new ProductDao();
            var result = model.GetAllProduct();
            return View(result);
        }

        [Route("[action]")]
        public IActionResult Test()
        {
            var model = new ProductDao();
            var result = model.GetAllProduct();
            return View(result);
        }


        [Route("[action]")]
        public JsonResult GetData()
        {
            var model = new ProductDao();
            var result = model.GetAllProduct();
            return Json(new { rows = result });
        }

        [HttpPost]
        [Route("[action]")]
        public void AddProductJson(Product entity)
        {
            try
            {
                var model = new ProductDao();
                var result = model.AddProductJson(entity);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPut]
        [Route("[action]")]
        public void EditProductJson(Product entity)
        {
            try
            {
                var temp = entity;
                db.Entry(temp).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpDelete]
        [Route("[action]")]
        public void DeleteProductJson(int id)
        {
            try
            {
                var model = new ProductDao();
                var result = model.DeleteProductCategoryJson(id);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}