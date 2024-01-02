using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string BookName { get; set; }
        public string Category { get; set; }
        public string Date { get; set; }
        public string Book_Details { get; set; }
        public string Author_Name { get; set; }
        public int Seller_Id { get; set; }


        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual User User { get; set; }

    }
}