using Microsoft.EntityFrameworkCore;
using Byd.CoreExtensions.EntityFrameworkCore;
using Byd.CoreExtensions.Extensions;
using Volo.Abp.Data;

namespace Byd.ModuleTemplate.EntityFrameworkCore;

[ConnectionStringName(ModuleTemplateDbProperties.ConnectionStringName)]
public class ModuleTemplateDbContext : BydDbContext<ModuleTemplateDbContext>, IModuleTemplateDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public ModuleTemplateDbContext(DbContextOptions<ModuleTemplateDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(typeof(ModuleTemplateDbContext).Assembly);

        builder.ConfigureModuleTemplate();

        builder.ApplySnakeCaseNaming();
    }
}
