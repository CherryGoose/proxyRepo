using SecondModule.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace SecondModule;

public abstract class SecondModuleController : AbpControllerBase
{
    protected SecondModuleController()
    {
        LocalizationResource = typeof(SecondModuleResource);
    }
}
