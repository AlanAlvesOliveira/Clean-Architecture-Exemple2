using _1_Domain.Entities.Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _3_Infra.Data.EntityConfiguration
{
    public class TableExample_Config : IEntityTypeConfiguration<TableExample>
    {
        public void Configure(EntityTypeBuilder<TableExample> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
