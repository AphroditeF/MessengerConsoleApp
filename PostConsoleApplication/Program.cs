using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace PostConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var db = new PostingContext())
            {

                Console.Write("Enter a name for a new User: ");
                var username = Console.ReadLine();
                Console.Write("Enter a password: ");
                var password = Console.ReadLine();

                var user = new User { Username = username };
                db.Users.Add(user);
                db.SaveChanges();

                //var post

                // Display all Blogs from the database 
                var query = from b in db.Users
                            orderby b.Username
                            select b;

                Console.WriteLine("All blogs in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Username);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();


            }
        }
    }
    
}



