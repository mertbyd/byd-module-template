using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Byd.ModuleTemplate.EntityFrameworkCore;

[ConnectionStringName(ModuleTemplateDbProperties.ConnectionStringName)]
public interface IModuleTemplateDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
