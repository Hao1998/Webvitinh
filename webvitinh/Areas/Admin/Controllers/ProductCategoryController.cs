using System;
using PagedList.Core;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model;
using Model.Dao;
using OnlineShop.Areas.Admin.Controllers;

namespace webvitinh.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Route("Admin/[controller]")]
    public class ProductCategoryController : BaseController
    {
        OnlineShop1Context db = null;
        public ProductCategoryController()
        {
            db = new OnlineShop1Context();
        }

        //[Route("[action]")]
        //public IActionResult Index()
        //{           
        //    return View();
        //}


        [Route("[action]")]
        public IActionResult Index(int page = 1, int pageSize = 5)
        {
            int ToTalRecord = 0;
            var model = new ProductCategoryDao().ListProductCategory(ref ToTalRecord, page, pageSize);

            ViewBag.Total = ToTalRecord;
            ViewBag.Page = page;

            int maxPage = 5;
            int TotalPage = 0;

            TotalPage = (int)Math.Ceiling((double)(ToTalRecord / pageSize));
            ViewBag.TotalPage = TotalPage;
            ViewBag.MaxPage = maxPage;
            ViewBag.First = 1;
            ViewBag.Last = TotalPage;
            ViewBag.Next = page + 1;
            ViewBag.Prev = page - 1;

            return View(model);
        }

        [Route("[action]")]
        public JsonResult GetData()
        {
            var model = new ProductDao();
            var result = model.GetAllProduct();
            return Json(new { rows = result });
        }

        [Route("[action]")]
        public void AddProductCategoryJson(Product entity)
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

        [Route("[action]")]
        public void EditProductCategoryJson(Product entity)
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

        [Route("[action]")]
        public void DeleteProductCategoryJson(int id)
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

        public long categoryid;

       [Route("[action]")]
        public long GetId(long id)
        {
            categoryid = id;
            return categoryid;
        }

        [Route("[action]")]
        public JsonResult GetDetail(long categoryid)
        {
            var model = new ProductDao();
            var result = model.GetDetail(categoryid);
            return Json(result.ToArray());
        }
    }
}