using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DOT_Ksiega_gosci.Startup))]
namespace DOT_Ksiega_gosci
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
