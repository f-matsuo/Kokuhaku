using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kokuhaku.Models
{
    public interface Ideta
    {
        IEnumerable<deta> detaGetAll();
        IQueryable<deta> detaSelect(int honki);

        IEnumerable<ohenzi> ohenziGetAll();
        IQueryable<ohenzi> ohenziSelect(int henzi);

        IEnumerable<riyuu> riyuuGetAll();
        IQueryable<riyuu> riyuuSelect(int reason);

        IEnumerable<matome> matomeGetAll();
        void sakujo(string name);
        void matomeSelect(IEnumerable<deta> deta, IEnumerable<ohenzi> ohenzi, IEnumerable<riyuu> riyuu,string name);
    }
}
