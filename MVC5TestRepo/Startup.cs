using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC5TestRepo.Startup))]
namespace MVC5TestRepo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
