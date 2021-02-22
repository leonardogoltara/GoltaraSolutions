using System.Threading.Tasks;
using Microsoft.Owin;
using Microsoft.AspNet.Identity.Owin;
using GoltaraSolutions.Common.Identity.Models;
using Microsoft.Owin.Security;
using System.Security.Claims;

namespace GoltaraSolutions.Common.Identity.Configuration
{
    public class ApplicationSignInManager : SignInManager<Usuario, string>
    {
        public ApplicationSignInManager(ApplicationUserManager userManager, IAuthenticationManager authenticationManager) :
            base(userManager, authenticationManager)
        {
        }

        public override Task<ClaimsIdentity> CreateUserIdentityAsync(Usuario user)
        {
            return user.GenerateUserIdentityAsync((ApplicationUserManager)UserManager);
        }

        public static ApplicationSignInManager Create(IdentityFactoryOptions<ApplicationSignInManager> options, IOwinContext context)
        {
            return new ApplicationSignInManager(context.GetUserManager<ApplicationUserManager>(), context.Authentication);
        }

        public override Task SignInAsync(Usuario user, bool isPersistent, bool rememberBrowser)
        {
            return base.SignInAsync(user, isPersistent, rememberBrowser);
        }
        public async override Task<SignInStatus> PasswordSignInAsync(string userName, string password, bool isPersistent, bool shouldLockout)
        {
            SignInStatus retorno = await base.PasswordSignInAsync(userName, password, isPersistent, shouldLockout);
            Usuario u = await UserManager.FindAsync(userName, password);
            if (u?.Deletado != true)
            {
                return retorno;
            }
            else
            {
                retorno = await base.PasswordSignInAsync("", "", isPersistent, shouldLockout);
            }

            return retorno;
        }
    }
}
