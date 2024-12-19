using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace udc_dev_backend.Models
{
    public class SocialLinks
    {
        //FK
        [Key, ForeignKey("User")]
        public int UserId { get; set; }

        public User User { get; set; }

        [Url]
        public string Github { get; set; }
        [Url]
        public string Linkedin { get; set; }
        [Url]
        public string Web { get; set; }
    }
}
