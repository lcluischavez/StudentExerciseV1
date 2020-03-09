using System;

namespace StudentExercises
{
    public class Cohort
    {
        public string CohortName {get; set;}
        public string CohortStudent {get; set;}
        public string CohortInstructor {get; set;}

        public Cohort(string cohortName, string cohortInstructor)
        {
           CohortName = cohortName;
           CohortInstructor= cohortInstructor;
        }
    }
}