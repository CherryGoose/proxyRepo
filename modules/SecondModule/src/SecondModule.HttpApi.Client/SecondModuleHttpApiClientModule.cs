using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace SecondModule;

[DependsOn(
    typeof(SecondModuleApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class SecondModuleHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddStaticHttpClientProxies(
            typeof(SecondModuleApplicationContractsModule).Assembly,
            SecondModuleRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<SecondModuleHttpApiClientModule>();
        });

    }
}
