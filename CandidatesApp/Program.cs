using System;
using System.Linq;
using CandidatesApp.DataAccess;
using CandidatesApp.Service;
using Microsoft.Extensions.DependencyInjection;

namespace CandidatesApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var collection = new ServiceCollection();
            collection.AddSingleton<ICandidateService, CandidateService>();
            collection.AddSingleton<ISearchCriteria, SearchJobTitleByExperience>();
            collection.AddSingleton<ICandidateRepository, CandidateRepository>();

            IServiceProvider serviceProvider = collection.BuildServiceProvider();
            var candidateService = serviceProvider.GetService<ICandidateService>();

            Console.Write("Please enter the Job Title:");
            var interestedJobTitle = Console.ReadLine();

            var interestedJobTitleCandidates = candidateService.GetCandidatesForJobTitle(interestedJobTitle);

            if(interestedJobTitleCandidates.Any())
            {
                foreach (var candidate in interestedJobTitleCandidates)
                {
                    Console.WriteLine($"Name: {candidate.Name} \t Email: {candidate.Email} \t  Phone: {candidate.Phone}");
                }
            }
            else
            {
                Console.WriteLine($"No results found for Job Title:  {interestedJobTitle}");
            }

            Console.ReadKey();

            if (serviceProvider is IDisposable)
            {
                ((IDisposable)serviceProvider).Dispose();
            }
        }
    }
}
