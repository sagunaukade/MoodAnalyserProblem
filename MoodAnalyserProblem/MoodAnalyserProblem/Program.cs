using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the mood analyser problems");

            //Creating MoodAnalyzer object
            MoodAnalyser moodAnalyzer = new MoodAnalyser("I am in Happy Mood");
            Console.WriteLine("Mood is" + moodAnalyzer.AnalyseMood());
            Console.ReadLine();
        }
      
    }
}
