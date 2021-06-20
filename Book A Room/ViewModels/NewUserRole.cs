using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Book_A_Room.Models;

namespace Book_A_Room.ViewModels
{
    public class NewUserRole
    {
        public IEnumerable<Microsoft.AspNet.Identity.EntityFramework.IdentityRole> roles{get;set;}
       public RegisterViewModel registerViewModel { get; set; }
                    
    }
}