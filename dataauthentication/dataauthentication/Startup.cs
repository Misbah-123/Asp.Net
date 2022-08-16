using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dataauthentication.Startup))]
namespace dataauthentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
