using System;
using Microsoft.EntityFrameworkCore;

namespace Guitar_LMS.Models {
    public class AppDbContext : DbContext {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {
        }

        public DbSet<TodoListItem> TodoListItems { get; set; }
        public DbSet<GuitarPracticeCard> GuitarPracticeCards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<GuitarPracticeCard>()
                .HasMany(c => c.TodoList)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
