using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Smart.UI.EF2.CF.Models
{   [Table("Flag")]
    public class Flag
    {
        [ForeignKey("Country")]
        public int Id { get; set; }
        public string Color { get; set; }

        public Country Country { get; set; }
    }
}
