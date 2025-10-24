using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hlangalezwe_Dental_System.Startup))]
namespace Hlangalezwe_Dental_System
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
