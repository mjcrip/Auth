using AdPoc.Core;
using AdPoc.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace AdPoc.Infra
{
    public class AdPocContext : BaseContext
    {
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Context> Contexts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("ActiveDirectory");
            base.OnModelCreating(modelBuilder);
        }
    }
}