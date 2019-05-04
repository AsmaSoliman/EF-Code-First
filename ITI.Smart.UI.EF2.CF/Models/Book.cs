using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Smart.UI.EF2.CF.Models
{   [Table("Book")]
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
      
        [Required]
        public City City { get; set; }
        public Cover Cover { get; set; }
    }
}
