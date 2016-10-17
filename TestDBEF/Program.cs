using System;
using System.Linq;

namespace TestDBEF
{
    class Program
    {
        static void ListUsers(UserContext db, string comment)
        {
            // получаем объекты из бд и выводим на консоль
            var users = db.Users;
            Console.WriteLine(comment);
            foreach (User u in users)
            {
                Console.WriteLine("{0}.{1} - {2}", u.Id, u.Name, u.Age);
            }
        }

        static void InsertRecord(UserContext db, User userRec)
        {
            db.Users.Add(userRec);
            db.SaveChanges();
            Console.WriteLine("Объект успешно сохранен");
        }

        static void Main(string[] args)
        {
            using (UserContext db = new UserContext())
            {
                var users = db.Users;
                ListUsers(db, "Users (initial data):");
                
                //delete all records from DB:
                foreach (var r in users)
                {
                    users.Remove(r);
                }
                db.SaveChanges();
                Console.WriteLine("Records are deleted. Count = {0}", db.Users.Count());

                // создаем два объекта User
                InsertRecord(db, new User { Name = "Tom", Age = 33 });
                InsertRecord(db, new User { Name = "Sam", Age = 26 });

                ListUsers(db, "Users (after insert):");

                //update
                var userForUpdate = db.Users.Where(n => n.Name == "Tom").FirstOrDefault();
                userForUpdate.Age = 100;
                db.SaveChanges();

                ListUsers(db, "Users (after update):");

            }
            Console.Read();
        }
    }
}
