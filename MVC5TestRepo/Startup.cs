using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using MVC5TestRepo.Models.SportStoreIdentity;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC5TestRepo.Startup))]
namespace MVC5TestRepo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.CreatePerOwinContext<StoreIdentityDbContext>(StoreIdentityDbContext.Create);
            app.CreatePerOwinContext<StoreRoleManager>(StoreRoleManager.Create);
            app.CreatePerOwinContext<StoreUserManager>(StoreUserManager.Create);

            app.UseCookieAuthentication(new CookieAuthenticationOptions()
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie
            });
            //ConfigureAuth(app);
        }
    }
}
