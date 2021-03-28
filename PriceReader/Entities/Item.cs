using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceReader.Entities
{
    [Table("ITEMS")]
    public class Item
    {
        [Key]
        public int ITEM_ID { get; set; }
        public string ITEM_NAME { get; set; }
    }
}
