using System.Collections.Generic;
using CandidatesApp.Model;

namespace CandidatesApp.Service
{
    public interface ISearchCriteria
    {
        IEnumerable<Candidate> Find(string jobTitle, IEnumerable<Candidate> candidates);
    }
}
