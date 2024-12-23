﻿using System.ComponentModel.DataAnnotations;

namespace Frontend.Models
{
    public class UserViewModel
    {

        [Required]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberLogin { get; set; }
        public string? ReturnUrl { get; set; }

    }
}
