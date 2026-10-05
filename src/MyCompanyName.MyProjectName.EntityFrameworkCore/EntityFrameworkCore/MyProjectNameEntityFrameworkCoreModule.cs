using Microsoft.Extensions.DependencyInjection;
using Byd.AuthManagement.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace MyCompanyName.MyProjectName.EntityFrameworkCore;

[DependsOn(
    typeof(MyProjectNameDomainModule),
    typeof(AbpEntityFrameworkCoreModule),
    typeof(AuthManagementEntityFrameworkCoreModule)
)]
public class MyProjectNameEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<MyProjectNameDbContext>(options => { options.AddDefaultRepositories(true); });
    }
}
