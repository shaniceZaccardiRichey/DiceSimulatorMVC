using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Weeks5and6Project.Startup))]
namespace Weeks5and6Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
