namespace DI_RazorPages_Demo.Models
{
    public class DeptEmpCount
    {
        public string Department { get; set; }
        public int Count { get; set; }

        public List<Employee> Employees { get; set; }

        StringBuilder sb = new StringBuilder();
    }
}
