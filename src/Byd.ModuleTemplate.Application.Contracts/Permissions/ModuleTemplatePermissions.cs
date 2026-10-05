using Volo.Abp.Reflection;

namespace Byd.ModuleTemplate.Permissions;

public class ModuleTemplatePermissions
{
    // public const string GroupName = "ModuleTemplate";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(ModuleTemplatePermissions));
    }
}
