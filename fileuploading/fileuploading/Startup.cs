using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(fileuploading.Startup))]
namespace fileuploading
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
