using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SearchbyAjax.Startup))]
namespace SearchbyAjax
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
