using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TeamProject.Models
{
    public class UserDetail
    {
        [ForeignKey("User")]
        public int UserDetailID { get; set; }
        [MaxLength(100)]
        public string NameSurname { get; set; }
        [MaxLength(1000)]
        public string ImageURL { get; set; }
        public DateTime Birthday { get; set; }
        [Column(TypeName = "text")]
        public string Bio { get; set; }
        public virtual UserLogin User { get; set; }
    }
}