using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class User
    {
        public int  UserId { get; set; }

        [Required]
        public string UserName { get; set; }
       
        [Required]
        [StringLength(20)]
        public string UserPassword { get; set; }

        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<ProductInventory> ProductInventories { get; set; }
        public virtual ICollection<TrackOrder> TrackOrders { get; set; }
        

        public User()
        {
            Products = new List<Product>();
            Payments = new List<Payment>();
            ProductInventories = new List<ProductInventory>();
            TrackOrders = new List<TrackOrder>();
          
        }
    }
}
