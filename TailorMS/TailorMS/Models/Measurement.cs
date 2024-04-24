using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TailorMS.Models
{
    [Table("measurement")]
    public class Measurement
    {
        [Key]

        public int measurement_id { get; set; }
        public int customer_id { get; set; }
       
      
        public DateTime created_date { get; set; }
        
        public string hip_measurement { get; set; }

       
        public string bust_measurement { get; set; }

       
        public string waist_measurement { get; set; }

       
        public string ideal_dress_length { get; set; }

       
        public string ideal_neckline_width { get; set; }

       
        public string ideal_strap_length { get; set; }
        public string height { get; set; }
    }
}
