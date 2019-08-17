using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Model;
using Model.Dao;
using OnlineShop.Areas.Admin.Controllers;
using webvitinh.Areas.Admin.Models;
using webvitinh.Common;
using X.PagedList;
using X.PagedList.Mvc.Core;
using IFormFile = Microsoft.AspNetCore.Http.IFormFile;

namespace webvitinh.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]")]
    public class ContentController : BaseController
    {
        private readonly IHostingEnvironment he;
        public ContentController(IHostingEnvironment e)
        {
            he = e;
        }

        [Route("[action]")]
        public object Index(string searchString, int page = 1, int pageSize = 10)
        {
            var dao = new ContentDao();
            var model = dao.ListAllPaging(searchString);
            var result = model.ToPagedList(page, pageSize);
            ViewBag.SearchString = searchString;
            ViewBag.OnePageOfProduct = result;
            return View();
        }


        [HttpGet]
        [Route("[action]")]
        public IActionResult Create()
        {
            SetViewBag();
            return View();
        }

        
        [HttpGet]
        [Route("[action]/{id}")]
        public IActionResult Edit(long id)
        {
            var dao = new ContentDao();
            var content = dao.GetByID(id);

            SetViewBag(content.CategoryId);
            ContentCreateViewModel result = new ContentCreateViewModel
            {
                Name = content.Name,
                MetalTitle = content.MetalTitle,
                Description = content.Description,
                CategoryId = content.CategoryId,
                Detail = content.Detail,
                Warranty = content.Warranty, 
                ModifiedDate = content.ModifiedDate,
                ModifiedBy = content.ModifiedBy,
                MetaKeywords = content.MetaKeywords,
                MetaDescription = content.MetaDescription,
                Status = content.Status,
                TopHot = content.TopHot,
            };
            return View(result);
        }

        //[HttpPost]
        //[Route("[action]/{id}")]
        //public IActionResult Edit(Content model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var session = CommonConstants.USER_SESSION;
        //        model.ModifiedDate = DateTime.Now;
        //        model.ModifiedBy = session;
        //        new ContentDao().Edit(model);
        //        return RedirectToAction("Index");
        //    }
        //    SetViewBag(model.CategoryId);
        //    return View();
        //}

        [HttpPost]
        [Route("[action]")]
        public IActionResult Create(ContentCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;
                if (model.Image != null)
                {
                    string uploadsFolder = Path.Combine(he.WebRootPath, "images");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Image.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    model.Image.CopyTo(new FileStream(filePath, FileMode.Create));
                }
                Content content = new Content
                {
                   Name = model.Name,
                   MetalTitle = model.MetalTitle,
                   Description = model.Description,
                   CategoryId = model.CategoryId,
                   Detail = model.Detail,
                   Warranty = model.Warranty,
                   Image = uniqueFileName,
                   CreatedBy = CommonConstants.USER_SESSION,
                   ModifiedDate = model.ModifiedDate,
                   ModifiedBy = model.ModifiedBy,
                   MetaKeywords = model.MetaKeywords,
                   MetaDescription = model.MetaDescription,
                   Status = model.Status,
                   TopHot = model.TopHot,
                };
                new ContentDao().Create(content);
                return RedirectToAction("Index");
            }
            SetViewBag();
            return View();
        }

        [HttpPost]
        [Route("[action]/{id}")]
        public IActionResult Edit(ContentCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;
                if (model.Image != null)
                {
                    string uploadsFolder = Path.Combine(he.WebRootPath, "images");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Image.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    model.Image.CopyTo(new FileStream(filePath, FileMode.Create));
                }
                Content content = new Content
                {
                    Name = model.Name,
                    MetalTitle = model.MetalTitle,
                    Description = model.Description,
                    CategoryId = model.CategoryId,
                    Detail = model.Detail,
                    Warranty = model.Warranty,
                    Image = uniqueFileName,
                    ModifiedDate = model.ModifiedDate,
                    ModifiedBy = model.ModifiedBy,
                    MetaKeywords = model.MetaKeywords,
                    MetaDescription = model.MetaDescription,
                    Status = model.Status,
                    TopHot = model.TopHot,
                };
                new ContentDao().Edit(content);
                return RedirectToAction("Index");
            }
            SetViewBag();
            return View();
        }

        public void SetViewBag(long? selectedId = null)
        {
            var dao = new CategoryDao();
            ViewBag.CategoryID = new SelectList(dao.ListAll(), "Id", "Name", selectedId);
        }
    }
}