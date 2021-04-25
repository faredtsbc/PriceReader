using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PriceReader.Entities;
namespace PriceReader.Data
{
    public class Context : DbContext
    {
        public Context() : base("name = con") { }

        public DbSet<Item> ITEMS { get; set; }
        public DbSet<Barcode> BARCODE { get; set; }
        public DbSet<Unit> UNITS { get; set; }
    }
}
