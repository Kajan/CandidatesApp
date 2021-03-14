using System.Collections.Generic;

namespace CandidatesApp.Model
{
    public class Candidate 
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
        public List<Work> WorkHistory { get; set; }
    }
}
