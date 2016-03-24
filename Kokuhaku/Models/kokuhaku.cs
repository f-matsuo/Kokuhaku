using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Kokuhaku.Models
{
    public class kokuhaku
    {
        public int honki { get; set; }
        public int reason { get; set; }
        public int henzi { get; set; }

    }
}