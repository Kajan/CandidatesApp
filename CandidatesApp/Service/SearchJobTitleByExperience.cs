using System.Collections.Generic;
using System.Linq;
using CandidatesApp.Extentions;
using CandidatesApp.Model;

namespace CandidatesApp.Service
{
    public class SearchJobTitleByExperience : ISearchCriteria
    {
        public IEnumerable<Candidate> Find(string jobTitle, IEnumerable<Candidate> candidates)
        {
            return candidates.Where(c => c.WorkHistory.SearchExperienceInJob(jobTitle));
        }
    }
}
