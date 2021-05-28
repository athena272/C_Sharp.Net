using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DogAndPeople.Startup))]
namespace DogAndPeople
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
