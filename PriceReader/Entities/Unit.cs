using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceReader.Entities
{
    [Table("UNITS")]
    public class Unit
    {
        [Key]
        public int UNIT_ID { get; set; }
        public string UNIT_DISC { get; set; }
    }
}
