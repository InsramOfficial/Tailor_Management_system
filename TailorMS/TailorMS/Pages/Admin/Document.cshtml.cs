using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TailorMS.Data;
using TailorMS.Models;

namespace TailorMS.Pages.Admin
{
    public class DocumentModel : PageModel
    {
        DataDbContext db;
        public List<Documents> Document { get; set; }
        public DocumentModel(DataDbContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
            Document = db.Documents.ToList();
        }
    }
}
