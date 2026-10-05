using Microsoft.EntityFrameworkCore;
using Byd.CoreExtensions.EntityFrameworkCore;
using Byd.CoreExtensions.Extensions;
using Volo.Abp.Data;

namespace MyCompanyName.MyProjectName.EntityFrameworkCore;

[ConnectionStringName(MyProjectNameDbProperties.ConnectionStringName)]
public class MyProjectNameDbContext : BydDbContext<MyProjectNameDbContext>, IMyProjectNameDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public MyProjectNameDbContext(DbContextOptions<MyProjectNameDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(typeof(MyProjectNameDbContext).Assembly);

        builder.ConfigureMyProjectName();

        builder.ApplySnakeCaseNaming();
    }
}
