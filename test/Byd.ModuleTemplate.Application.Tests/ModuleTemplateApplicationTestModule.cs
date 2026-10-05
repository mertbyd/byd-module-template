using Volo.Abp.Modularity;

namespace Byd.ModuleTemplate;

[DependsOn(
    typeof(ModuleTemplateApplicationModule),
    typeof(ModuleTemplateDomainTestModule)
    )]
public class ModuleTemplateApplicationTestModule : AbpModule
{

}
