using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Smart.UI.EF2.CF.Models
{
    [Table("UserVisit")]
    public class UserVisits
    {
        public DateTime when { get; set; }
        [Key]
        [ForeignKey("City")]
        [Column(Order =1)]
        public int CityId { get; set; }
        [Key]
        [ForeignKey("User")]
        [Column(Order = 2)]
        public int UserId { get; set; }
        public City City { get; set; }
        public User User { get; set; }
    }
}
