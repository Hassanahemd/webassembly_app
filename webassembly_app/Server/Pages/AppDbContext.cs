
using Microsoft.EntityFrameworkCore;
using webassembly_app.Shared;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Student> Students { get; set; }
    public DbSet<Course> Courses { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure your model relationships, constraints, etc. here if needed.
        // For example, if you want a relationship between Student and Course:
        modelBuilder.Entity<Student>()
            .HasOne(s => s.Course)
            .WithMany(c => c.Students)
            .HasForeignKey(s => s.CourseId);

        // Add other configurations as needed...

        base.OnModelCreating(modelBuilder);
    }
}
