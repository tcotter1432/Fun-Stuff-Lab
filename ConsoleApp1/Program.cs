using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int activity, number, specific;
            String inMood = "null", suggestedAction, modeOfTransportation;
            Random rnd = new Random();

            string[,] ideas = new string[5, 4]
            {
                {"null","null","null","null" },
                {"stock car racing", "martial arts training","practice parkour","white-water rafting" },
                {"hiking","watch a good movie","play video games","stargazing" },
                {"skydiving","summit Everest","summit K2", "tornado chasing" },
                {"to Taco Bell", "to Coney Island", "to Andiamo's", "to your refrigerator" }
            };

            Console.WriteLine("Hello, user! what are you in the mood for?");
            Console.WriteLine("Here are your options: \n 1. Action \n 2. Chill times \n 3. Danger \n 4. Good food");
            activity = Convert.ToInt32(Console.ReadLine());

            while (inMood == "null")
            {
                switch (activity)
                {
                    case 1:
                        inMood = "action";
                        break;
                    case 2:
                        inMood = "chilling";
                        break;
                    case 3:
                        inMood = "danger";
                        break;
                    case 4:
                        inMood = "good food";
                        break;
                    default:
                        inMood = "null";
                        Console.WriteLine("You input an invalid option. Please try a number between 1 and 4.");
                        activity = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }
            specific = rnd.Next(1, 4);
            suggestedAction = ideas[activity, specific];
            Console.WriteLine("How many people are you bringing with you?");
            number = Convert.ToInt32(Console.ReadLine());
            if (number == 0)
            {
                modeOfTransportation = "sneakers";
            }
            else if (number >= 1 && number <= 4)
            {
                modeOfTransportation = "a sedan";
            }
            else if (number >=5 && number <= 10)
            {
                modeOfTransportation = "a Volkswagen bus";
            }
            else
            {
                modeOfTransportation = "an airplance";
            }
            Console.WriteLine("OK, if you're in the mood for " + inMood + " then you should go " + suggestedAction + " and travel in " + modeOfTransportation + "!");
            Console.WriteLine("Goodbye, take care and have fun!");
            Console.ReadLine();
        }
    }
}
