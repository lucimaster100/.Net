using Lab2.Part_Three;
using Lab2.Part_Two;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            SolutionProviderWeather solutionOne = new SolutionProviderWeather("..\\..\\..\\Part One\\weather.dat");
            SolutionProviderFootball solutionTwo = new SolutionProviderFootball("..\\..\\..\\Part Two\\football.dat");
            solutionOne.ShowSmallestWeatherDifference();
            solutionTwo.GetTeamWithSmallestDifference();

        }
    }
}