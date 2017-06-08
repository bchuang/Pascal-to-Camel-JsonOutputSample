using Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestWebSite.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Test(RoomList roomList)
        {
            var json = JsonConvert.SerializeObject(
                   roomList, Formatting.Indented,
                   new JsonSerializerSettings
                   {
                       ContractResolver = new CamelCasePropertyNamesContractResolver()
                   });
            return new JsonResult() { Data = json };
        }
    }
}