using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cursinho.Startup))]
namespace Cursinho
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
