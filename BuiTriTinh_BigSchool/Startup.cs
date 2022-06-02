using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BuiTriTinh_BigSchool.Startup))]
namespace BuiTriTinh_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
