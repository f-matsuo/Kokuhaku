using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Kokuhaku.Models
{
    public class kokuhakuInitializer:DropCreateDatabaseAlways<kokuhakuContext>
    {
        protected override void Seed(kokuhakuContext context)
        {
            var detas = new List<deta>
            {
                new deta
                {
                    honki = 1,
                    biko = "ゆくゆくは【結婚まで】いけたらと思ってる。 "
                },
                new deta
                {
                    honki = 2,
                    biko = "君がよければ【付き合いたい】と思ってる。 "
                },
                new deta
                {
                    honki = 3,
                    biko = "今度町を【一緒に】歩きたい。 "
                }
            };
            var ohenzis = new List<ohenzi>
            {
                new ohenzi
                {
                    henzi = 1,
                    biko = "【すぐにでも】返事がほしい。 "
                },
                new ohenzi
                {
                   henzi = 2,
                   biko = "【一週間後】ぐらいまでには返事がほしい。"
                },
                new ohenzi
                {
                    henzi = 3,
                    biko = "【そのうち】返信してくれればいい。"
                }
            };
            var riyuus = new List<riyuu>
            {
                new riyuu
                {
                    reason = 1,
                    biko = "君が【可愛い】からいつの間にか好きになってた。"
                },
                new riyuu
                {
                    reason = 2,
                    biko = "【話しやすくて】気づいたら好きになってた。"
                },
                new riyuu
                {
                    reason = 3,
                    biko = "なんか【好き】になってた。"
                }
            };
       /*     var matomes = new List<matome>
            {
                new matome
                {
                    id = 1,
                    biko = "ゆくゆくは【結婚まで】いけたらと思ってる。【すぐにでも】返事がほしい。君が【可愛い】からいつの間にか好きになってた。"
                },
                new matome
                {
                    id = 2,
                    biko = "君がよければ【付き合いたい】と思ってる。【すぐにでも】返事がほしい。君が【可愛い】からいつの間にか好きになってた。"
                },
                new matome
                {
                    id = 3,
                    biko = "今度町を【一緒に】歩きたい。【すぐにでも】返事がほしい。君が【可愛い】からいつの間にか好きになってた。"
                },
                new matome
                {
                    id = 4,
                    biko = "ゆくゆくは【結婚まで】いけたらと思ってる。【一週間後】ぐらいまでには返事がほしい。君が【可愛い】からいつの間にか好きになってた。"
                },
                new matome
                {
                    id = 5,
                    biko = "ゆくゆくは【結婚まで】いけたらと思ってる。【そのうち】返信してくれればいい。君が【可愛い】からいつの間にか好きになってた。"
                },
                new matome
                {
                    id = 6,
                    biko = "ゆくゆくは【結婚まで】いけたらと思ってる。【すぐにでも】返事がほしい。【話しやすくて】気づいたら好きになってた。"
                },
                new matome
                {
                    id = 7,
                    biko = "ゆくゆくは【結婚まで】いけたらと思ってる。【すぐにでも】返事がほしい。なんか【好き】になってた。"
                },
                new matome
                {
                    id = 8,
                    biko = "君がよければ【付き合いたい】と思ってる。【一週間後】ぐらいまでには返事がほしい。君が【可愛い】からいつの間にか好きになってた。"
                },
                new matome
                {
                    id = 9,
                    biko = "君がよければ【付き合いたい】と思ってる。【そのうち】返信してくれればいい。君が【可愛い】からいつの間にか好きになってた。"
                },
                new matome
                {
                    id = 10,
                    biko = "君がよければ【付き合いたい】と思ってる。【すぐにでも】返事がほしい。【話しやすくて】気づいたら好きになってた。"
                },
                new matome
                {
                    id = 11,
                    biko = "君がよければ【付き合いたい】と思ってる。【すぐにでも】返事がほしい。なんか【好き】になってた。"
                }
            }; */
            //オブジェクトを追加,データソースに反映
            detas.ForEach(m => context.honkis.Add(m));
            ohenzis.ForEach(m => context.henzis.Add(m));
            riyuus.ForEach(m => context.reasons.Add(m));
            context.SaveChanges();
        }
    }
}