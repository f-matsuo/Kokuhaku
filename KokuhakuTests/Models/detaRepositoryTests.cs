using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kokuhaku.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kokuhaku.Models.Tests
{
    public class detaRepositoryTests:Ideta
    {
        //すべてのdeta情報を取得
        public IEnumerable<deta> detaGetAll()
        {
            //ダミーを作成
            var list = new List<deta>();
            for(var i = 1; i < 4; i++)
            {
                list.Add(
                    new deta()
                    {
                        honki = i,
                        biko = "われわれは宇宙"
                    });
            }
            return list;
        }

        //指定されたレコードをDBから取得
        public IQueryable<deta> detaSelect(int honki)
        {
            detaGetAll();
            return null;
        }

        //すべてのriyuu情報を取得
        public IEnumerable<riyuu> riyuuGetAll()
        {
            //ダミーを作成
            var list = new List<riyuu>();
            for (var i = 1; i < 4; i++)
            {
                list.Add(
                    new riyuu()
                    {
                        reason = i,
                        biko = "われわれは宇宙"
                    });
            }
            return list;
        }

        //指定されたレコードをDBから取得
        public IQueryable<riyuu> riyuuSelect(int reason)
        {
            riyuuGetAll();
            return null;
        }

        //すべてのohenzi情報を取得
        public IEnumerable<ohenzi> ohenziGetAll()
        {
            //ダミーを作成
            var list = new List<ohenzi>();
            for (var i = 1; i < 4; i++)
            {
                list.Add(
                    new ohenzi()
                    {
                        henzi = i,
                        biko = "われわれは宇宙"
                    });
            }
            return list;
        }

        //指定されたレコードをDBから取得
        public IQueryable<ohenzi> ohenziSelect(int henzi)
        {
            ohenziGetAll();
            return null;
        }

        //すべてのmatome情報を取得
        public IEnumerable<matome> matomeGetAll()
        {
            //ダミーを作成
            var list = new List<matome>();
            for (var i = 0; i < 1; i++)
            {
                list.Add(
                    new matome()
                    {
                        name = "なめ",
                        honkido = "われわれは宇宙",
                        henzido = "われわれは宇宙",
                        riyuudo = "われわれは宇宙"
                    });
            }
            return list;
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