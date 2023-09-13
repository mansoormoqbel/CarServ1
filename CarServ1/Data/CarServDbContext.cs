using CarServ1.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarServ1.Data
{
    public class CarServDbContext:IdentityDbContext
    {

        public CarServDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<SalesLeadEntity> SalesLead { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
    }
}
