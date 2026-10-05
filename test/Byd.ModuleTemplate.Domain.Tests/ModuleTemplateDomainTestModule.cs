using Volo.Abp.Modularity;

namespace Byd.ModuleTemplate;

[DependsOn(
    typeof(ModuleTemplateDomainModule),
    typeof(ModuleTemplateTestBaseModule)
)]
public class ModuleTemplateDomainTestModule : AbpModule
{

}
