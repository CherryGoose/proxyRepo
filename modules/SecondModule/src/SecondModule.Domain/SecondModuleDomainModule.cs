using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace SecondModule;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(SecondModuleDomainSharedModule)
)]
public class SecondModuleDomainModule : AbpModule
{

}
