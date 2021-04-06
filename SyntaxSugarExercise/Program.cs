using System;

namespace SyntaxSugarExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var answer = 4;
            string response;

            switch (answer)
            {
                case < 9:
                    response = $"{answer} is less than nine";
                    break;
                default:
                    response = $"{answer} greater than or equal to nine";
                    break;
            }
            Console.WriteLine(response);

        }
    }
}
