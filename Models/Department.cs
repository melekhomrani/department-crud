using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ogarphia_crud.Models
{
    [Table("department", Schema = "dbo")]
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Department ID")]
        public int DepartmentId { get; set; }
        [Required]
        [Display(Name = "Department Name")]
        [Column(TypeName = "varchar(50)")]
        public string DepartmentName { get; set; }
        [Column(TypeName = "varchar(10)")]
        [Display(Name = "Department Abrreviation")]
        public string DepartmentAbbr { get; set; }

    }
}