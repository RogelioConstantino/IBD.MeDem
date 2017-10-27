using Microsoft.Owin;
using Owin;
// cambio rcr 
[assembly: OwinStartupAttribute(typeof(IBD.MEDEM.WebMVC.Startup))]
namespace IBD.MEDEM.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
