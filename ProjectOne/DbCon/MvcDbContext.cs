using Microsoft.EntityFrameworkCore;
using ProjectOne.Models;

namespace ProjectOne.DbCon
{
    public class MvcDbContext:DbContext
    {
        public MvcDbContext(DbContextOptions<MvcDbContext> options) : base(options) { }

        public DbSet<Exam> Exams { get; set; }
        public DbSet<Question> Question { get; set; }
    }
}
