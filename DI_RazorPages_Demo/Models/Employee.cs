namespace DI_RazorPages_Demo.Models
{
    public class Employee:IEmployee
    {

        static private List<Employee> employees = new List<Employee>();
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long Mobile { get; set; }
        public string Email { get; set; }

        public List<Employee> GetEmployees()
        {
            employees.Add(new Employee() { EmployeeId = 1, FirstName = "Dhivya", LastName = "Rajendren", Mobile = 9976408018, Email = "dhivya@cloudKampus.com" });

            employees.Add(new Employee() { EmployeeId = 2, FirstName = "Sam", LastName = "Ashwin", Mobile = 7082583383, Email = "sam@cloudKampus.com" });

            return employees;

        }
    }
}
