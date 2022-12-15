using Volo.Abp.Reflection;

namespace SecondModule.Permissions;

public class SecondModulePermissions
{
    public const string GroupName = "SecondModule";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(SecondModulePermissions));
    }
}
