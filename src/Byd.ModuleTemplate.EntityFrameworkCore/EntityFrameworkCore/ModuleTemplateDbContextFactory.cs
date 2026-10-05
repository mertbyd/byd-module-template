using Microsoft.EntityFrameworkCore;
using Byd.CoreExtensions.EntityFrameworkCore;

namespace Byd.ModuleTemplate.EntityFrameworkCore;

public class ModuleTemplateDbContextFactory
    : CoreExtensionsDesignTimeDbContextFactory<ModuleTemplateDbContext>
{
    protected override string ConnectionStringName => ModuleTemplateDbProperties.ConnectionStringName;

    protected override ModuleTemplateDbContext CreateInstance(
        DbContextOptions<ModuleTemplateDbContext> options)
    {
        return new(options);
    }
}
