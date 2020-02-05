using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SaveOurSpecies.Startup))]
namespace SaveOurSpecies
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
