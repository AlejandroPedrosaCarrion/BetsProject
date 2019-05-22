using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BetsProject.Web.Data.Entities
{
    public class Country
    {
        
        public int id { get; set; }
        [Required]
        public string code { get; set; }
        public string country { get; set; }
        public string flag { get; set; }
    }
}
