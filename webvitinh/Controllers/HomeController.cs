using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using webvitinh.Common;
using Model.Dao;
using System.IO;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using ApiAiSDK;

namespace webvitinh.Controllers
{


    public class HomeController : Controller
    {

        private string apiAiToken = "EAAiKnP1ObJwBAJOFTnrZCudhQe7LRrIJV7DMhPSjUNG6ZA5uCZC2wmNeMw2lwgNQ213sZCoeQlGgHx6ewkxcq2MyVP7psqUQFdptF2xy1PNCVbX9yNFoPCM4zsJDZAOLwL7AJ27pQJA1vHAmncNSZA98Qy5I1niQW7nZCHCsFSGcQZDZD";
        private string fbToken = "";
        private ApiAi apiAi;
        private string postUrl = "https://11bb5ed1.ngrok.io";

        [Route("/")]
        public IActionResult Index()
        {
            ViewBag.Slides = new SlideDao().ListAll();
            var ProductDao = new ProductDao();
            ViewBag.NewProducts = ProductDao.ListNewProduct(4);
            ViewBag.ListFeatureProducts = ProductDao.ListFeatureProduct(4);
            return View();
        }

        [HttpGet]
        public string Webhook(
           [FromQuery(Name = "hub.mode")] string mode,
           [FromQuery(Name = "hub.challenge")] string challenge,
           [FromQuery(Name = "hub.verify_token")] string verify_token)
        {
            if (verify_token.Equals("my_token_is_great"))
            {
                return challenge;
            }
            else
            {
                return "";
            }
        }


        [HttpPost]
        public void Webhook()
        {
            var json = (dynamic)null;
            try
            {
                using (StreamReader sr = new StreamReader(this.Request.Body))
                {
                    json = sr.ReadToEnd();
                }
                dynamic data = JsonConvert.DeserializeObject(json);
                postToFB((string)data.entry[0].messaging[0].sender.id, (string)data.entry[0].messaging[0].message.text);
            }
            catch (Exception ex)
            {
                return;
            }
        }

        public void postToFB(string recipientId, string messageText)
        {
            //Post to ApiAi
            string messageTextAnswer = postApiAi(messageText);
            string postParameters = string.Format("access_token={0}&recipient={1}&message={2}", fbToken, "{ id:" + recipientId + "}", "{ text:\"" + messageTextAnswer + "\"}");
            //Response from ApiAI or answer to FB question from user post it to   FB back.
            var client = new HttpClient();
            client.PostAsync(postUrl, new StringContent(postParameters, Encoding.UTF8, "application/json"));
        }

        public String postApiAi(string messageText)
        {
            var config = new AIConfiguration(apiAiToken,
                                             SupportedLanguage.English);
            apiAi = new ApiAi(config);
            var response = apiAi.TextRequest(messageText);
            return response.Result.Fulfillment.Speech;
        }

        public IActionResult Footer()
        {
            var model = new FooterDao().GetFooter();
            return PartialView(model);
        }
    }
}