using System.Collections.Generic;

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
            string userInput = Console.ReadLine();

            if (userInput == "2")
            {
                int.Parse(userInput);
                Console.WriteLine("That is correct!");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}
