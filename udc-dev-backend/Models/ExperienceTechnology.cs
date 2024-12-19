using System.ComponentModel.DataAnnotations.Schema;

namespace udc_dev_backend.Models
{
    public class ExperienceTechnology
    {
        [ForeignKey("Experience")]
        public int ExperienceId { get; set; }
        public Experience Experience { get; set; }

        [ForeignKey("Technology")]
        public int TechId { get; set; }
        public Technology Technology { get; set; }
    }
}
