using Book_A_Room.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using System.Linq;

[assembly: OwinStartupAttribute(typeof(Book_A_Room.Startup))]
namespace Book_A_Room
{
    public partial class Startup
    {

        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);


        }

    }
}


