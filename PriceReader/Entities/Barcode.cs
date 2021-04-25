using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceReader.Entities
{
    [Table("BARCODE")]
    public class Barcode
    {
        [Key]
        public int BAR_ID { get; set; }
        public int ITEM_ID { get; set; }
        public int UNIT_ID { get; set; }
        
        public string BARCODE { get; set; }
        public double PRICE1 { get; set; }
        public double UNIT_QTY { get; set; }
    }
}
