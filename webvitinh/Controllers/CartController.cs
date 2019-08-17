using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model;
using Model.Dao;
using Newtonsoft.Json;
using webvitinh.Models;
using MailKit;
using MimeKit;
using Common;

namespace webvitinh.Controllers
{
    public class CartController : Controller
    {
        private const string CartSession = "cart";

        // GET: Cart
        [HttpGet("gio-hang")]
        public IActionResult Index()
        {
            var temp = SessionHelper.SessionHelper.GetTObjectFromJson<List<CartItem>>(HttpContext.Session, CartSession);
            SessionHelper.SessionHelper.GetTObjectFromJson<List<CartItem>>(HttpContext.Session, CartSession);
            var list = new List<CartItem>();
            if (temp != null)
            {
                list = (List<CartItem>)temp;
            }
            return View(list);
        }

        public JsonResult DeleteAll()
        {
            List<CartItem> cart = SessionHelper.SessionHelper.GetTObjectFromJson<List<CartItem>>(HttpContext.Session, CartSession);
            cart.Clear();
            SessionHelper.SessionHelper.SetObjectAsJson(HttpContext.Session, CartSession, cart);
            return Json(new
            {
                status = true
            });
        }

 
        public JsonResult Delete(long id)
        {
            List<CartItem> SessionCart = SessionHelper.SessionHelper.GetTObjectFromJson<List<CartItem>>(HttpContext.Session, CartSession);
            SessionCart.RemoveAll(x => x.Product.Id == id);
            SessionHelper.SessionHelper.SetObjectAsJson(HttpContext.Session, CartSession, SessionCart);
            return Json(new
            {
                status = true
            });
        }


        public JsonResult Update(string cartModel)
        {
            var jsoncart = JsonConvert.DeserializeObject<List<CartItem>>(cartModel);
            var SessionCart = SessionHelper.SessionHelper.GetTObjectFromJson<List<CartItem>>(HttpContext.Session, CartSession);

            foreach (var item in SessionCart)
            {
                var jsonItem = jsoncart.SingleOrDefault(x => x.Product.Id == item.Product.Id);
                if (jsonItem != null)
                {
                    item.Quantity = jsonItem.Quantity;
                }
            }
            SessionHelper.SessionHelper.SetObjectAsJson(HttpContext.Session, CartSession, SessionCart);
            return Json(new
            {
                status = true
            });
        }



        [HttpGet("them-gio-hang")]
        public IActionResult AddItem(int productID, int quantity)
        {
            var product = new ProductDao().ViewDetail(productID);
            var cart = SessionHelper.SessionHelper.GetTObjectFromJson<List<CartItem>>(HttpContext.Session, CartSession);

            //nếu như cart đã có
            if (cart != null)
            {
                var list = (List<CartItem>)cart;
                if (list.Exists(x => x.Product.Id == productID))
                {
                    foreach (var item in list)
                    {
                        if (item.Product.Id == productID)
                        {
                            item.Quantity += quantity;
                        }
                    }
                }
                else
                {
                    //tạo mới đối tượng cart item
                    var item = new CartItem();
                    item.Product = product;
                    item.Quantity = quantity;
                    list.Add(item);
                }
                //gán vào session
                SessionHelper.SessionHelper.SetObjectAsJson(HttpContext.Session, CartSession, list);
            }
            else
            {
                //tạo mới đối tượng cart item
                var item = new CartItem();
                item.Product = product;
                item.Quantity = quantity;
                var list = new List<CartItem>();
                list.Add(item);

                //gán vào session
                //list = SessionHelper.SessionHelper.GetTObjectFromJson<List<CartItem>>(HttpContext.Session, "cart");
                SessionHelper.SessionHelper.SetObjectAsJson(HttpContext.Session, CartSession, list);
                var temp = SessionHelper.SessionHelper.GetTObjectFromJson<List<CartItem>>(HttpContext.Session, CartSession);
            }
            return RedirectToAction("Index");
        }


        [HttpGet("thanh-toan")]
        public IActionResult Payment()
        {
            var cart = SessionHelper.SessionHelper.GetTObjectFromJson<List<CartItem>>(HttpContext.Session, CartSession);
            var list = new List<CartItem>();
            if (cart != null)
            {
                list = (List<CartItem>)cart;
            }
            return View(list);
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult Payment(string shipName, string mobile, string address, string email)
        {
            var order = new Model.Order();
            order.CreateDate = DateTime.Now;
            order.ShipAddress = address;
            order.ShipEmail = email;
            order.ShipName = shipName;
            order.ShipMobile = mobile;

            try
            {
                var id = new OrderDao().Insert(order);
                var cart = SessionHelper.SessionHelper.GetTObjectFromJson<List<CartItem>>(HttpContext.Session, CartSession);
                decimal total = 0;
                var detailDao = new OrderDetailDao();
                foreach (var item in cart)
                {
                    var orderDetail = new OrderDetail();
                    orderDetail.ProductId = item.Product.Id;
                    orderDetail.OrderId = id;
                    orderDetail.Price = item.Product.Price;
                    orderDetail.Quantity = item.Quantity;
                    detailDao.Insert(orderDetail);

                    total += (item.Product.Price.GetValueOrDefault(0) * item.Quantity);
                }

                //var message = new MimeMessage();
                MailMessage message = new MailMessage(new MailAddress("tonynet142@gmail.com", "Hao Lyhien"), new MailAddress(email));
                //message.From.Add(new MailboxAddress("Hao Lyhien","tonynet142@gmail.com"));

                //message.To.Add(new MailboxAddress("Đơn hàng mới từ Web vi tính", "hienhao142@gmail.com"));

                message.Subject = "Đơn hàng mới từ webvitinh";           

                string content = System.IO.File.ReadAllText("wwwroot/Client/template/neworder.html");
                content = content.Replace("{{OrderId}}", id.ToString());
                content = content.Replace("{{CustomerName}}", shipName);
                content = content.Replace("{{Phone}}", mobile);
                content = content.Replace("{{Email}}", email);
                content = content.Replace("{{Address}}", address);
                content = content.Replace("{{Total}}", total.ToString("N0"));          

                message.Body = content;

                var credentials = new NetworkCredential("tonynet142@gmail.com", "ronaldo142");
                using (var client = new SmtpClient())
                {
                    client.Port = 587;
                    client.Host = "smtp.gmail.com";
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    client.EnableSsl = true;
                    client.Credentials = credentials;
                    client.Send(message);
                }
            }
            catch (Exception ex)
            {
                //ghi log
                return Redirect("/loi-thanh-toan");
            }
            return Redirect("/hoan-thanh");
        }

        [HttpGet("thanh-toan-paypal")]
        public IActionResult PayPalCheckOut()
        {
            var cart = SessionHelper.SessionHelper.GetTObjectFromJson<List<CartItem>>(HttpContext.Session, CartSession);
            var list = new List<CartItem>();
            if (cart != null)
            {
                list = (List<CartItem>)cart;
            }
            return View(list);
        }

        [HttpGet("get-paypal")]
        public IActionResult GetDataPaypal()
        {
            var getData = new GetDataPaypal();
            var order = getData.InformationOrder(getData.GetPayPalResponse(Request.Query["tx"].ToString()));
            ViewBag.tx = Request.Query["tx"].ToString();
            return View();
        }




        [HttpGet("hoan-thanh")]
        public IActionResult Success()
        {
            return View();
        }
    }
}