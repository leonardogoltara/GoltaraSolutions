using GoltaraSolutions.Common.Identity.Context;
using GoltaraSolutions.Common.Identity.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security.DataProtection;

namespace GoltaraSolutions.Common.Identity.Configuration
{
    public class ApplicationUserManager : UserManager<Usuario>
    {
        public ApplicationUserManager(IUserStore<Usuario> store)
            : base(store)
        {
            // Configurando validator para nome de usuario
            UserValidator = new UserValidator<Usuario>(this)
            {
                AllowOnlyAlphanumericUserNames = false
            };

            // Logica de validação e complexidade de senha
            PasswordValidator = new PasswordValidator
            {
                RequiredLength = 4,
                RequireNonLetterOrDigit = false,
                RequireDigit = false,
                RequireLowercase = false,
                RequireUppercase = false,
            };

            // Configuração de Lockout
            UserLockoutEnabledByDefault = false;
            //DefaultAccountLockoutTimeSpan = TimeSpan.FromMinutes(5);
            //MaxFailedAccessAttemptsBeforeLockout = 5;

            //// Providers de Two Factor Autentication
            //RegisterTwoFactorProvider("Código via SMS", new PhoneNumberTokenProvider<Usuario>
            //{
            //    MessageFormat = "Seu código de segurança é: {0}"
            //});

            //RegisterTwoFactorProvider("Código via E-mail", new EmailTokenProvider<Usuario>
            //{
            //    Subject = "Código de Segurança",
            //    BodyFormat = "Seu código de segurança é: {0}"
            //});

            // Definindo a classe de serviço de e-mail
            EmailService = new EmailService();

            //// Definindo a classe de serviço de SMS
            //SmsService = new SmsService();

            var provider = new DpapiDataProtectionProvider("SpaWeb");
            var dataProtector = provider.Create("ASP.NET Identity");

            UserTokenProvider = new DataProtectorTokenProvider<Usuario>(dataProtector);
        }

        public static ApplicationUserManager Create(IdentityFactoryOptions<ApplicationUserManager> options, IOwinContext context)
        {
            var manager = new ApplicationUserManager(new UserStore<Usuario>(context.Get<ApplicationDbContext>()));

            return manager;
        }
    }
}
