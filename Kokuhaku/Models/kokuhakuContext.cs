using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Kokuhaku.Models
{
    public class kokuhakuContext : DbContext
    {
        public DbSet<deta> honkis { get; set; }
        public DbSet<riyuu> reasons { get; set; }
        public DbSet<ohenzi> henzis { get; set; }
    }
}