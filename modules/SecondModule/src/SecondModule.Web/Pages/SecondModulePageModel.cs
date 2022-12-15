using SecondModule.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace SecondModule.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class SecondModulePageModel : AbpPageModel
{
    protected SecondModulePageModel()
    {
        LocalizationResourceType = typeof(SecondModuleResource);
        ObjectMapperContext = typeof(SecondModuleWebModule);
    }
}
