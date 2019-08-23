using System;
using System.Collections.Generic;
using System.Linq;

namespace DevQuestions
{
    internal class Program
    {
        private static void Main(string[] args)
        {
 
            #region Question 1 - what's missing
            //
            //
            //
            #endregion

            #region Question 2 - what is your preference?

            // Give your answer in Q3

            //Example A 
            ObjectA objectA = new ObjectA();
            ObjectB objectB = new ObjectB();
            objectA.DoSomething(objectB);

            //Example B
            using (ObjectA objectA2 = new ObjectA())
            {
                ObjectB objectB2 = new ObjectB();
                objectA2.DoSomething(objectB2);
            }
            #endregion

            //#region Question 3 - give a really short & simple answer as to why
            ////
            ////
            ////
            //#endregion

            #region Question 4 - improve this code

            // Anything goes... reorder / rename / restructure / create classes, variables, change it completely, anything.
            // Just stay within the Q3 region.

            PersonRepo personRepo = new PersonRepo();

            List<Person> person = personRepo.GetAll().ToList();

            person = person.Where(somebody => somebody.Age >= 18 & somebody.Age < 99).ToList();

            person = person.Where(somebody => somebody.Location == "UK").ToList();

            person = person.Where(somebody => somebody.FirstName.StartsWith("L")).ToList();

            #endregion

            //#region Question 5 - just for a bit of fun, what's this?

            //// extra point if you can tell me what it actually is...

            //int a = 3, b = 9, c = 24;
            //int theAnswer = (a * a) + (a * c) + (-b * a) + (-b * c);

            //#endregion

            //#region Question 6 - how would you go about getting a value from an Umbraco property?
            ////
            ////
            ////
            //#endregion

            //#region Answers + Question 6 - add the missing code

            //Answers.ForEach(answer => Console.WriteLine(answer));

            //Console.ReadLine();

            //#endregion
        }

    }
}
