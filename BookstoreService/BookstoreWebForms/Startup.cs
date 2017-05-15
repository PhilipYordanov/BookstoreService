using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookstoreWebForms.Startup))]
namespace BookstoreWebForms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
