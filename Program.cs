using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var keepAlive = true;
            while (keepAlive)
            {
                try
                {
                    Console.Write("Enter assignment number (or 0 to exit): ");
                    var assignmentChoice = int.Parse(Console.ReadLine() ?? "");
                    Console.ForegroundColor = ConsoleColor.Green;
                    switch (assignmentChoice)
                    {
                        case 1:
                            RunExerciseOne();
                            break;
                        case 2:
                            RunExerciseTwo();
                            break;
                        case 3:
                            RunExerciseThree();
                            break;
                        case 4:
                            RunExerciseFour();
                            break;
                        case 5:
                            RunExerciseFive();
                            break;
                        case 0:
                            keepAlive = false;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That is not a valid assigment number!");
                            break;
                    }
                    Console.ResetColor();
                    Console.WriteLine("Hit any key to continue!");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a valid assigment number!");
                    Console.ResetColor();
                }
            }
        }
        private static void RunExerciseOne()
        {
            Console.Write("First name: ");
            string fornamn = Console.ReadLine();
            Console.Write("Surname: ");
            string efternamn = Console.ReadLine();
            Console.WriteLine("Hello " + fornamn + " " + efternamn + "! I´m glad to inform you that you are the test subject of my very first assignment!");
        }
        private static void RunExerciseTwo()
        {
            Console.WriteLine("Todays date is " + DateTime.Today.Date.ToString("yyyy-MM-dd"));
            Console.WriteLine("Tomorrows date is " + DateTime.Today.Date.AddDays(1).ToString("yyyy-MM-dd"));
            Console.WriteLine("Yesterdays date was " + DateTime.Today.Date.AddDays(-1).ToString("yyyy-MM-dd"));
        }
        private static void RunExerciseThree()
        {
            Console.Write("Enter your first name: ");
            string fornamn = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string efternamn = Console.ReadLine();
            Console.WriteLine(fornamn + " " + efternamn);
        }
        private static void RunExerciseFour()
        {
            string str = ("The quick fox Jumped Over the DOG");
            Console.Write("Line before changes: ");
            Console.WriteLine(str);

            //output: “The brown fox jumped over the lazy dog”

            //1: Lowercase på hela strängen ---- ToLower
            string strOut = str.ToLower();

            //2: Uppercase på första bokstaven ---- FirstCharToUpper()
            strOut = char.ToUpper(strOut[0]) + strOut.Substring(1);

            //3: Ersätt "quick" med "brown"  ---- Replace
            strOut = strOut.Replace("quick", "brown");

            Console.Write("Line after changes: ");
            Console.WriteLine(strOut);
        }
        private static void RunExerciseFive()
        {
            //input = "Arrays are very common in programming, they look something like: [1,2,3,4,5]" 
            //1: Hitta index för "[" ---- IndexOf
            //2: Spara substring med index.  ---- SubString
            //3. Remove ",2,3"
            //4. Replace "]" with ",6,7,8,9,10]"
            //output = "[1,4,5,6,7,8,9,10]"
            string str = "Arrays are very common in programming, they look something like: [1,2,3,4,5]";
            Console.WriteLine("String to change: "+str);
            int index = str.IndexOf("[");
            string strOut = str.Substring(index);
            index = strOut.IndexOf(",2,3");
            strOut = strOut.Remove(index,4);
            strOut = strOut.Replace("]", ",6,7,8,9,10]");
            Console.WriteLine("Changed string: "+strOut);
        }
    }
}
