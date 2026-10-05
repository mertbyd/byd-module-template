using Microsoft.EntityFrameworkCore;
using Byd.CoreExtensions.EntityFrameworkCore;

namespace MyCompanyName.MyProjectName.EntityFrameworkCore;

public class MyProjectNameDbContextFactory
    : CoreExtensionsDesignTimeDbContextFactory<MyProjectNameDbContext>
{
    protected override string ConnectionStringName => MyProjectNameDbProperties.ConnectionStringName;

    protected override MyProjectNameDbContext CreateInstance(
        DbContextOptions<MyProjectNameDbContext> options)
    {
        return new(options);
    }
}
