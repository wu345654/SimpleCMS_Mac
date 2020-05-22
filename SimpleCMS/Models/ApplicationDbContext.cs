using System;
using Microsoft.AspNet.Identity.EntityFramework;
using NLog;

namespace SimpleCMS.Models
{
    public class ApplicationDbContext:IdentityDbContext<ApplicationUser,ApplicationRole,int,ApplicationUserLogin,ApplicationUserRole,ApplicationUserClaim>
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public ApplicationDbContext():base("DefaultConnection")
        {
            Database.Log = Logger.Info;
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
