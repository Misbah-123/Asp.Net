using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(homework_first_model.Startup))]
namespace homework_first_model
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
