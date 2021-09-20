using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstAuth2.Models
{
    public class DB : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> Roles { get; set; }
    }
}