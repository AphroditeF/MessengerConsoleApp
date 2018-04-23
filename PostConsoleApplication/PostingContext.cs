using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace PostConsoleApplication
{
    public class PostingContext:DbContext
    {
        public DbSet<User> Users { get; set; }
       // public DbSet<User> Receiver { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}

