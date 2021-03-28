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

        public DbSet<Item> Items { get; set; }
        public DbSet<Barcode> Barcodes { get; set; }
        public DbSet<Unit> Units { get; set; }
    }
}
