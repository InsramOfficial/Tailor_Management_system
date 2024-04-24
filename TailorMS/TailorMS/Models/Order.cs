using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TailorMS.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        public int id { get; set; }
        public int customer { get; set; }
        public string description { get; set; }
        public decimal amount { get; set; }
        public int received_by { get; set; }
        public string completed { get; set; }
       
    }
}
