using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace SecondModule;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class SecondModuleInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<SecondModuleInstallerModule>();
        });
    }
}
