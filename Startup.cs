namespace Summary.Liyam
{
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Options;
    using Core.DisplayManagement.Handlers;
    using Core.Modules;
    using Core.Navigation;
    using Core.Security.Permissions;
    using Core.Settings;
    using Core.Workflows.Helpers;
    using Summary.Liyam.Workflows.Event.Identity.Create;
    using Summary.Liyam.Workflows.Event.Identity.Update;

    [Feature(Liyam.Features.Liyam)]
    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<INavigationProvider, Menu>();
            services.AddScoped<IPermissionProvider, Permissions>();
            services.AddScoped<IDisplayDriver<ISite>, LiyamSettingsDisplayDriver>();
            services.AddTransient<IConfigureOptions<LiyamSettings>, LiyamSettingsConfiguration>();

            services.AddActivity<CreateProductEventInLiyamTask, CreateProductEventInLiyamDisplay>();
            services.AddActivity<UpdateProductEventInLiyamTask, UpdateProductEventInLiyamDisplay>();

            services.AddActivity<CreateIdentityEventInLiyam, CreateIdentityEventInLiyamDisplay>();
            services.AddActivity<UpdateIdentityEventInLiyam, UpdateIdentityEventInLiyamDisplay>();
        }
    }
}