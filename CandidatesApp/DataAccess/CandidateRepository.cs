using System.Collections.Generic;
using System.IO;
using CandidatesApp.Model;
using Newtonsoft.Json;

namespace CandidatesApp.DataAccess
{
    public class CandidateRepository : ICandidateRepository
    {
        /// <inheritdoc/>
        public IEnumerable<Candidate> GetAllCandidates()
        {
            var filePath = @"Data/candidates.json";
            using (var streamReader = new StreamReader(filePath))
            {
                var candidatesJSON = streamReader.ReadToEnd();
                return JsonConvert.DeserializeObject<List<Candidate>>(candidatesJSON);
            }
        }
    }
}
