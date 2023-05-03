using LightStoneAssesment;

namespace ReverseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            StringManupilatorService sm = new StringManupilatorService();

            sm.stringManupilation(sm.inputParse(Console.ReadLine()));

        }
    }
}