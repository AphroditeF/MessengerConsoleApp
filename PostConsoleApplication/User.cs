using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PostConsoleApplication
{
    
    public class User
    {
        [Key]
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role {get; set; }

        public virtual List<Post> Posts { get; set; }

    }
}
