using System.ComponentModel.DataAnnotations.Schema;

namespace udc_dev_backend.Models
{
    public class UserTechnology
    {
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }

        [ForeignKey("Technology")]
        public int TechId { get; set; }
        public Technology Technology { get; set; }
    }
}
