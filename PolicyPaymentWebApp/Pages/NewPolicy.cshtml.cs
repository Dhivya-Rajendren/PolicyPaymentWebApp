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
        IPolicyRepository repo;
        public NewPolicyModel(ILogger<NewPolicyModel> logger, IPolicyRepository repo)
        {
            _logger = logger;
            this.repo = repo;
            Policies = repo.GetPolicies();
        }
        public void OnGet()
        {
            if (_Policy!=null)
            {
                Policies.Add(_Policy);
            }
          

        }
        public Policy _Policy { get; set; }
        public List<Policy> Policies { get; set; }
        public void OnPost(Policy policy)
        {
            _Policy = policy;
         Policies = repo.GetPolicies();
            Policies.Add(policy);
          
        
          
        }

        
    }
}
