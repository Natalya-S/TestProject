using System;
namespace DB
{
    class CreateDBTables
    {
        static void Main(string[] args)
        {
            using (PermissionContext db = new PermissionContext())
            {
                db.Database.CreateIfNotExists();
                //Console.WriteLine("Permissions table is created");
            }
        }
    }
}
