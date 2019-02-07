using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TeamProject.Models
{
    public class TeamProjectContext:DbContext
    {
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<UserLogin> UserLogins { get; set; }
        public virtual DbSet<UserDetail> UserDetails { get; set; }

    }
}