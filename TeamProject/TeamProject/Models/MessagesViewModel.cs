using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeamProject.Models
{
    public class MessagesViewModel
    {
        public List<Message> Messages { get; set; }
        public List<UserLogin> UserLogins { get; set; }
    }
}