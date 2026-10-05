using Byd.AuthManagement;
using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace MyCompanyName.MyProjectName;

[DependsOn(
    typeof(MyProjectNameDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule),
    typeof(AuthManagementApplicationContractsModule)
    )]
public class MyProjectNameApplicationContractsModule : AbpModule
{

}
