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
        [MaxLength(100)]
        public string UserName { get; set;}
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Surname { get; set; }
        [Required]
        [MaxLength(16)]
        public string Password { get; set; }
        [Required]
        [MaxLength(150)]
        public string EPosta { get; set; }
        [MaxLength(1000)]       
        public string ImageURL { get; set; }
        public DateTime Birthday { get; set; }
        [Column(TypeName ="text")]
        public string Bio { get; set; }
        
    }
}