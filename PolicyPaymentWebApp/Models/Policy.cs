using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PolicyPaymentWebApp.Models
{
    public class Policy
    {
        public Policy()
        {

        }
        [Key]
        public int PolicyNumber { get; set; }
        [StringLength(50)]
        public string PolicyName { get; set; }

        public string PolicyType { get; set; }

        public int Amount { get; set; }
        public string PolicyPeriod { get; set; }
    }
}
