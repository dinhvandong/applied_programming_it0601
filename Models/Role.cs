﻿using System.ComponentModel.DataAnnotations;

namespace Btec_Website.Models
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
