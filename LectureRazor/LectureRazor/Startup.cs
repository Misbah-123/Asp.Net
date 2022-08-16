using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LectureRazor.Startup))]
namespace LectureRazor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
