using Microsoft.EntityFrameworkCore;
using Sbidu.Models;

namespace Sbidu.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<AuctionProduct> AuctionProducts { get; set; }
        public DbSet<AuctionProductGallery> AuctionProductGalleries { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<HomePoster> HomePosters { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Setting> Settings { get; set; }

    }
}
