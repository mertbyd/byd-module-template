using Byd.ModuleTemplate.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Byd.ModuleTemplate.Permissions;

public class ModuleTemplatePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        // var myGroup = context.AddGroup(ModuleTemplatePermissions.GroupName, L("Permission:ModuleTemplate"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ModuleTemplateResource>(name);
    }
}
