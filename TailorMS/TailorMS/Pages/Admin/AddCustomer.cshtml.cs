using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TailorMS.Data;
using TailorMS.Models;

namespace TailorMS.Pages.Admin
{
    public class AddCustomerModel : PageModel
    {
        DataDbContext db;
        public Customer customer {  get; set; }
        public AddCustomerModel(DataDbContext _db )
        {
            db = _db;
        }
        [HttpPost]
        public IActionResult OnPost(Customer customer)
        {
            db.Customers.Add(customer);
            db.SaveChanges();
            return RedirectToPage("Customer");
        }
    }
}
