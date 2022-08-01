using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PolicyPaymentWebApp.Models;

namespace PolicyPaymentWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        IPolicyRepository repo ;
        PolicyPaymentDbContext dbContext;
        public IndexModel(ILogger<IndexModel> logger,PolicyPaymentDbContext dbContext)
        {
            _logger = logger;
            this.dbContext = dbContext;
        }
        public IEnumerable<Policy> Policies { get; set; }
        public void OnGet()
        {
            string pageTitle = "Policy Payment";
            ViewData["Title"] = pageTitle;
            ViewData["SubTitle"] = " Policy Details";
          

            Policies = dbContext.Policies.ToList();
         


        }

        
    }
}
