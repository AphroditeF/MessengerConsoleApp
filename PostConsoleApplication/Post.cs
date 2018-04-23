using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace PostConsoleApplication
{
    
    public class Post
    {
        public int ID { get; set; }
        public string Message { get; set; }
        public Date Date { get; set; }
        
       
        public Condition Condition { get; set; }


        public string SenderUsername { get; set; }
        public virtual User Sender { get; set; }

        public string ReceiverUsername { get; set; }
        public virtual User Receiver { get; set; }

    }
}



