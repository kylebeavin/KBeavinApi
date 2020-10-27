using System;
using KBeavin.UI.Areas.Identity.Data;
using KBeavin.UI.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(KBeavin.UI.Areas.Identity.IdentityHostingStartup))]
namespace KBeavin.UI.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<KBeavinUIContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("DefaultConnection")));

                services.AddDefaultIdentity<KBeavinUIUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<KBeavinUIContext>();
            });
        }
    }
}