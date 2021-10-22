using System;
using Azure.Identity;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using Microsoft.Identity.Web;
using Microsoft.Identity.Web.UI;
using Microsoft.Marketplace.SaaS;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Logging;

namespace LandingPage
{

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Configure AAD and Graph integration
            services.AddMicrosoftIdentityWebAppAuthentication(this.Configuration) // Sign on with AAD
                    .EnableTokenAcquisitionToCallDownstreamApi(new string[] { "user.read" }) // Call Graph API
                    .AddMicrosoftGraph() // Use defaults with Graph V1
                    .AddInMemoryTokenCaches(); // Add token caching

            // Configure OpenIdConnect
            services.Configure<OpenIdConnectOptions>(options =>
            {
                options.Events.OnSignedOutCallbackRedirect = (context) =>
                {
                    context.Response.Redirect("/");
                    context.HandleResponse();

                    return Task.CompletedTask;
                };

            });

            // validate attributes in the JWT body - audience and issuer
            services.Configure<JwtBearerOptions>(JwtBearerDefaults.AuthenticationScheme, options =>
                {
                    options.TokenValidationParameters.ValidAudience = this.Configuration["MarketplaceApi:ClientId"];
                    options.TokenValidationParameters.ValidIssuer = $"https://sts.windows.net/{this.Configuration["MarketplaceApi:TenantId"]}/";
                });

            // add the marketplace client to services
            ConfigureMarketplaceServices(services);

            services.AddControllersWithViews(options =>
            {
                var policy = new AuthorizationPolicyBuilder()
                    .RequireAuthenticatedUser()
                    .Build();
                options.Filters.Add(new AuthorizeFilter(policy));
            });

            services.AddRazorPages()
                    .AddMicrosoftIdentityUI();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                
                endpoints.MapRazorPages();
            });
        }

        private void ConfigureMarketplaceServices(IServiceCollection services)
        {
            // get needed arguments from the Configuration in appsettings.json
            // or in the configuration settings in the Web Application
            var tenantId = Configuration["MarketplaceApi:TenantId"];
            var clientId = Configuration["MarketplaceApi:ClientId"];
            var clientSecret = Configuration["MarketplaceApi:ClientSecret"];

            // get standard Azure creds
            var creds = new ClientSecretCredential(tenantId, clientId, clientSecret);

            // register a MarketplaceSaaaSClient so it can be injected
            services.TryAddScoped<IMarketplaceSaaSClient>(sp =>
            {
                return new MarketplaceSaaSClient(creds);
            });
        }


    }
}
