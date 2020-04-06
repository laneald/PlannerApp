
using Microsoft.EntityFrameworkCore;
using Planner_App.Models;

namespace Planner_App.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        public DbSet<User> Users { get; set; }
        public DbSet<Personal> Messages { get; set; }
        public DbSet<Specialization> Specialization { get; set; }
        public DbSet<Task> Task { get; set; }
    }
}