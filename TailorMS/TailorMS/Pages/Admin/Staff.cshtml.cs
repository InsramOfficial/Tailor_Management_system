using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TailorMS.Data;
using TailorMS.Models;

namespace TailorMS.Pages.Admin
{
    public class StaffModel : PageModel
    {
        DataDbContext db;
        public List<Staff> staffs { get; set; }
        public StaffModel(DataDbContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
            staffs=db.Staffs.ToList();
        }
    }
}
