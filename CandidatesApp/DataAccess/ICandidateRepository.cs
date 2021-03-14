using System.Collections.Generic;
using CandidatesApp.Model;

namespace CandidatesApp.DataAccess
{
    public interface ICandidateRepository
    {
        /// <summary>
        /// Gets the list of candidates.
        /// </summary>
        /// <returns>The list of candidates</returns>
        IEnumerable<Candidate> GetAllCandidates();
    }
}
