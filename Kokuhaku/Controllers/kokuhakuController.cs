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
        private Ideta detarep;
        //デフォルトコンストラクター(標準のリポジトリを設定)
        public kokuhakuController() : this(new detaRepository()) { }
        //テスト用のコンストラクター(後でダミーのリポジトリをセット)
        public kokuhakuController(Ideta rep)
        {
            detarep = rep;
        }


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

        public ActionResult mail(int honki,int henzi,int reason,string name)
        {
                    //まとめのDB内のカラムがあればを削除
                    detarep.sakujo(name);

                    //カテゴリーに属する言葉を取得

                    //リポジトリを利用して指定のレコードを抽出
                    var query = detarep.detaSelect(honki);
                    var okaesi = detarep.ohenziSelect(henzi);
                    var watasi = detarep.riyuuSelect(reason);

                    //取り出した結果を一つのテーブルにまとめる
                    detarep.matomeSelect(query, okaesi, watasi, name);

                    //結果を画面に表示
                    var kekka = detarep.matomeGetAll();
 
                    return View(kekka);
        }
    }
}