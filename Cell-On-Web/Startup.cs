using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cell_On_Web.Startup))]
namespace Cell_On_Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
