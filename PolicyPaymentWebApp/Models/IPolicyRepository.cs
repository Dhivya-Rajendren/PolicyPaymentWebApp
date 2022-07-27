using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolicyPaymentWebApp.Models
{
 public   interface IPolicyRepository
    {

        List<Policy> GetPolicies();
        Policy GetPolicyByNumber(int policyNumber);
    }
}
