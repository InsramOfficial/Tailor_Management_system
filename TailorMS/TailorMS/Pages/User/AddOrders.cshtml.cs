using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TailorMS.Data;
using TailorMS.Models;

namespace TailorMS.Pages.User
{
    public class AddOrdersModel : PageModel
    {
        DataDbContext db;
        public Order orders { get; set; }
        public List<Customer> customers { get; set; }
        public AddOrdersModel(DataDbContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
            customers=db.Customers.ToList();
        }
        [HttpPost]
        public IActionResult OnPost(Order orders)
        {
            db.Orders.Add(orders);
            db.SaveChanges();
            return RedirectToPage("AddOrders");
        }
    }
}
