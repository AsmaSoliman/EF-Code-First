using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Smart.UI.EF2.CF.Models
{
    [Table("Cover")]
    public class Cover
    {
        public int Id { get; set; }
        public string Code { get; set; }

        public Book Book { get; set; }
    }
}
