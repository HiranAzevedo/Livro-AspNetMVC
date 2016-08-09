using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PrimeiraAplicacao.Startup))]
namespace PrimeiraAplicacao
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
