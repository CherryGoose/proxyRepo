using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace SecondModule;

[DependsOn(
    typeof(SecondModuleDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class SecondModuleApplicationContractsModule : AbpModule
{

}
