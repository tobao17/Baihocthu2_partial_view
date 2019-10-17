using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.data
{
    public class productcontext :DbContext
    {
        public DbSet <Product>  Products { get; set; }
        public DbSet <cloth> Cloths { get; set; }
            
    }
}