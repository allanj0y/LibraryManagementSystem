using LibraryMangement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LibraryMangement.Models
{
    public class UserModel
    {
        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }
        public int PhoneNumber { get; set; }  
        public string Email { get; set; }
        public string Password { get; set; }
        
        //[ForeignKey("RoleID")]
        //public virtual Role RoleID { get; set; }
    }
}