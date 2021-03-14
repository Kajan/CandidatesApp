using System.Collections.Generic;
using CandidatesApp.DataAccess;
using CandidatesApp.Model;

namespace CandidatesApp.Service
{
    public class CandidateService : ICandidateService
    {
        private readonly ICandidateRepository _candidateRepository;
        private readonly ISearchCriteria _searchByJobTitle;

        public CandidateService(ISearchCriteria searchByJobTitle, ICandidateRepository candidateRepository)
        {
            _searchByJobTitle = searchByJobTitle;
            _candidateRepository = candidateRepository;
        }

        /// <inheritdoc/>
        public IEnumerable<Candidate> GetCandidatesForJobTitle(string jobTitle)
        {
            var allCandidates = _candidateRepository.GetAllCandidates();

            return _searchByJobTitle.Find(jobTitle, allCandidates);
        }
    }
}
