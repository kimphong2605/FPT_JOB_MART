using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using FPT_JOB_MART.Models;

namespace FPT_JOB_MART.Models
{
    public class Profile
    {
        [Key]
        public int ID { get; set; }
        public string UserID { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Skill { get; set; }
        public string Education { get; set; }
        public string MyFile { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }

        [InverseProperty("ObjProfile")]
        public virtual ICollection<ProJob>? ProJobs { get; set; }

    }
}