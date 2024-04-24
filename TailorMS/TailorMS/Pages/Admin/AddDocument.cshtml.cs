using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TailorMS.Data;
using TailorMS.Models;
using TailorMS.VModels;

namespace TailorMS.Pages.Admin
{
    public class AddDocumentModel : PageModel
    {
        DataDbContext db;
        IWebHostEnvironment env;
        public Documents Documents { get; set; }
        public DocumentVM DocumentVM { get; set; }
        public AddDocumentModel(DataDbContext _db)
        {
            db = _db;

        }
        [HttpPost]
        public IActionResult OnPost(DocumentVM DocumentVM)
        {
            Documents.title = DocumentVM.title;
            Documents.detail = DocumentVM.detail;
            Documents.img = DocumentVM.img.FileName;
            Documents.created_date = DocumentVM.created_date;

            db.Documents.Add(Documents);
            db.SaveChanges();
            var folderpath = Path.Combine(env.WebRootPath, "images");
            var Imagepath = Path.Combine(folderpath, DocumentVM.img.FileName);
            DocumentVM.img.CopyTo(new FileStream(Imagepath, FileMode.Create));
            return RedirectToPage("Document");
        }
    }
}


