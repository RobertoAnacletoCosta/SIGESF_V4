using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SIGESF.Startup))]
namespace SIGESF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
