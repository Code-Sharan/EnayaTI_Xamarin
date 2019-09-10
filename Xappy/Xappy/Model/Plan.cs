using System.Collections.Generic;

namespace Xappy.Model
{
    public class Plan
    {
        public string planId { get; set; }
        public string planName { get; set; }
        public string planStartDate { get; set; }
        public string planEndDate { get; set; }
        public string planDescription { get; set; }
        public string planVersion { get; set; }
        public string planStatus { get; set; }
        public List<FeatureList> featureList { get; set; }
        public string tcId { get; set; }
    }
}