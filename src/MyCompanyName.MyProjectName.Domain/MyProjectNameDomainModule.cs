using Byd.AuthManagement;
using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace MyCompanyName.MyProjectName;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(MyProjectNameDomainSharedModule),
    typeof(AuthManagementDomainModule)
)]
public class MyProjectNameDomainModule : AbpModule
{

}
