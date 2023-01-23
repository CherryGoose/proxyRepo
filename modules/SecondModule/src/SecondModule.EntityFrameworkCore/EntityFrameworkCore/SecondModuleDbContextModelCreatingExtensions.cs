using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace SecondModule.EntityFrameworkCore;

public static class SecondModuleDbContextModelCreatingExtensions
{
    public static void ConfigureSecondModule(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

        builder.Entity<SecondNewModuleEntity>(b =>
        {
            b.ToTable("SecondNewModuleEntitys");
            b.ConfigureByConvention();
        });
        /* Configure all entities here. Example:

        builder.Entity<Question>(b =>
        {
            //Configure table & schema name
            b.ToTable(SecondModuleDbProperties.DbTablePrefix + "Questions", SecondModuleDbProperties.DbSchema);

            b.ConfigureByConvention();

            //Properties
            b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);

            //Relations
            b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

            //Indexes
            b.HasIndex(q => q.CreationTime);
        });
        */
    }
}
