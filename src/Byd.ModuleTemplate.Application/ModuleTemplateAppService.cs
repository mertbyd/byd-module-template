using Byd.ModuleTemplate.Localization;
using Volo.Abp.Application.Services;

namespace Byd.ModuleTemplate;

public abstract class ModuleTemplateAppService : ApplicationService
{
    protected ModuleTemplateAppService()
    {
        LocalizationResource = typeof(ModuleTemplateResource);
        ObjectMapperContext = typeof(ModuleTemplateApplicationModule);
    }
}
