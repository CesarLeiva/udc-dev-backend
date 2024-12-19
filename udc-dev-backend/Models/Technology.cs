using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace udc_dev_backend.Models
{
    public class Technology
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public ICollection<UserTechnology> UserTechnologies { get; set; }
        public ICollection<ProjectTechnology> ProjectTechnologies { get; set; }
        public ICollection<ExperienceTechnology> ExperienceTechnologies { get; set; }
    }
}
