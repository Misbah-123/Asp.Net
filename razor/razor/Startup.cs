using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(razor.Startup))]
namespace razor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
