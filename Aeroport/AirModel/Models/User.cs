using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirModel.Models
{
    public class User : IGenericModel
    {

        public int Id { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public bool IsPersistent { get; set; }

        public string Email { get; set; }

        public string AvatarPath { get; set; }

        public DateTime Birthdate { get; set; }

        public virtual ICollection<Role> UserRoles { get; set; }

       
    }
}