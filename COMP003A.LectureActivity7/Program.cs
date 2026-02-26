using System.Collections.Generic;
using System.Xml.Serialization;

namespace COMP003A.LectureActivity7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] scores = { 7, 9, 13, 14, 26};

            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine(scores[i]);
            }

            List<string> names = new List<string>();

            names.Add("Link");
            names.Add("Zelda");
            names.Add("Ganon");

            foreach (string i in names)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]); 
            }

            Console.Write("\nEnter a number between 1 and 3: ");

            try
            {
                int choice = int.Parse(Console.ReadLine());
                if (choice > 1 && choice < 3)
                {
                    Console.WriteLine($"{choice} is correct!");
                }
                else
                {
                    Console.WriteLine("Invalid number.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}
