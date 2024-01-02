using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Payment
    {
          
     public int Id { get; set; }
    public string Payment_type { get; set; }
    public string Destination { get; set; }
    public int ProductId { get; set; }

     [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual User User { get; set; }
       

    }
}