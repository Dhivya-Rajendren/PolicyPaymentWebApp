using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using PolicyPaymentWebApp.Models;
using System.Collections;
using System.Collections.Generic;

namespace PolicyPaymentWebApp.Pages
{
    public class NewPolicyModel : PageModel
    {
        private readonly ILogger<NewPolicyModel> _logger;
        PolicyPaymentDbContext dbContext;
        public NewPolicyModel(ILogger<NewPolicyModel> logger,PolicyPaymentDbContext dbContext)
        {
            _logger = logger;
            this.dbContext = dbContext;
        
        }
        public void OnGet()
        {
          

        }
        [BindProperty]
        public Policy _Policy { get; set; }
      
        public void OnPost()
        {
          
    //        dbContext = new PolicyPaymentDbContext();
            dbContext.Policies.Add(_Policy);// In EF COre this add method is used for adding a new row , which will generate a insert query.
            dbContext.SaveChanges();// saving the changes permanently into the table.

                 
          
        }


        public void OnUpdate()
        {
          //  dbContext = new PolicyPaymentDbContext();

        }

        
    }
}
