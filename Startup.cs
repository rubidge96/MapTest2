using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MapTest.Startup))]
namespace MapTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
