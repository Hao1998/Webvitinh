using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Model.Dao;

namespace webvitinh.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    [Route("[controller]")]
    public class ProductController : Controller
    {

        public IAuthenticationSchemeProvider authenticationSchemeProvider { get; set; }
        //public ProductController(IAuthenticationSchemeProvider authenticationSchemeProvider)
        //{
        //    this.authenticationSchemeProvider = authenticationSchemeProvider;
        //}

        //public ProductController(IOptions<MySeting> settings)
        //{
        //    if (settings != null && settings.Value != null)
        //    {
        //        authenticationSchemeProvider = new DependencyServiceImpl(settings.Value);
        //    }
        //}


        // GET: Product
        [Route("/")]
        [HttpGet("san-pham")]
        public IActionResult Index(int page = 1, int pageSize = 8)
        {
            int ToTalRecord = 0;
            var model = new ProductDao().AllProducts(ref ToTalRecord, page, pageSize);

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

        public JsonResult ListName(string q)
        {
            var data = new ProductDao().ListName(q);
            return Json(new
            {
                data = data,
                status = true
            });
        }


        [HttpGet("Search")]
        public IActionResult Search(string keyword, int page = 1, int pageSize = 5)
        {
            int totalRecord = 0;
            var model = new ProductDao().Search(keyword, ref totalRecord, page, pageSize);

            ViewBag.Total = totalRecord;
            ViewBag.Page = page;
            ViewBag.Keyword = keyword;
            int maxPage = 5;
            int totalPage = 0;

            totalPage = (int)Math.Ceiling((double)(totalRecord / pageSize));
            ViewBag.TotalPage = totalPage;
            ViewBag.MaxPage = maxPage;
            ViewBag.First = 1;
            ViewBag.Last = totalPage;
            ViewBag.Next = page + 1;
            ViewBag.Prev = page - 1;

            return View(model);
        }

        [HttpGet("san-pham/{metatitle}-{cateid}")]
        public IActionResult Category(long cateId, int page = 1, int pageSize = 5)
        {
            var category = new ProductCategoryDao().ViewDetail(cateId);
            ViewBag.Category = category;
            int ToTalRecord = 0;
            var model = new ProductDao().ListProductByCategoryId(cateId, ref ToTalRecord, page, pageSize);

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
            /*var category = new CategoryDao().ViewDetail(cateid);
            ViewBag.Category = category;
            int ToTalRecord = 0;
            var model = new ProductDao().ListProductByCategoryId(cateid,ref ToTalRecord, page, pageSize);
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
            ViewBag.Previus = page - 1;
            return View(model);*/
        }

        [Route("[action]")]
        [HttpGet("chi-tiet/{metatitle}-{id}")]
        public IActionResult Detail(int id)
        {
            var product = new ProductDao().ViewDetail(id);
            ViewBag.Category = new ProductCategoryDao().ViewDetail(product.CategoryId.Value);
            ViewBag.RelatedProduct = new ProductDao().ListRelatedProducts(id);
            return View(product);
        }


    }
}