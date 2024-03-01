using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApp.MysiticToDo.Startup))]
namespace WebApp.MysiticToDo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
