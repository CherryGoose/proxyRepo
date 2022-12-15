using Volo.Abp.Modularity;

namespace SecondModule;

[DependsOn(
    typeof(SecondModuleApplicationModule),
    typeof(SecondModuleDomainTestModule)
    )]
public class SecondModuleApplicationTestModule : AbpModule
{

}
