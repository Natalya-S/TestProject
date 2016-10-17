using System.Data.Entity;

namespace DB
{
    class PermissionContext: DbContext
    {
        public PermissionContext() : base("DBConnection")
        { }

        public DbSet<Permission> Permissions { get; set; }
    }
}
