using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace PostConsoleApplication
{
    
    public class Post
    {
        public int ID { get; set; }
        public string Message { get; set; }
        public Date Date { get; set; }
        
       public string SenderUserName { get; set; }
        public string ReceiverUserName { get; set; }
        public Condition Condition { get; set; }


        public string SenderUsername { get; set; }
        [ForeignKey("SenderUserName")]//
        public virtual User Sender { get; set; }

        public string ReceiverUsername { get; set; }
        [ForeignKey("ReceiverUserName")]
        public virtual User Receiver { get; set; }

    }
}



