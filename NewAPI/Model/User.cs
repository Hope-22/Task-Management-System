using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace NewAPI.Model
{
    public class User: IdentityUser
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }
        public IEnumerable<UserTask> Tasks { get; set; }
       

        public User()
        {
            Tasks = new List<UserTask>();    
        }
    }
}
