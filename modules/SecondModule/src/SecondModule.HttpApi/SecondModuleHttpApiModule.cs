using Localization.Resources.AbpUi;
using SecondModule.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace SecondModule;

[DependsOn(
    typeof(SecondModuleApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class SecondModuleHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(SecondModuleHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<SecondModuleResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
