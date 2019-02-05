using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace TeamProject.Models
{
    public class Message
    {
        [Key]
        public int MessageID { get; set; }
        [Column(TypeName ="text")]
        public string SendMessage { get; set; }
        public DateTime SendDate { get; set; }

        [ForeignKey("UserLogin")]
        public int UserID { get; set; }
        public virtual UserLogin UserLogin { get; set; }

    }
}