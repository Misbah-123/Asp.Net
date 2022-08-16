using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(stronglymethod.Startup))]
namespace stronglymethod
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
