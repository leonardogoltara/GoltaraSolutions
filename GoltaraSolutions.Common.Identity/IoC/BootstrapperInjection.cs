using GoltaraSolutions.Common.Identity.Configuration;
using GoltaraSolutions.Common.Identity.Context;
using GoltaraSolutions.Common.Identity.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Ninject;

namespace GoltaraSolutions.Common.Identity.IoC
{
    public static class BootstrapperInjection
    {
        public static void Load(IKernel kernel)
        {
            // Binding do ApplicationDbContext
            kernel.Bind<ApplicationDbContext>().ToSelf();

            // Binding do ApplicationUserManager 
            kernel.Bind<IUserStore<Usuario>>().ToMethod((u) => new UserStore<Usuario>(kernel.Get<ApplicationDbContext>()));
            kernel.Bind<IUserStore<Usuario, string>>().ToMethod((u) => new UserStore<Usuario>(kernel.Get<ApplicationDbContext>()));
            kernel.Bind<ApplicationUserManager>().ToSelf();

            // Binding do ApplicationRoleManager
            kernel.Bind<IRoleStore<IdentityRole, string>>().ToMethod((r) => new RoleStore<IdentityRole>(kernel.Get<ApplicationDbContext>()));
            kernel.Bind<ApplicationRoleManager>().ToSelf();

            // Binding do ApplicationSignInManager
            kernel.Bind<ApplicationSignInManager>().ToSelf();
        }
    }
}
