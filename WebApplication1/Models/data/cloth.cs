using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.data
{
    public class cloth
    {
        
        [Key]
        public int idcloth { get; set; }


        public string datecloth { get; set; }
        public string title { get; set; }

        
        public int Productid { get; set; }
        public virtual List<Product> Product { get; set; }
    }
}