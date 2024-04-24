using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TailorMS.Data;
using TailorMS.Models;

namespace TailorMS.Pages.User
{
    public class SendSmsModel : PageModel
    {
        DataDbContext db;
    public Sms Sms { get; set; }
        public SendSmsModel(DataDbContext _db)
        {
            db = _db;
        }
 
        [HttpPost]
        public IActionResult OnPost(Sms Sms)
        {
            db.Sms.Add(Sms);
            db.SaveChanges();
            return RedirectToPage("/Admin/SMS");
        }
    }
}
