using System.Threading.Tasks;
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
using Microsoft.Marketplace.Metering;

namespace PublisherPortal;

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

        ConfigureMarketplaceFulfillmentService(services);

        services.AddControllersWithViews(options =>
        {
            var policy = new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser()
                .Build();
            options.Filters.Add(new AuthorizeFilter(policy));
        });

        this.ConfigureMarketplaceFulfillmentService(services);

        services.AddRazorPages()
            .AddMicrosoftIdentityUI().AddMvcOptions(options => {});
            
        services.AddAuthorization(options=>{options.FallbackPolicy = options.DefaultPolicy;});
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

            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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
                name: "update",
                pattern: "{controller=Pubisher}/{action=Update}/{subscriptionId:Guid}/{planId}/{operationId:Guid}");

            endpoints.MapControllerRoute(
                name: "operations",
                pattern: "{controller=Pubisher}/{action=Operations}/{subscriptionId:Guid}/{operationId:Guid}");

            endpoints.MapControllerRoute(
                name: "activate_update",
                pattern: "{controller=Pubisher}/{action=Activate}/{id:Guid}/{planId}");

            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            endpoints.MapRazorPages();
            endpoints.MapControllers();
        });
    }

    private void ConfigureMarketplaceFulfillmentService(IServiceCollection services)
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
            // ReSharper disable once ConvertToLambdaExpression
            return new MarketplaceSaaSClient(creds);
        });

        services.TryAddScoped<IMarketplaceMeteringClient>(sp =>
        {
            return new MarketplaceMeteringClient(creds);
        });
    }
}