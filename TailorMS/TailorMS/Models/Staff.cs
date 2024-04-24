using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TailorMS.Models
{
    [Table("staff")]
    public class Staff
    {
        [Key]
        public int id { get; set; }
        public string stafftype { get; set; }
        public string fullname { get; set; }
        public string address { get; set; }
        public string phonenumber { get; set; }
        public string salary { get; set; }
      
      
    }
}
