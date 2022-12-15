using SecondModule.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace SecondModule.Permissions;

public class SecondModulePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(SecondModulePermissions.GroupName, L("Permission:SecondModule"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<SecondModuleResource>(name);
    }
}
