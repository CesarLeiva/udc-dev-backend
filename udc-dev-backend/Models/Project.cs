using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace udc_dev_backend.Models
{
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }

        [Required, MaxLength(100)]
        public string Title { get; set; }

        [Required ,MaxLength(1000)]
        public string Description { get; set; }
        public ICollection<ProjectTechnology> ProyectTechnologies { get; set; }

        //public string Status { get; set; }
    }
}
