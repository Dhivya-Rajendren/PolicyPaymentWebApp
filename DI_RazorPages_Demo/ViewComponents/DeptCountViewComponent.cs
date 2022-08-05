using DI_RazorPages_Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace DI_RazorPages_Demo.ViewComponents
{
    public class DeptCountViewComponent:ViewComponent
    {
        private readonly IEmployee employee;

        public DeptCountViewComponent(IEmployee employee)
        {
            this.employee = employee;
        }
        public IViewComponentResult Invoke()
        {

            return View(employee.GetDeptEmpCount());
        }
    }
}
