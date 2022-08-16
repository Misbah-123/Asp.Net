using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AUTHORIZATION.Startup))]
namespace AUTHORIZATION
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
