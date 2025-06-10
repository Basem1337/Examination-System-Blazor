using ExaminationSystem.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ExaminationSystem.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ApplicationUser>()
                .HasOne(u => u.StudentProfile)
                .WithOne(s => s.ApplicationUser)
                .HasForeignKey<Student>(s => s.ApplicationUserId);

            modelBuilder.Entity<ApplicationUser>()
                .HasOne(u => u.InstructorProfile)
                .WithOne(i => i.ApplicationUser)
                .HasForeignKey<Instructor>(i => i.ApplicationUserId);

            modelBuilder.Entity<StdCrs>()
                .HasKey(sc => new { sc.StudentId, sc.CourseId });

            modelBuilder.Entity<StdCrs>()
                .HasOne(sc => sc.Student)
                .WithMany(s => s.StudentCourses)
                .HasForeignKey(sc => sc.StudentId);

            modelBuilder.Entity<StdCrs>()
                .HasOne(sc => sc.Course)
                .WithMany(c => c.StudentCourses)
                .HasForeignKey(sc => sc.CourseId);

            //modelBuilder.Entity<Course>()
            //    .HasOne(c => c.Exam)
            //    .WithOne(e => e.Course)
            //    .HasForeignKey<Exam>(c => c.CourseId);

            modelBuilder.Entity<Exam>()
                .HasOne(e => e.Course)
                .WithOne(c => c.Exam)
                .HasForeignKey<Exam>(e => e.CourseId);


            var instructorUserId = "Inst-01";
            var instructorRoleId = "InstructorRole-01";
            var studentRoleId = "StudentRole-01";
            var instructor = new ApplicationUser
            {
                Id = instructorUserId,
                UserName = "basem.m1337@gmail.com",
                NormalizedUserName = "BASEM.M1337@GMAIL.COM",
                Email = "basem.m1337@gmail.com",
                NormalizedEmail = "BASEM.M1337@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null!, "Inst@0123"),
                SecurityStamp = Guid.NewGuid().ToString()
            };

            modelBuilder.Entity<ApplicationUser>().HasData(instructor);

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
            {
                Id = instructorRoleId,
                Name = "Instructor",
                NormalizedName = "INSTRUCTOR"
            },
                new IdentityRole
            {
                Id = studentRoleId,
                Name = "Student",
                NormalizedName = "STUDENT"
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                UserId = instructorUserId,
                RoleId = instructorRoleId
            });

            var instructorProfile = new Instructor
            {
                Id = new Guid("11111111-1111-1111-1111-111111111111"),
                Name = "Basem Mohamed",
                Phone = "01016297668",
                Salary = 5000,
                ApplicationUserId = instructorUserId
            };

            modelBuilder.Entity<Instructor>().HasData(instructorProfile);

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StdCrs> StudentCourses { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
    }
}
