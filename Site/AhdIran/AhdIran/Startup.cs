using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AhdIran.Startup))]
namespace AhdIran

{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
