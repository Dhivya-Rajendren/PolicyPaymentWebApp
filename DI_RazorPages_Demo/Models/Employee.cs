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

        public string Department { get; set; }

        public List<DeptEmpCount> GetDeptEmpCount()
        {
           return employees.GroupBy(t=>t.Department).Select(r=>new DeptEmpCount() { Department=r.Key,Count=r.Count()}).ToList();    
        }

        public List<Employee> GetEmployees()
        {
            employees.Add(new Employee() { EmployeeId = 1, FirstName = "Dhivya", LastName = "Rajendren", Mobile = 9976408018, Email = "dhivya@cloudKampus.com",Department="Training" });

            employees.Add(new Employee() { EmployeeId = 2, FirstName = "Sam", LastName = "Ashwin", Mobile = 7082583383, Email = "sam@cloudKampus.com" ,Department="IT Ops"});

            employees.Add(new Employee() { EmployeeId = 3, FirstName = "Aabha", LastName = "Kumar", Mobile = 9976708018, Email = "Aabha@cloudKampus.com", Department = "Training" });

            employees.Add(new Employee() { EmployeeId = 4, FirstName = "Sherin", LastName = "George", Mobile = 8082583383, Email = "sherin@cloudKampus.com", Department = "Sales" });

            return employees;

        }
    }
}
