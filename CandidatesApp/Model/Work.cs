using System;
using Newtonsoft.Json;

namespace CandidatesApp.Model
{
    public class Work
    {
        public string JobTitle { get; set; }
        public string Company { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        [JsonIgnore]
        public DateTime EmpEndDate
        {
            get { return EndDate.HasValue ? EndDate.Value : DateTime.Now; }
        }
    }
}
