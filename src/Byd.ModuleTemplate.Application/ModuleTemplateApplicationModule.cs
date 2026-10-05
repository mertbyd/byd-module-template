using Microsoft.Extensions.DependencyInjection;
using Byd.LogManagement;
using Volo.Abp.Mapperly;
using Volo.Abp.Modularity;
using Volo.Abp.Application;

namespace Byd.ModuleTemplate;

// Auth'un Application katmani token sunucusunu tasidigi icin yerine log'un Application katmani baglanir.
[DependsOn(
    typeof(ModuleTemplateDomainModule),
    typeof(ModuleTemplateApplicationContractsModule),
    typeof(AbpDddApplicationModule),
    typeof(AbpMapperlyModule),
    typeof(LogManagementApplicationModule)
    )]
public class ModuleTemplateApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddMapperlyObjectMapper<ModuleTemplateApplicationModule>();
    }
}
