using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Kokuhaku.Models
{
    public class riyuu
    {
        [Key]
        public int reason { get; set; }
        public string biko { get; set; }
    }
}