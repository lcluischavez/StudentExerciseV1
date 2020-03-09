using System;

namespace StudentExercises
{
    public class Instructor
    {
        public string InstructorFirstName {get; set;}
        public string InstructorLastName {get; set;}
        public string SlackHandle {get; set;}

        public int InstructorCohort {get; set;}
        public string InstructorSpecialty {get; set;}

        public Instructor(string instructorFirstName, string instructorLastName, string slackHandle, string instructorSpecialty)
        {
           InstructorFirstName = instructorFirstName;
           InstructorLastName = instructorLastName;
           SlackHandle = slackHandle;
           InstructorSpecialty = instructorSpecialty;
        }

        // public void Service(bool addCleaningService)
        // {
        //     NeedsMaintenance = false;
        //     if (addCleaningService)
        //     {
        //         IsClean = true;
        //     }
        // }
    }
}