using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kokuhaku.Models
{
    public class TestRepository:Ideta
    {
        //すべてのdeta情報を取得
        public IEnumerable<deta> detaGetAll()
        {
            //ダミーのdetaオブジェクトを3件作成
            var detas = new List<deta>();

            for (var i = 1; i<4 ; i++)
            {
                detas.Add(
                new deta()
                {
                    honki = i,
                    biko = "ゆくゆくは【結婚まで】いけたらと思ってる。 "
                }
              );
            }
            return detas;
        }

        //指定されたレコードをDBから取得
        public IQueryable<deta> detaSelect(int honki)
        {
            IQueryable<deta> a;
            return a;
        }

        //すべてのriyuu情報を取得
        public IEnumerable<riyuu> riyuuGetAll()
        {
            //ダミーのdetaオブジェクトを3件作成
            var riyuus = new List<riyuu>();

            for (var i = 1; i < 4; i++)
            {
                riyuus.Add(
                new riyuu()
                {
                    reason = i,
                    biko = "ゆくゆくは【結婚まで】いけたらと思ってる。 "
                }
              );
            }
            return riyuus;
        }

        //指定されたレコードをDBから取得
        public IQueryable<riyuu> riyuuSelect(int reason)
        {
            IQueryable<riyuu> a;
            return a;
        }

        //すべてのohenzi情報を取得
        public IEnumerable<ohenzi> ohenziGetAll()
        {
            //ダミーのdetaオブジェクトを3件作成
            var ohenzis = new List<ohenzi>();

            for (var i = 1; i < 4; i++)
            {
                ohenzis.Add(
                new ohenzi()
                {
                    henzi = i,
                    biko = "ゆくゆくは【結婚まで】いけたらと思ってる。 "
                }
              );
            }
            return ohenzis;
        }

        //指定されたレコードをDBから取得
        public IQueryable<ohenzi> ohenziSelect(int henzi)
        {
            IQueryable<ohenzi> a;
            return a;
        }

        //すべてのmatome情報を取得
        public IEnumerable<matome> matomeGetAll()
        {
            //ダミーのdetaオブジェクトを1件作成
            var matome = new List<matome>();

                matome.Add(
                new matome()
                {
                    name = "わたし",
                    honkido = "ゆくゆくは【結婚まで】いけたらと思ってる。 ",
                    henzido = "ゆくゆくは【結婚まで】いけたらと思ってる。 ",
                    riyuudo = "ゆくゆくは【結婚まで】いけたらと思ってる。 "
                }
              );
            return matome;
        }

        //指定されたレコードをDBに格納
        public void matomeSelect(IEnumerable<deta> deta, IEnumerable<ohenzi> ohenzi, IEnumerable<riyuu> riyuu, string name)
        {
            
        }

        public void sakujo(string name)
        {
           
        }

    }
}
    }
}