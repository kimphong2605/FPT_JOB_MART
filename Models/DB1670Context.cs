using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FPT_JOB_MART.Models;

namespace FPT_JOB_MART.Models
{
    public class DB1670Context : IdentityDbContext
    {
        public DB1670Context(DbContextOptions<DB1670Context> options): base(options)
        {

        }

        public DbSet<Category> Categoríes { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Profile> Profile { get; set; } = default!;
        public DbSet<FPT_JOB_MART.Models.ProJob> ProJob { get; set; } = default!;
    }
}
