using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class TrackOrder
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string OrderDate { get; set; }
        public string ArrivalDate { get; set; }
        public string Status { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
