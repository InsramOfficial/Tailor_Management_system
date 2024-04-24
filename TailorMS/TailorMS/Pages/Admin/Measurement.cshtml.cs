using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TailorMS.Data;
using TailorMS.Models;

namespace TailorMS.Pages.Admin
{
    public class MeasurementModel : PageModel
	{
		DataDbContext db;
		public List<Measurement> Measurement { get; set; }
        public MeasurementModel(DataDbContext _db)
        {
			db = _db;
		}
        
		public void OnGet()
		{
			Measurement = db.Measurements.ToList();
		}
	}
}
