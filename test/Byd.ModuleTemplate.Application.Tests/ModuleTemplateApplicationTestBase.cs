using Volo.Abp.Modularity;

namespace Byd.ModuleTemplate;

/* Inherit from this class for your application layer tests.
 * See SampleAppService_Tests for example.
 */
public abstract class ModuleTemplateApplicationTestBase<TStartupModule> : ModuleTemplateTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
