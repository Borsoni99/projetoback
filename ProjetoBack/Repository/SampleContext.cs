using Microsoft.EntityFrameworkCore;
using ProjetoBack.Model;
using ProjetoBack.Repository.Mapping;

namespace ProjetoBack.Repository
{
    public class SampleContext : DbContext
    {

        public SampleContext(DbContextOptions<SampleContext> options) : base(options) { } 

        public DbSet<Todo> todos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TodoMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
