using System;
using System.Collections.Generic;
using System.Text;
using CandidatesApp.Model;
using System.Linq;

namespace CandidatesApp.Extentions
{
    public static class WorkHistoryExtentions
    {
        public static bool SearchExperienceInJob(this IList<Work> works, string searchText)
        {
            var daysDiff = DateTime.Now.Subtract(DateTime.Now.AddYears(-5)).TotalDays;

            return  (from work in works 
                     where work.JobTitle.ToLower().Trim() == searchText.ToLower().Trim()
                     group work by work.JobTitle into experience 
                     select new 
                     { 
                         ExpDays = experience.Sum(workDay => workDay.EmpEndDate.Subtract(workDay.StartDate).Days)
                     }).Any(z => z.ExpDays > daysDiff);

        }
    }
}
