using SecondModule.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace SecondModule;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(SecondModuleEntityFrameworkCoreTestModule)
    )]
public class SecondModuleDomainTestModule : AbpModule
{

}
