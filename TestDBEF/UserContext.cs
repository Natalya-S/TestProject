using System.Data.Entity;

namespace TestDBEF
{
	class UserContext : DbContext
	{
		public UserContext()
			: base("DbConnection")
		{ }

		public DbSet<User> Users { get; set; }
	}
}
	