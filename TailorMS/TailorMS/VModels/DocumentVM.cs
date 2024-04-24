using System.ComponentModel.DataAnnotations;

namespace TailorMS.VModels
{
    public class DocumentVM
    {
        [Key]
        public int id { get; set; }
        public string title { get; set; }
        public string detail { get; set; }
        public IFormFile img { get; set; }
        public DateTime created_date { get; set; }
    }
}
