using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Outgoings.Models;
using Newtonsoft.Json;

namespace Outgoings.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult getOutgoingsByUserId()
        {
            OutgoingsModel data = new OutgoingsModel() { Title = "Título" };


            return new ContentResult()
            {
                ContentType = "application/json",
                Content = JsonConvert.SerializeObject(data)
            };
        }
    }
}
