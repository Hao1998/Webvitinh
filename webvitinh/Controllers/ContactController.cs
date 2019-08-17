using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model;
using Model.Dao;

namespace webvitinh.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet("lien-he")]
        public IActionResult Index()
        {
            var model = new ContactDao().GetActiveContact();
            return View(model);
        }

        [HttpPost]
        public JsonResult Send(string name, string mobile, string address, string email, string content)
        {
            var feedback = new FeedBack();
            feedback.Name = name;
            feedback.Phone = mobile;
            feedback.Address = address;
            feedback.Email = email;
            feedback.CreateDate = DateTime.Now;
            feedback.Content = content;

            var id = new ContactDao().InsertFeedBack(feedback);
            if (id > 0)
            {
                return Json(new
                {
                    status = true
                });
                //send mail if you want
            }
            else
                return Json(new
                {
                    status = false
                });

        }
    }
}