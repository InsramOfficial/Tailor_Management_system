using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TailorMS.Data;
using TailorMS.Models;

namespace TailorMS.Pages.Admin
{
    public class CustomerModel : PageModel
    {
        DataDbContext db;
        public List<Customer > customers { get; set; }
        public CustomerModel(DataDbContext _db) 
        {
            db = _db;
        }
        public void OnGet()
        {
            customers = db.Customers.ToList();
        }
    }
}
