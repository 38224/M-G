using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PokeM_G.Startup))]
namespace PokeM_G
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
