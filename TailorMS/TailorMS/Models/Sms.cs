using System.ComponentModel.DataAnnotations.Schema;

namespace TailorMS.Models
{
    [Table("sms")]
    public class Sms
    {
        public int id { get; set; }
        public string customer { get; set; }
        public string message { get; set; }
        public DateTime date { get; set; }
     
    }
}
