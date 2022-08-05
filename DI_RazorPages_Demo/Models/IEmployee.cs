namespace DI_RazorPages_Demo.Models
{
    public interface IEmployee
    {
        List<Employee> GetEmployees();
        List<DeptEmpCount> GetDeptEmpCount();
    }
}
