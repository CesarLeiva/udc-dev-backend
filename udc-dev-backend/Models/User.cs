using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace udc_dev_backend.Models
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false), MaxLength(50)]
        public string Name { get; set; }

        [Required, EmailAddress, MaxLength (100)]
        public string Email {  get; set; }

        public UserRole Role {  get; set; }

        [MaxLength(500)]
        public string Title {  get; set; }

        [MaxLength(2000)]
        public string Description { get; set; }

        public bool Verified { get; set; } = false;

        public DateTime CreatedAt { get; set; }
        public ICollection<Experience> Experiences { get; set; }
        public ICollection<Project> Projects { get; set; }
        public ICollection<UserTechnology> UserTechnologies { get; set; }
    }
}

public enum UserRole
{
    Estudiante,
    Profesor,
    Egresado,
    Externo,
    Admin
}