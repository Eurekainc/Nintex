using Nintex.MyProfile.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Microsoft.AspNet;

namespace Nintex.MyProfile.Models
{
    public class ChangePasswordModel
    {
        [Required]
        public int ID { get; }

        [Required]
        [DataType(DataType.Password)]
        public string CurrentPassword { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [Compare("NewPassword")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }

    public class ChangeTimeZoneModel
    {
        [Required]
        public int ID { get; }

        [Required]
        public bool OverrideDefaultTimeZone { get; set; }

        [Required]
        public string TimeZone { get; set; }

    }

    public class RequestPersonPermissionModel
    {
        [Required]
        public int ID { get; }

        public void Method()
        {

        }
    }

    public class ProfileViewModel
    {
        public int ID { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string CompanyName { get; set; }
        public string ProfilePhoto { get; set; }
        public Nullable<DateTime> DefaultTimeZone { get; set; }
        public Nullable<DateTime> CurrentTimeZone { get; set; }

        public virtual ICollection<PersonPermission> PersonPermissions { get; set; }
    }
}