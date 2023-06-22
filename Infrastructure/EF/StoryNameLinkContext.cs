using Domain.Entities.ModelEF;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Infrastructure.EF
{
    public class StoryNameLinkContext : DbContext
    {
        /// <summary>
        /// Stories
        /// </summary>
        public DbSet<Story> Stories { get; set; }
        public StoryNameLinkContext(DbContextOptions<StoryNameLinkContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Test story            
            string testStory = @"Once upon a time, in a magical land called Blazoria, there was a young girl named
Clara:
She lived in a cozy cottage deep within the enchanted forest.
Clara:
had a pet dragon named
Sparky:
who could breathe fire and fly through the sky.
One sunny morning,
Clara:
decided to go on an adventure with
Sparky:
They set out to explore the vast and mysterious forest, filled with talking animals and hidden treasures. As they journeyed deeper into the woods,
Clara:
encountered a mischievous elf named
Oliver:
Oliver:
was known for his pranks and riddles. He loved to play tricks on unsuspecting travelers. 
";
            #endregion Test story

            modelBuilder.Entity<Story>().HasData(
                new Story { Id = 1, Text = testStory });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
        }
    }
}