using Microsoft.EntityFrameworkCore;
using StudentsMangementSystem.Models;

namespace StudentsMangementSystem.Context
{
    public class ApplicationDbContext : DbContext
    {
        //constractor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }
        public DbSet<Student> Students { get; set; }
    }
}
