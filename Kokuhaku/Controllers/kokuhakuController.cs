using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kokuhaku.Models;

namespace Kokuhaku.Controllers
{
    public class kokuhakuController : Controller
    {
        private kokuhakuContext db = new kokuhakuContext();
        // GET: kokuhaku
        public ActionResult Index()
        {
            return View(db.kokuhakus);
        }
    }
}