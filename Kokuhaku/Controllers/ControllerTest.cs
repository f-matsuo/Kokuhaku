using System;
using Kokuhaku.Controllers;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kokuhaku.Controllers
{
    [TestClass]
    public class ControllerTest
    {
        
        public ActionResult Index()
        {
            return View();
        }
    }
}