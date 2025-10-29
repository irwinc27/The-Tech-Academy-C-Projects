using System;


namespace Daily_Report_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Academy of Learning Career College");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("What page number?");
            int page =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string needHelp = Console.ReadLine();
            bool helpStatus = bool.Parse(needHelp);
            Console.WriteLine("Is there any other feedback you'd like to share? Please give specifics");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hoursStudy = Console.ReadLine();
            int studyHours = Convert.ToInt32(hoursStudy);
            Console.WriteLine("Thankyou for your answers. An instructor will respond to this shortly");
            Console.ReadLine();





        }
    }
}
