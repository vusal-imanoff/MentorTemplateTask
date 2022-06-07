using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MentorTemplate.Models
{
    public class JoinPricingFeatures
    {
        public int Id { get; set; }
        public int PricingsId { get; set; }
        public Pricings Pricings { get; set; }
        public int FeaturesId { get; set; }
        public Features Features { get; set; }

    }
}
