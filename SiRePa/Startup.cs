using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SiRePa.Startup))]
namespace SiRePa
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
