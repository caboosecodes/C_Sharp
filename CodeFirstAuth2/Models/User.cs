using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirstAuth2.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        [ForeignKey("RoleId")] // must be the same to the id of UserRole Class
        public UserRole Role { get; set; }

        public User()
        {
            RoleId = 1;
            // will id=1 to db table by default
        }
    }
}