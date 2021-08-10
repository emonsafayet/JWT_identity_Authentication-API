﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAuthentication.DTO
{
    public class UserDTO
    {
        public string  FullName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public DateTime DateCreated { get; set; }
        public string Token { get; set; }

        public UserDTO(string fullName,string email,string userName,DateTime dateCreated)
        {
            FullName = fullName;
            Email = email;
            UserName = userName;
            DateCreated = dateCreated;
        }

    }
}