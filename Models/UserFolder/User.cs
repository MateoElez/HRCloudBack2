﻿using Microsoft.AspNetCore.Identity;
using ProjectAPI.Models.CartFolder;
using ProjectAPI.Models.UserFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Models
{
    public class User : TEntity
    {
        public User() { }

        public User(UserDto userDto)
        {
            Id = userDto.Id;
            FirstName = userDto.FirstName;
            LastName = userDto.LastName;
            Password = userDto.Password;
            Username = userDto.Username;

        }
        [Required]
        [Column(TypeName= "nvarchar(150)")]
        public virtual string Username { get; set; }

        [Required]
        public virtual string Password { get; set; }

        [Required]
        public virtual string FirstName { get; set; }

        [Required]
        public virtual string LastName { get; set; }

        public virtual List<Cart> CartItems { get; set; }

       // public virtual Item Cart { get; set; }
    }
}
