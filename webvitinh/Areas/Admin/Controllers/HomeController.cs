using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Rewrite.Internal.UrlActions;
using Microsoft.EntityFrameworkCore;
using Model;
using Model.Dao;
using Common;
using OnlineShop.Areas.Admin.Controllers;

namespace webvitinh.Areas.Admin.Controllers
{
    //internal class CredentityAttribute : AuthorizeAttribute
    //{
    //    string POLICY_PREFIX = Common.CommonConstants.SESSION_CREDENTIALS;

    //    public CredentityAttribute(string credentity) => Credentity = credentity;

    //    // Get or set the Age property by manipulating the underlying Policy property
    //    public string Credentity
    //    {
    //        get
    //        {
    //            //if (int.TryParse(Policy.Substring(POLICY_PREFIX.Length), out var credentity))
    //            //{
    //            //    return credentity;
    //            //}
    //            //return default(string);
    //            string credentity;
    //            credentity = POLICY_PREFIX;
    //            return credentity;
    //        }
    //        set
    //        {
    //            Policy = $"{POLICY_PREFIX}{value.ToString()}";
    //        }
    //    }
    //}

    [Area("Admin")]
    [Route("Admin/[controller]")]
    //[Route("[controller]")]
    //[ApiController]
    public class HomeController : Controller
    {
        OnlineShop1Context db = null;
        public HomeController()
        {
            db = new OnlineShop1Context();
        }

        [Route("[action]")]
        //[Credentity("ADMIN")]
        public IActionResult Index()
        {
            return View();
        }
        //[Produces("application/xml")]

        [HttpGet]
        [Route("[action]")]
        public JsonResult GetOrder()
        {
            var model = new OrderDao();
            var result = model.GetOrder();
            return Json(new { rows = result });
        }

        //[Route("[action]")]
        //public JsonResult getOrderDetail(long id)
        //{
        //    var model = new OrderDetailDao();
        //    var objective = model.GetOrderDetails(id);
        //    int totalrecord = objective.Count();
        //    List<object> l = GetObjecFromList(objective);

        //    var jsonData = new
        //    {
        //        records = totalrecord
        //    };
        //    return Json(jsonData);
        //}


        
        //[Route("[action]")]
        //public  List<object> GetObjecFromList(IQueryable<OrderDetail> Objective)
        //{
        //    List<object> l = new List<object>();
        //    foreach(var objective in Objective)
        //    {
        //        l.Add(new
        //        {
        //            id = objective.OrderId,
        //            cell = new string[] { objective.OrderId.ToString(), objective.Price.ToString(), objective.ProductId.ToString(), objective.Quantity.ToString() }
        //        });
        //    }
        //    return l;
        //}


        [HttpGet]
        [Route("[action]")]
        //[HttpGet("{id}")]
        public JsonResult OrdersDetailsSubgridData(long id)
        {
            var model = new OrderDetailDao();
            var result = model.GetOrderDetails((Convert.ToInt64(id)));
            return Json(new { rows = result });
        }

        [HttpPost]
        [Route("[action]")]
        public void AddOrderJson(Order entity)
        {
            try
            {
                var model = new OrderDao();
                var result = model.AddOrderJson(entity);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        [Route("[action]")]
        public void EditOrderJson(Order entity)
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

        [HttpDelete("{id}")]
        [Route("[action]")]
        public void DeleteOrderJson(long id)
        {
            try
            {
                var model = new OrderDao();
                var result = model.DeleteOrderJson(id);
                var model_2 = new OrderDetailDao();
                var result_2 = model_2.DeleteOrderDetailJson(id);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}