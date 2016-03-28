using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Kokuhaku.Models
{
    public class matome
    {
        [Key]
        public string name { get; set; }
        public string honkido { get; set; }
        public string henzido { get; set; }
        public string riyuudo { get; set; }
    }
}