﻿using BookStore.models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.models.Models
{
    public class RegisterModel
    {
        public RegisterModel() { }
        public RegisterModel(User user)
        {
            Firstname = user.Firstname;
            Lastname = user.Lastname;
            Email = user.Email;
            Password = user.Password;
            Roleid = user.Roleid;
        }
        public string Firstname { get; set; } = null!;
        public string Lastname { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int Roleid { get; set; }

        
    }
}
