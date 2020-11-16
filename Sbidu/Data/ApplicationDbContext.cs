using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Sbidu.Models;

namespace Sbidu.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
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
        public DbSet<Faq> Faqs { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        public DbSet<UserAuctionProduct> UserAuctionProducts { get; set; }
    }
}
