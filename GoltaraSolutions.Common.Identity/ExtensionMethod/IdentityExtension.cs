using GoltaraSolutions.Common.Identity.Configuration;
using GoltaraSolutions.Common.Identity.Context;
using GoltaraSolutions.Common.Identity.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Security.Principal;

namespace GoltaraSolutions.Common.Identity.ExtensionMethod
{
    public static class IdentityExtension
    {
        public static string GetName(this IIdentity identity)
        {
            ApplicationDbContext dbContext = new ApplicationDbContext();
            ApplicationUserManager userManager = new ApplicationUserManager(new UserStore<Usuario>(dbContext));
            Usuario user = userManager.FindById(identity.GetUserId());
            string name = string.Empty;
            if (user != null) { name = user.Nome; }

            return name;
        }
        public static Usuario GetUsuario(this IIdentity identity)
        {
            ApplicationDbContext dbContext = new ApplicationDbContext();
            ApplicationUserManager userManager = new ApplicationUserManager(new UserStore<Usuario>(dbContext));
            Usuario user = userManager.FindById(identity.GetUserId());

            return user;
        }
    }
}
