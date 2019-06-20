using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TransportServices.Data.AdminDbModels
{
    [Table("AspNetUsers")]
    public class UserModel
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string PhoneNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [System.ComponentModel.DefaultValue(true)]
        public bool EmailConfirmed { get; set; }
        [System.ComponentModel.DefaultValue(false)]
        public bool PhoneNumberConfirmed { get; set; }
        [System.ComponentModel.DefaultValue(false)]
        public bool LockoutEnabled { get; set; }
        [System.ComponentModel.DefaultValue(0)]
        public int AccessFailedCount { get; set; }
        [System.ComponentModel.DefaultValue(false)]
        public bool TwoFactorEnabled { get; set; }
    }
}
