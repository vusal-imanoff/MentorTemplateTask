using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MentorTemplate.Models
{
    public class Features
    {
        public int Id { get; set; }
        public string Feature { get; set; }
        public List<JoinPricingFeatures> JoinPricingFeatures { get; set; }
    }
}
