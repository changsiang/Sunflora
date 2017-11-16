using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sunflora.Startup))]
namespace Sunflora
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
