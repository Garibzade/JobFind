using JobFind.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JobFind.DAL
{
    public class JobFindContext : IdentityDbContext
    {
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Job>Jobs { get; set; }
        public DbSet<Category>Categories { get; set; }

        public JobFindContext(DbContextOptions options) : base(options)
        {

        }
    }
}
