using System.ComponentModel.DataAnnotations;

namespace Web_Mvc_Curd.Models
{
    public class Employee
    {
        [Key]
        [System.ComponentModel.DisplayName("ID")]
        public int Emp_Id { get; set; }
        [Required]
        [MaxLength(200)]
        [System.ComponentModel.DisplayName("Name")]
        public string Emp_Name { get; set; }
        [Required]
        [System.ComponentModel.DisplayName("Age")]
        public int Emp_Age { get; set; }
        [Required]
        [System.ComponentModel.DisplayName("Gender")]
        public string Emp_Gender { get; set; }
        [Required]
        [System.ComponentModel.DisplayName("DOJ")]
        public DateTime DOJ { get; set; }
        [Required]
        [System.ComponentModel.DisplayName("Designation")]
        public string Designation { get; set; }
        
        [Required]
        public int Salary { get; set; }
        // Additional properties can be added as needed
    }
}
