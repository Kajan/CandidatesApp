using System.Collections.Generic;
using CandidatesApp.Model;

namespace CandidatesApp.Service
{
    public interface ICandidateService
    {
        ///// <summary>
        ///// Gets the list of candidates.
        ///// </summary>
        ///// <returns>The list of candidates</returns>
        //IEnumerable<Candidate> GetAllCandidates();

        /// <summary>
        /// Gets the list of candidates for a give job title.
        /// </summary>
        /// <param name="jobTitle"></param>
        /// <returns>The list of candidates.</returns>
        IEnumerable<Candidate> GetCandidatesForJobTitle(string jobTitle);
    }
}
