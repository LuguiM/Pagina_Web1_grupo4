using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PaginaWeb1_grupo4.Startup))]
namespace PaginaWeb1_grupo4
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
