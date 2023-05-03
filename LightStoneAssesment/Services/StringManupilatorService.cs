using System;
namespace LightStoneAssesment
{
	public class StringManupilatorService : IStringManupilatorService
	{

        public int inputParse(string numberOfCases)
        {
            return int.Parse(numberOfCases);
        }

        public void printOut(string text)
        {
            Console.WriteLine(text);

            Console.ReadKey();
        }
    
        public void stringManupilation(int numCases)
        {
            for (int i = 1; i <= numCases; i++)
            {
                string line = Console.ReadLine();
                string[] words = line.Split(' ');

                Array.Reverse(words);

                printOut($"Case {i}: {string.Join(" ", words)}");
            }
        }
    }
}

