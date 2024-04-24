using Microsoft.EntityFrameworkCore;
using TailorMS.Models;

namespace TailorMS.Data
{
    public class DataDbContext:DbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext>options):base(options)
        {
            
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Documents> Documents { get; set; }
		public DbSet<Measurement> Measurements { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<Staff>Staffs { get; set; }
		public DbSet<Sms> Sms { get; set; }
		public DbSet<User> Users { get; set; }
	}
}
