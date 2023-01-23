using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace SecondModule.EntityFrameworkCore;

[ConnectionStringName(SecondModuleDbProperties.ConnectionStringName)]
public interface ISecondModuleDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
    DbSet<SecondNewModuleEntity> SecondNewModuleEntitys { get; set; }

}
