using System;
using System.Collections.Generic;
// using System.Linq;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("");

            Student Lu = new Student("Luis", "Chavez", "lcluischavez", 37);
            Student Ty = new Student("Tyler", "Davis", "Tyler.Davis", 37);
            Student Ont = new Student("Onterio", "Wright", "OnterioW", 37);
            Student Phi = new Student("Philip","Martin", "PhilpMartin", 37);

            Exercise Heist = new Exercise("Heist", "C-Sharp");
            Exercise GotGamesOnYourPhone = new Exercise("Got Games?", "Python");
            Exercise GuessingGame = new Exercise("Guessing Game", "C-Sharp");
            Exercise EPLP = new Exercise("Heist", "React");

            Cohort c35 = new Cohort("Day Cohort 35","Mo");
            Cohort c37 = new Cohort("Day Cohort 37","Adam Schafer");
            Cohort c39 = new Cohort("Day Cohort 39","Steve Brownlee");

            Instructor adam = new Instructor("Adam","Schafer","adamsheaf","C-Sharp");
            Instructor steve = new Instructor("Steve","Brownlee","coach","Dad Jokes");
            Instructor mo = new Instructor("Mo","Silvera","Mo","Interpretive Dances");


            Console.WriteLine($"{c35.CohortName}'s instructor was {c35.CohortInstructor}");
            Console.WriteLine($"{c37.CohortName}'s instructor was {c37.CohortInstructor}");
            Console.WriteLine($"{c39.CohortName}'s instructor was {c39.CohortInstructor}");

            Console.WriteLine("------------");

            Console.WriteLine($"{adam.InstructorFirstName} {adam.InstructorLastName}'s slack handle is {adam.SlackHandle} and his specialty is {adam.InstructorSpecialty}!");
            Console.WriteLine($"{steve.InstructorFirstName} {steve.InstructorLastName}'s slack handle is {steve.SlackHandle} and his specialty is {steve.InstructorSpecialty}!");
            Console.WriteLine($"{mo.InstructorFirstName} {mo.InstructorLastName}'s slack handle is {mo.SlackHandle} and his specialty is {mo.InstructorSpecialty}!");

            Console.WriteLine("------------");

            Console.WriteLine($"The students name is {Lu.FirstName} {Lu.LastName}. They are in Cohort {Lu.StudentCohort}.");
            Console.WriteLine($"{Lu.FirstName} is working on {EPLP.ExerciseName} written in {EPLP.ExerciseLanguage}.");

            Console.WriteLine("------------");

            Console.WriteLine($"The students name is {Ty.FirstName} {Ty.LastName}. They are in Cohort {Ty.StudentCohort}.");
            Console.WriteLine($"{Ty.FirstName} is working on {GotGamesOnYourPhone.ExerciseName} written in {GotGamesOnYourPhone.ExerciseLanguage}.");

            Console.WriteLine("------------");


            Console.WriteLine($"The students name is {Ont.FirstName} {Ont.LastName}. They are in Cohort {Ont.StudentCohort}.");
            Console.WriteLine($"{Ont.FirstName} is working on {Heist.ExerciseName} written in {Heist.ExerciseLanguage}.");

        
        }
    }
}






// Student.Add(new Student)

            // var studentsOrderByLastName = students.OrderBy(studentsOrderByLastName =>
            // {
            //     return studentsOrderByLastName.LastName;
            // });

            // foreach (var student in studentsOrderByLastName) 
            // {
            //     Console.WriteLine($"student.FirstName");
            // }

            //var studentsWithNoExercises = students.Where(student =>
            //{
            //    var exercisesCount = student.Exercises.Count;
            //});
