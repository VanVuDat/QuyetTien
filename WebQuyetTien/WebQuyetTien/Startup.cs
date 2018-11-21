using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebQuyetTien.Startup))]
namespace WebQuyetTien
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
