using System;
using System.IO;
using System.Linq;

namespace PerformanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (new ExecutionTimer("Data conversion"))
            {
                using (var outputFile = new StreamWriter("result.txt"))
                {
                    int counter = 0;

                    foreach (var line in File.ReadLines("..\\..\\traveldata.txt").Take(50000))
                    {
                        var travelData = MapToObject(line);

                        outputFile.WriteLine($"{travelData.Name},{string.Join(",", travelData.VisitedStates.Select(s => s.Name))}");

                        if (++counter % 1000 == 0) Console.WriteLine(counter);
                    }
                }
            }
        }

        static TravelData MapToObject(string source)
        {
            var parts = source.Split(',');
            var result = new TravelData
            {
                Name = parts[0],
                VisitedStates = parts.Skip(1).Select(UsState.FromCode).ToList()
            };
            return result;
        }
    }
}
