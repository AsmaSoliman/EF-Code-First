using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Smart.UI.EF2.CF.Models
{
    [Table("Country")]
    public class Country
    {
        [ForeignKey("Flag")]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        [Column(TypeName ="varchar")]
        public string Name { get; set; }

        public List<City> Cities { get; set; }

        public Flag Flag { get; set; }
    }
}
