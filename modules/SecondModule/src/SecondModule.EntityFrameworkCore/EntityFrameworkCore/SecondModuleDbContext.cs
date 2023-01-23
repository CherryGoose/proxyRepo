using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace SecondModule.EntityFrameworkCore;

[ConnectionStringName(SecondModuleDbProperties.ConnectionStringName)]
public class SecondModuleDbContext : AbpDbContext<SecondModuleDbContext>, ISecondModuleDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */
    public DbSet<SecondNewModuleEntity> SecondNewModuleEntitys { get; set; }
    public SecondModuleDbContext(DbContextOptions<SecondModuleDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureSecondModule();
    }
}
