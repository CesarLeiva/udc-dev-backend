using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace udc_dev_backend.Models
{
    public class Experience
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("User"), Required]
        public int UserId { get; set; }
        public User User { get; set; }

        [Required(AllowEmptyStrings = false), MaxLength(100)]
        public string Title { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }

        [MaxLength(500)]
        public string Enterprise {  get; set; }
        public ICollection<ExperienceTechnology> ExperienceTechnologies { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

    }
}
