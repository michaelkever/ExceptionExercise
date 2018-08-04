using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionExercise
{
    class Program
    {
        
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What is your age? \n Press Enter");

                int age = Convert.ToInt32(Console.ReadLine());
                var today = DateTime.Today.Year;
                int yearDate = Convert.ToInt32(today);
                int userBorn = (yearDate - age);

                if (age < 0)
                {
                    Console.WriteLine("Answer needs to be a real number, no decimals.");
                }
                if (age > 0)
                {
                    Console.WriteLine("You were born in {0}", userBorn);
                }
                  
            }
           catch (Exception)
            {
                Console.WriteLine("An error occurred. Please contact System Administator");
            }
            
            Console.ReadLine(); 
        }
    }
}
