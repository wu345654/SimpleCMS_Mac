using System;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace SimpleCMS.Models
{
    public class ApplicationUserLogin : IdentityUserLogin<int> { }
    public class ApplicationUserClaim : IdentityUserClaim<int> { }
    public class ApplicationUserRole : IdentityUserRole<int> { }
    public class ApplicationRole : IdentityRole<int, ApplicationRole>, IRole<int>
    {
        public string Description { get; set; }
        public ApplicationRole() : base() { }
        public ApplicationRole(string name)
            : this()
        {
            this.Name = name;
        }
        public ApplicationRole(string name, string description)
            : this(name)
        {
            this.Description = description;
        }
    }
}
