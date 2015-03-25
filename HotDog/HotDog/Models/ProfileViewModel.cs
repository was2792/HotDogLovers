using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotDog.Models
{
    public class ProfileViewModel
    {
        public List<String> Dogs { get; set; }
        public List<String> Locs { get; set; }
        public Profile Profile { get; set; }
    }
}