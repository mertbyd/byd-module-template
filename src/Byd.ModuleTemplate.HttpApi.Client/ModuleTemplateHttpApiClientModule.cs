using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Byd.ModuleTemplate;

[DependsOn(
    typeof(ModuleTemplateApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class ModuleTemplateHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(ModuleTemplateApplicationContractsModule).Assembly,
            ModuleTemplateRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<ModuleTemplateHttpApiClientModule>();
        });

    }
}
