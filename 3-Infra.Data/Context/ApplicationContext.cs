using _1_Domain.Entities.Tables;
using _3_Infra.Data.EntityConfiguration;
using Microsoft.EntityFrameworkCore;

namespace _3_Infra.Data.Context
{
    public class ApplicationContext :DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        public DbSet<TableExample> TableExample { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TableExample_Config());
        }
    }
}
