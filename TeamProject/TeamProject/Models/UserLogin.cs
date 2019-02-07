using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TeamProject.Models
{
    
    public class UserLogin
    {
        [Key]
        public int UserID { get; set; }
        [Required]
        [MaxLength(150)]
        public string EPosta { get; set; }
        [Required]
        [MaxLength(16)]
        public string Password { get; set; } 
        [Required]
        [MaxLength(100)]
        public string UserName { get; set; }
        public virtual UserDetail UserDetail { get; set; }
        public virtual List<Message> Messages { get; set; }

    }
}