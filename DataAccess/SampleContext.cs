using DataAccess.Models;
using System.Data.Entity;

namespace DataAccess
{
	public class SampleContext : DbContext
    {
        public SampleContext()
			: base("DbConnection")
	{ }

	public DbSet<Physician> Physicians { get; set; }
}
}
