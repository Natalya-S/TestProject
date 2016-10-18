using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestMVCProject.Startup))]
namespace TestMVCProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
