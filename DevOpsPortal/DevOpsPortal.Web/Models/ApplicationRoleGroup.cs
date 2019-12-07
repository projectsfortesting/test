using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevOpsPortal.Data
{
    public class ApplicationRoleGroup
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public virtual string UserId { get; set; }
        public virtual string RoleId { get; set; }
        public virtual int GroupId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual ApplicationRole Role { get; set; }
        public virtual Group Group { get; set; }
    }
}