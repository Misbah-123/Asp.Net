using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(first_approach.Startup))]
namespace first_approach
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
