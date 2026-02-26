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

        }
    }
}
