using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Smart.UI.EF2.CF.Models
{
    [Table("City")]
    public class City
    {

        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string Name { get; set; }

        public int CountryId { get; set; }
        public Country Country { get; set; }
        public List<UserVisits> UserVisists { get; set; }
        public Book Book { get; set; }
    }
}
