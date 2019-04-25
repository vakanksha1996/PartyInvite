using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartyInvites.Models
{
    public class guest
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public bool will_attend { get; set; }
        public long phone { get; set; }
    }
}