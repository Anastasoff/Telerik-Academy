using Microsoft.Owin;

[assembly: OwinStartup(typeof(Project.WebAPI.Startup))]

namespace Project.WebAPI
{
    using Owin;

    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}