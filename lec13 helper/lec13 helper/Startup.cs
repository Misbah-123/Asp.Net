using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lec13_helper.Startup))]
namespace lec13_helper
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
