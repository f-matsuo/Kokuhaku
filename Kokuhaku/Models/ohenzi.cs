using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Kokuhaku.Models
{
    public class ohenzi
    {
        [Key]
        public int henzi { get; set; }
        public string biko { get; set; }
    }
}