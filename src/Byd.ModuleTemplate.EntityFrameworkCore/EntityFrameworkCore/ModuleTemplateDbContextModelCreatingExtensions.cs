using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Byd.ModuleTemplate.EntityFrameworkCore;

public static class ModuleTemplateDbContextModelCreatingExtensions
{
    public static void ConfigureModuleTemplate(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
