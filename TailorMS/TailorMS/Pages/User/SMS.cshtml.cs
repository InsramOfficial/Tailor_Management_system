using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TailorMS.Data;
using TailorMS.Models;

namespace TailorMS.Pages.User
{
    public class SMSModel : PageModel
    {

		DataDbContext db;
		public List<Sms> Sms { get; set; }
        public SMSModel(DataDbContext _db)
        {
			db = _db;
		}
        public void OnGet()
		{
			Sms = db.Sms.ToList();	
		}
	}
}
