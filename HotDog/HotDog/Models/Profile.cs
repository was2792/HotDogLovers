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

        [Display(Name="Full Name")]
        public string Name { get; set; }

        [Display(Name="Favorite Hot Dog")]
        public string Favorite { get; set; }

        [Display(Name="Location of Last Dog Eaten")]
        public string Location { get; set; }

        [Display(Name="Personal Hot Dog Facts")]
        public string Bio { get; set; }

       [Display(Name="Most Recent Dog Eaten")]
        public string Dog { get; set; }
    }
}