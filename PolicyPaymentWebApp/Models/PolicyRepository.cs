using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolicyPaymentWebApp.Models
{
    public class PolicyRepository : IPolicyRepository
    {
        List<Policy> policies = new List<Policy>()
        {
            new Policy(){PolicyNumber=789452,PolicyName="Abc Policy",Amount=7589,PolicyPeriod="Yearly",PolicyType="Health"},
            new Policy(){PolicyNumber=789453,PolicyName="Boss Policy",Amount=9500,PolicyPeriod="Yearly",PolicyType="Insurance"},
            new Policy(){PolicyNumber=789454,PolicyName="Vehicle Policy",Amount=17589,PolicyPeriod="Yearly",PolicyType="Car Insurance"},
            new Policy(){PolicyNumber=789455,PolicyName="Kotak Acc POlicy",Amount=5589,PolicyPeriod="Half-Yearly",PolicyType="Accident"}



        };
        public List<Policy> GetPolicies()
        {
            return policies;
        }

        public Policy GetPolicyByNumber(int policyNumber)
        {
            return policies.SingleOrDefault(p => p.PolicyNumber == policyNumber);
        }
    }
}
