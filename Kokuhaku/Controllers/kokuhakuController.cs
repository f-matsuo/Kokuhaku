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
            // 選択ボックスのReasonを準備
            ViewBag.SelectReason = new SelectListItem[] {
                new SelectListItem() { Value="1", Text="可愛い" },
                new SelectListItem() { Value="2 ", Text="話しやすい" },
                new SelectListItem() { Value="3", Text="なんとなく" }
           };
            // 選択ボックスのHonkiを準備
            ViewBag.SelectHonki = new SelectListItem[] {
                new SelectListItem() { Value="1", Text="結婚まで" },
                new SelectListItem() { Value="2 ", Text="付き合いたい" },
                new SelectListItem() { Value="3", Text="そこまで" }
           };
            // 選択ボックスのHenziを準備
            ViewBag.SelectHenzi = new SelectListItem[] {
                new SelectListItem() { Value="1", Text="すぐにでも" },
                new SelectListItem() { Value="2 ", Text="一週間後ぐらい" },
                new SelectListItem() { Value="3", Text="そのうち" }
           };

            return View();
        }
        public ActionResult mail(int id)
        {
            //引数をキーに記事情報を取得
            kokuhaku kokuhaku = db.kokuhakus.Find(id);
            return View(kokuhaku);
        }
    }
}