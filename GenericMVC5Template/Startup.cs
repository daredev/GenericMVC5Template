using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GenericMVC5Template.Startup))]
namespace GenericMVC5Template
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
