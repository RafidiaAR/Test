using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TechnicalTest.Models;

namespace TechnicalTest.Context
{
    public class DataContext : DbContext
    {
        public DbSet<TblBook> TblBooks { get; set; }
    }
}