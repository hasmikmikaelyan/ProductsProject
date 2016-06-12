using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProductsProject.Startup))]
namespace ProductsProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
