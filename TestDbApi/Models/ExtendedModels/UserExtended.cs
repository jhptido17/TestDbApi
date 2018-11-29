﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestDbApi.Models.ExtendedModels
{
    public class UserCustomerDetails
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }

    public class UserExtended
    {
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Roles Role { get; set; }
 
        public List<UserCustomerDetails> CustomerCreated { get; set; }
        public List<UserCustomerDetails> CustomerUpdated { get; set; }

        public UserExtended()
        {
        }
 
        public UserExtended(User user)
        {
            UserId = user.UserId;
            Username = user.Username;
            Password = user.Password;
            Role = user.Role;
        }
    }

    public class UserWithOutCustomerInfo
    {
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Roles Role { get; set; }

        public UserWithOutCustomerInfo()
        {
        }

        public UserWithOutCustomerInfo(User user)
        {
            UserId = user.UserId;
            Username = user.Username;
            Password = user.Password;
            Role = user.Role;
        }
    }

    public class UserWithOutPass
    {
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public Roles Role { get; set; }

        public UserWithOutPass()
        {
        }

        public UserWithOutPass(User user)
        {
            UserId = user.UserId;
            Username = user.Username;
            Role = user.Role;
        }
    }
}
