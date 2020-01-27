using Microsoft.EntityFrameworkCore;
using Assignment2.Models;

namespace Assignment2.Data
{
    public class ClubContext : DbContext
    {
        public ClubContext (DbContextOptions<ClubContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Client> Client { get; set; }

    }
}