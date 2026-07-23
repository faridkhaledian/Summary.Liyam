namespace Summary.Liyam
{
    using Microsoft.Extensions.Localization;
    using Core.Navigation;
    using System;
    using System.Threading.Tasks;

    public class Menu : INavigationProvider
    {
        private readonly IStringLocalizer<Menu> _localizer;

        public Menu(IStringLocalizer<Menu> localizer)
        {
            _localizer = localizer;
        }

        public Task BuildNavigationAsync(string name, NavigationBuilder builder)
        {
            if (!String.Equals(name, "admin", StringComparison.OrdinalIgnoreCase)) return Task.CompletedTask;

            builder.Add(_localizer["Configuration"], configuration =>
            {
                configuration.Add(_localizer["Settings"], settings =>
                {
                    settings.Add(_localizer["حسابداری لیام"], _localizer["حسابداری لیام"], itemBuilder =>
                    {
                        itemBuilder.Action("Index", "Admin", new { area = "Core.Settings", groupId = "Liyam" })
                            .Permission(Permissions.ManageLiyamSettings)
                            .LocalNav();
                    });
                });
            });

            return Task.CompletedTask;
        }
    }
}