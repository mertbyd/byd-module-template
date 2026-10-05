using Byd.AuthManagement;
using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Byd.ModuleTemplate;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(ModuleTemplateDomainSharedModule),
    typeof(AuthManagementDomainModule)
)]
public class ModuleTemplateDomainModule : AbpModule
{

}
