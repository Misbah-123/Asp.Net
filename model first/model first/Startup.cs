using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(model_first.Startup))]
namespace model_first
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
