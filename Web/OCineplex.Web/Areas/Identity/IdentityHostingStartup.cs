using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(OCineplex.Web.Areas.Identity.IdentityHostingStartup))]

namespace OCineplex.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => { });
        }
    }
}
