using System.ComponentModel.DataAnnotations;
namespace HandsOnEFDBFirstCRUD.ViewModel
{
    public class EmployeeVM
    {
        [Key]
        public int EmpId { get; set; }

        public string EmpName { get; set; } 

        public string? Designation { get; set; }
        public string DeptName { get; set; }
    }
}
