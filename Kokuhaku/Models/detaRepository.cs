using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kokuhaku.Models
{
    public class detaRepository:Ideta
    {
        //コンテキストクラスを準備
        private kokuhakuContext db = new kokuhakuContext();

        //すべてのdeta情報を取得
        public IEnumerable<deta> detaGetAll()
        {
            return db.honkis;
        }

        //指定されたレコードをDBから取得
        public IQueryable<deta> detaSelect(int honki)
        {
            var query = db.honkis
                .Where(a => a.honki == honki)
                .Select(a => a);

            return query;
        }

        //すべてのriyuu情報を取得
        public IEnumerable<riyuu> riyuuGetAll()
        {
            return db.reasons;
        }

        //指定されたレコードをDBから取得
        public IQueryable<riyuu> riyuuSelect(int reason)
        {
            var watasi = db.reasons
                        .Where(a => a.reason == reason)
                        .Select(a => a);

            return watasi;
        }

        //すべてのohenzi情報を取得
        public IEnumerable<ohenzi> ohenziGetAll()
        {
            return db.henzis;
        }

        //指定されたレコードをDBから取得
        public IQueryable<ohenzi> ohenziSelect(int henzi)
        {
            var okaesi = db.henzis
                        .Where(a => a.henzi == henzi)
                        .Select(a => a);

            return okaesi;
        }

        //すべてのmatome情報を取得
        public IEnumerable<matome> matomeGetAll()
        {
            return db.matomes;
        }

        //指定されたレコードをDBに格納
        public void matomeSelect(IEnumerable<deta> deta, IEnumerable<ohenzi> ohenzi, IEnumerable<riyuu> riyuu, string name)
        {
            //取り出した結果を一つのテーブルにまとめる
            foreach (var x in deta)
            {
                foreach (var y in ohenzi)
                {
                    foreach (var z in riyuu)
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
        }

        public void sakujo(string name)
        {
            //まとめのDB内のカラムを削除
            var sakujo = db.matomes
                         .Select(a => a);
            //カラムがあれば削除
            if (sakujo != null)
            {
                foreach (var kesu in sakujo)
                {
                    db.matomes.Remove(kesu);
                    //DBに反映する
                    db.SaveChanges();
                }
            }
        }

    }
}