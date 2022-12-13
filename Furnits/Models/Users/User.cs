using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Furnits.Models.Users
{
    public class User : IdentityUser
    {
        public User()
        {
        }

        public User(string userName) : base(userName)
        {
        }
    }
}
