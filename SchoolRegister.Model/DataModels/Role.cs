using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolRegister.Model.DataModels
{
    public class Role: IdentityRole<int>
    {
        public RoleValue RoleValue { get; set; }

        public Role() {

        }

        public Role(String name, RoleValue roleValue) {

        }
    }
}