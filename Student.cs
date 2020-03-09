using System;

namespace StudentExercises
{
    public class Student
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string SlackHandle {get; set;}

        public int StudentCohort {get; set;}
        public string StudentExercises {get; set;}

        public Student(string firstName, string lastName, string slackHandle , int cohort)
        {
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slackHandle;
            StudentCohort = cohort;
        }
    }
}