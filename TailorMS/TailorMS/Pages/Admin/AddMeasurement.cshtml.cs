using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TailorMS.Data;
using TailorMS.Models;

namespace TailorMS.Pages.Admin
{
    public class AddMeasurementModel : PageModel
    {
        DataDbContext db;
        public List<Customer> Customer { get; set; }  
        public Measurement measurement {  get; set; }
        public AddMeasurementModel(DataDbContext _db)
        {
            db= _db;
        }
        public void OnGet()
        {
            Customer = db.Customers.ToList();
        }
        [HttpPost]
        public IActionResult OnPost(Measurement measurement)
        {
            db.Measurements.Add(measurement);
            db.SaveChanges();
            return RedirectToPage("Measurement");
            
        }
    }
}
