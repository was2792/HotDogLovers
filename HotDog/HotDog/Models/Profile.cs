using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;



namespace HotDog.Models
{
    public class Profile
    {
        public int ProfileID { get; set; }

        
        public string Name { get; set; }

       
        public string Favorite { get; set; }

        
        public string Location { get; set; }

       
        public string Bio { get; set; }

       
        public string Dog { get; set; }
    }
}