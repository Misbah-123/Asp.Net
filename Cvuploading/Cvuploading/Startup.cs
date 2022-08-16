using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cvuploading.Startup))]
namespace Cvuploading
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
