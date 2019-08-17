using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;
using Model.Dao;

namespace webvitinh.Controllers
{
    public class ContentController : Controller
    {
        [HttpGet("tin-tuc")]
        public IActionResult Index(int page = 1, int pageSize = 10)
        {
            var model = new ContentDao().ListAll(page, pageSize);
            int totalRecord = 0;

            ViewBag.Total = totalRecord;
            ViewBag.Page = page;

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

        [HttpGet("tin-tuc/{metatitle}-{id}")]
        public IActionResult Detail (long id)
        {
            var model = new ContentDao().GetByID(id);
            ViewBag.Tags = new ContentDao().ListTag(id);
            return View(model);
        }

        [HttpGet("tag/{tagId}")]
        public ActionResult Tag(string tagId, int page = 1, int pageSize = 10)
        {
            var model = new ContentDao().ListAllByTag(tagId, page, pageSize);
            int totalRecord = 0;

            ViewBag.Total = totalRecord;
            ViewBag.Page = page;

            ViewBag.Tag = new ContentDao().GetTag(tagId);
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
    }
}