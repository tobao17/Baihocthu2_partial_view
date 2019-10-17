using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.data
{
    public class Product
    {
        [PrimaryKey]
        public int Productid { get; set; }
        public string Name { get; set; }
        public  virtual cloth Cloth { get; set; }
    }
}