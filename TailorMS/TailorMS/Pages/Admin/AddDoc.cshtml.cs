using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TailorMS.Data;
using TailorMS.Models;
using TailorMS.VModels;

namespace TailorMS.Pages.Admin
{
    public class AddDocModel : PageModel
    {
        IWebHostEnvironment env;
        DataDbContext db;
        public DocumentVM DocumentVM { get; set; }
        public AddDocModel(DataDbContext _db,IWebHostEnvironment env)
        {
            db= _db;
            this.env = env;
        }
        public IActionResult OnPost(DocumentVM DocumentVM)
        {
            Documents documents = new Documents();
            documents.title = DocumentVM.title;
            documents.detail = DocumentVM.detail;
            documents.img = DocumentVM.img.FileName;

            db.Documents.Add(documents);
            db.SaveChanges();

            var folderpath = Path.Combine(env.WebRootPath, "images");
            var Imagepath = Path.Combine(folderpath, DocumentVM.img.FileName);
            DocumentVM.img.CopyTo(new FileStream(Imagepath, FileMode.Create));
            return RedirectToPage("Document");

        }
    }
}
