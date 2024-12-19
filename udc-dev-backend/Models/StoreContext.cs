using Microsoft.EntityFrameworkCore;

namespace udc_dev_backend.Models
{
    public class StoreContext : DbContext //EntityFramework
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options) { }

        //Models ->
        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Technology> Technologies { get; set; }
        public DbSet<SocialLinks> SocialLinks { get; set; }



        //m * m relations tables ->
        public DbSet<UserTechnology> UserTecnologies { get; set; }
        public DbSet<ExperienceTechnology> ExperienceTecnologies { get; set; }
        public DbSet<ProjectTechnology> ProjectTecnologies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Technology>()//Define que el nombre en las tecnologías sea único
                .HasIndex(t => t.Name).IsUnique();

            modelBuilder.Entity<Project>()//Define la relación de 1 * m entre usuario y proyecto
                .HasOne(p => p.User)
                .WithMany(u => u.Projects)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Experience>()//Define la relación de 1 * m entre usuario y Experiencia
            .HasOne(e => e.User)
            .WithMany(u => u.Experiences)
            .HasForeignKey(e => e.UserId)
            .OnDelete(DeleteBehavior.Cascade);


            //Se definen las relaciones de muchos a muchos con las tablas intermedias para tecnologías

            modelBuilder.Entity<UserTechnology>()
                .HasKey(ut => new { ut.UserId, ut.TechId });

            modelBuilder.Entity<ProjectTechnology>()
                .HasKey(pt => new { pt.ProjectId, pt.TechId });

            modelBuilder.Entity<ExperienceTechnology>()
                .HasKey(et => new { et.ExperienceId, et.TechId });
        }

    }
}
/*
 public class ApplicationDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Technology> Technologies { get; set; }
    public DbSet<UserTechnology> UserTechnologies { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configuración de la relación muchos a muchos
        modelBuilder.Entity<UserTechnology>()
            .HasOne(ut => ut.User)
            .WithMany(u => u.UserTechnologies)
            .HasForeignKey(ut => ut.UserId);

        modelBuilder.Entity<UserTechnology>()
            .HasOne(ut => ut.Technology)
            .WithMany(t => t.UserTechnologies)
            .HasForeignKey(ut => ut.TechnologyId);
    }
}
 */