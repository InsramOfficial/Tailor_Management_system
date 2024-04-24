using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TailorMS.Models
{
    [Table("documents")]
    public class Documents
    {
        [Key]
        public int id { get; set; }
        public string title { get; set; }
        public string detail { get; set; }
        public string img { get; set; }
        public DateTime created_date { get; set; }
    }
}
