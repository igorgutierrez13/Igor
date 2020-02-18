using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Igor.Models;

namespace Igor.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {


        }
        public DbSet<Igor.Models.HouseCamsModel> HouseCamsModel { get; set; }
        public DbSet<Igor.Models.ZipCoreViewModel> ZipCoreViewModel { get; set; }
    }
}
