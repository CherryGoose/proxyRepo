using SecondModule.Localization;
using Volo.Abp.Application.Services;

namespace SecondModule;

public abstract class SecondModuleAppService : ApplicationService
{
    protected SecondModuleAppService()
    {
        LocalizationResource = typeof(SecondModuleResource);
        ObjectMapperContext = typeof(SecondModuleApplicationModule);
    }
}
