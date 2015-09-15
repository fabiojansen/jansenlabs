using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JansenLabs.Startup))]
namespace JansenLabs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
