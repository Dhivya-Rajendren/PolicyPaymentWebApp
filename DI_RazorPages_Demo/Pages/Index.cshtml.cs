using DI_RazorPages_Demo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DI_RazorPages_Demo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IConfiguration configuration;
        private readonly IEmployee employee;

        //constructor Injection
        public IndexModel(IConfiguration configuration,IEmployee employee)// Index model is controlling the object creation .//Inversion of Control -IoC
        {
            this.configuration = configuration;
            this.employee = employee;
        }

        public List<Employee> Employees { get; set; }

        public void OnGet()
        {
            configuration.GetConnectionString("");
            //   IEmployee employee = new Employee();// No direct dependency// Employee class controls the object creation 
            if (configuration.GetValue<bool>("Features:HomePage:EnableMessage"))
            {
                ViewData["Message"] = configuration.GetValue<string>("Features:HomePage:PageTitle");
            }

           Employees= employee.GetEmployees();
        }
    }
}