using Byd.AuthManagement;
using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Byd.ModuleTemplate;

[DependsOn(
    typeof(ModuleTemplateDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule),
    typeof(AuthManagementApplicationContractsModule)
    )]
public class ModuleTemplateApplicationContractsModule : AbpModule
{

}
