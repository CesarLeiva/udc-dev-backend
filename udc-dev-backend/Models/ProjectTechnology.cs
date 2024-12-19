using System.ComponentModel.DataAnnotations.Schema;

namespace udc_dev_backend.Models
{
    public class ProjectTechnology
    {
        [ForeignKey("Project")]
        public int ProjectId { get; set; }
        public Project Project { get; set; }

        [ForeignKey("Technology")]
        public int TechId { get; set; }
        public Technology Technology { get; set; }
    }
}
