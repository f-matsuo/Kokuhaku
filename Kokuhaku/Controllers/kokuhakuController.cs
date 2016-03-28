using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kokuhaku.Models;
using System.Collections;

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
        public ActionResult mail(int honki,int henzi,int reason,string name)//int id
        {
                    //まとめのDB内のカラムを削除
                      var sakujo =
                         from t in db.matomes
                         select t;
                    //カラムがあれば削除
                      if (sakujo != null)
                         {
                          foreach (var kesu in sakujo) {                       
                                db.matomes.Remove(kesu);
                                //DBに反映する
                                db.SaveChanges();
                             }
                        }

                    //カテゴリーに属する言葉を取得

                    var query = 
                        from x in db.honkis
                        where x.honki == honki
                        select x;

                    var okaesi =
                       from y in db.henzis
                       where y.henzi == henzi
                       select y;

                    var watasi=
                       from z in db.reasons
                       where z.reason == reason
                       select z;

                    //取り出した結果を一つのテーブルにまとめる
                    foreach(var x in query)
                    {
                        foreach(var y in okaesi)
                        {
                            foreach(var z in watasi)
                            {
                        db.matomes.Add(
                        new matome
                        {
                            name = name,
                            honkido = x.biko,
                            henzido = y.biko,
                            riyuudo = z.biko
                        }
                      );
                        //DBに反映する
                        db.SaveChanges();
                    }
                }
            }

            //結果を画面に表示
            var kekka =
                 from t in db.matomes
                 where t.name == name
                 select t;
 
                    return View(kekka);
        }
    }
}