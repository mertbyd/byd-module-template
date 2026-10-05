using Byd.ModuleTemplate.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Byd.ModuleTemplate;

public abstract class ModuleTemplateController : AbpControllerBase
{
    protected ModuleTemplateController()
    {
        LocalizationResource = typeof(ModuleTemplateResource);
    }
}
