using System;
using System.Collections.Generic;
using System.Linq;
using CandidatesApp.DataAccess;
using CandidatesApp.Model;
using CandidatesApp.Service;
using Moq;
using Xunit;

namespace CandidatesTest.ServiceTests
{
    public class CandidateServiceTests
    {
        public CandidateServiceTests()
        {
            this.CandidateService = new CandidateService(this.MockSearchCriteria.Object, this.MockCandidateRepository.Object);
        }

        private Mock<ISearchCriteria> MockSearchCriteria { get; }

        private Mock<ICandidateRepository> MockCandidateRepository { get; }

        private CandidateService CandidateService { get; }

        /// <summary>
        /// A test for <see cref="CandidateService"/>
        /// </summary>
        [Fact]
        public void GetCandidatesByJobTitle()
        {
            var jobTitle = "Software Engineer";

            var candidates = new List<Candidate>
            {
                new Candidate
                {
                    Name = "Employee1",
                    Email = "test1@test.com",
                    Phone = "1234456",
                    WorkHistory = new List<Work>
                    {
                        new Work
                        {
                            JobTitle ="Software Engineer",
                            StartDate = new DateTime(2011, 11, 02),
                            EndDate = new DateTime(2017, 11, 02)
                        }

                    }
                },
                new Candidate
                {
                    Name = "Employee2",
                    Email = "test2@test.com",
                    Phone = "2224456",
                    WorkHistory = new List<Work>
                    {
                        new Work
                        {
                            JobTitle ="Software Engineer",
                            StartDate = new DateTime(2011, 11, 02),
                            EndDate = null
                        }

                    }
                }
            };

            this.MockCandidateRepository.SetupGet(c => c.GetAllCandidates()).Returns(candidates);

            var result = this.CandidateService.GetCandidatesForJobTitle(jobTitle);
            Assert.Equal(2, result.Count());
        }
    }
}
