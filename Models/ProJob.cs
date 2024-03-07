using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FPT_JOB_MART.Models
{
    public class ProJob
    {
        [Key]
        public int Id { get; set; }
        
        public DateTime RegDate { get; set; }
        
        public int ProfileId { get; set; }
        [ForeignKey("ProfileId")]
        public virtual Profile? ObjProfile { get; set; }

        public int JobId { get; set; }
        [ForeignKey("JobId")]
        public virtual Job? ObjJob { get; set; }
    }
}
