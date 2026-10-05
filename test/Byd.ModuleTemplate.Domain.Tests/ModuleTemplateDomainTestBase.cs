using Volo.Abp.Modularity;

namespace Byd.ModuleTemplate;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class ModuleTemplateDomainTestBase<TStartupModule> : ModuleTemplateTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
