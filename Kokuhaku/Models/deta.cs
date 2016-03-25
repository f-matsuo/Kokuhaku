using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Kokuhaku.Models
{
    public class deta
    {
        [Key]
        public int honki { get; set; }
        public string biko { get; set; }
    }
}