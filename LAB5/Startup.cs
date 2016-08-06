using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LAB5.Startup))]
namespace LAB5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
