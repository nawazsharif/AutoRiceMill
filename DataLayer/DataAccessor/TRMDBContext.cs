﻿using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataLayer.DataAccessor
{
    class TRMDBContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        //public DbSet<Product> Products { get; set; }
        //public DbSet<Supplier> Suppliers { get; set; }
        
    }
}
