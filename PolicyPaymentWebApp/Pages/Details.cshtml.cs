using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using PolicyPaymentWebApp.Models;

namespace PolicyPaymentWebApp.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly ILogger<PageModel> _logger;
        IPolicyRepository repo;
        public DetailsModel(ILogger<IndexModel> logger, IPolicyRepository repo)
        {
            _logger = logger;
            this.repo = repo;
        }
        public Policy Policy { get; set; }
        public void OnGet(int number)
        {
            ViewData["Title"] = "Policy Details";
            Policy = repo.GetPolicyByNumber(number);
            

        }
    }
}
