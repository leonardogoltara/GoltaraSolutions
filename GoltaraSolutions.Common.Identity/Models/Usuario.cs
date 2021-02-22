using GoltaraSolutions.Common.Extensions;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GoltaraSolutions.Common.Identity.Models
{
    public class Usuario : IdentityUser
    {
        public string Nome { get; set; }

        public long IdEmpresa { get; set; }

        //public string Telefone { get; set; }

        //public string Celular { get; set; }

        //public DateTime DataNascimento { get; set; }

        //public string CPF { get; set; }

        public bool Deletado { get; set; }

        public string Ativo
        {
            get
            {
                return (!Deletado).ToCustomString();
            }
        }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<Usuario> manager)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            new OwinContext().Authentication.SignIn(new AuthenticationProperties() { IsPersistent = true }, userIdentity);

            return userIdentity;
        }
    }
}
