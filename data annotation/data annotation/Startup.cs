using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(data_annotation.Startup))]
namespace data_annotation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
