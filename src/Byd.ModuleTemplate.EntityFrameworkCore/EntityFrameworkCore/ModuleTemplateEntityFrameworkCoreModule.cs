using Microsoft.Extensions.DependencyInjection;
using Byd.AuthManagement.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Byd.ModuleTemplate.EntityFrameworkCore;

[DependsOn(
    typeof(ModuleTemplateDomainModule),
    typeof(AbpEntityFrameworkCoreModule),
    typeof(AuthManagementEntityFrameworkCoreModule)
)]
public class ModuleTemplateEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<ModuleTemplateDbContext>(options => { options.AddDefaultRepositories(true); });
    }
}
