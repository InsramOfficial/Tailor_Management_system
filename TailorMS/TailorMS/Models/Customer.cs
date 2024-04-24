using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TailorMS.Models
{
    [Table("customer")]
    public class Customer
    {
        [Key]
        public int id { get; set; }
        public string fullname { get; set; }
        public string phonenumber { get; set; }
        public string address { get; set; }
        public string sex { get; set; }
        public string email { get; set; }
        public string comment { get; set; }
        public string city { get; set; }
        public DateTime created_date { get; set; }
    }
}
