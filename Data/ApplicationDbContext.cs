using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using WatchVideo.Models;

namespace WatchVideo.Data
{
    public class ApplicationDbContext : IdentityDbContext/*<ApplicationUser>*/
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

            //public DbSet<ApplicationUser> ApplicationUser { get; set; }
            public DbSet<Video> Videos { get; set; }
        
    }
}
