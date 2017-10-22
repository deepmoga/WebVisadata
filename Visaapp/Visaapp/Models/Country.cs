using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Visaapp.Models
{
    public class Country
    {
        public int id { get; set; }
        [Display(Name="Country Name")]
        [Required (ErrorMessage="Please Enter Country Name")]
        public string CountryName { get; set; }
       
    }
}