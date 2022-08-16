using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(razorlect13.Startup))]
namespace razorlect13
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
