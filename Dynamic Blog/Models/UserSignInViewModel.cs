﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicBlog.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adınızı girin.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen parolanızı girin.")]
        public string Password { get; set; }

        public bool IsPersistent { get; set; }
    }
}