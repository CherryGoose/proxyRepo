using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace SecondModule;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(SecondModuleHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class SecondModuleConsoleApiClientModule : AbpModule
{

}
