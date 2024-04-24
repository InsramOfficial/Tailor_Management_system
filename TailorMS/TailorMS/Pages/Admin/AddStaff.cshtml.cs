using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TailorMS.Data;
using TailorMS.Models;

namespace TailorMS.Pages.Admin
{
    public class AddStaffModel : PageModel
    {
        DataDbContext db;
        public Staff staff { get; set; }
        public AddStaffModel(DataDbContext _db)
        {
            db= _db;
        }

        [HttpPost]
        public IActionResult OnPost(Staff staff)
        {
            db.Staffs.Add(staff);
            db.SaveChanges();
            return RedirectToPage("Staff");
        }
    }
}
