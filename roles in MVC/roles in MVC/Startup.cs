using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(roles_in_MVC.Startup))]
namespace roles_in_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
