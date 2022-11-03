using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ogarphia_crud.Models
{
    [Table( "Employee", Schema = "dbo")] 
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Employee ID")]
        public int EmployeeId { get; set; }

        [Required]
        [Display(Name = "Employee Name")]
        [Column(TypeName = "varchar(150)")]
        [MaxLength(150)]
        public string EmployeeName { get; set; }

        [Required]
        [Display(Name = "Employee Name")]
        [Column(TypeName = "varchar(10)")]
        [MaxLength(10)]
        public string EmployeeNumber { get; set; }

        [Required]
        [Display(Name = "Employee Birth Date")]
        [DataType(DataType.Date)]
        public DateOnly DOB { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Hiring Date")]
        public DateOnly HiringDate { get; set; }

        [Required]
        [Display(Name = "Gross Salary")]
        [Column(TypeName = "decimal(12,2)")]
        public decimal GrossSalary{ get; set; }

        [Required]
        [Display(Name = "Net Salary")]
        [Column(TypeName = "decimal(12,2)")]
        public decimal NetSalary { get; set; }

        [Required]
        [ForeignKey("DepartmentId")]
        [Display(Name = "Department")]
        public int DepartmentID { get; set; }

        [Display(Name = "Department")]
        [NotMapped]
        public string DepartmentName { get; set; }
        
        public virtual Department Department { get; set; }

    }
}
