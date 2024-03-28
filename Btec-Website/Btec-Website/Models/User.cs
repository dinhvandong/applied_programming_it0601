﻿using System.ComponentModel.DataAnnotations;

namespace Btec_Website.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        // Other user properties as needed

        public int RoleId { get; set; }
        public Role Role { get; set; }

    }
}
