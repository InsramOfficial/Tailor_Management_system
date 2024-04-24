using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TailorMS.Data;
using TailorMS.Models;

namespace TailorMS.Pages.Admin
{
    public class OrdersModel : PageModel
    {
        DataDbContext db;
        public List<Order> orders {  get; set; }
        public OrdersModel(DataDbContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
            
            orders=db.Orders.ToList();
        }
    }
}
