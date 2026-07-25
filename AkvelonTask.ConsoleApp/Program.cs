using System;
using AkvelonTask;

namespace AkvelonTask.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---  FizzBuzz Task ---");
            
            string input = "Mary had a little lamb\nLittle lamb, little lamb\nMary had a little lamb\nIt's fleece was white as snow";
            
            Console.WriteLine("\n[Input]");
            Console.WriteLine(input);

            var detector = new FizzBuzzDetector();
            
            try
            {
                var result = detector.getOverlappings(input);
                
                Console.WriteLine("\n[Result]");
                Console.WriteLine("output string:");
                Console.WriteLine(result.OutputString);
                Console.WriteLine($"\ncount: {result.Count}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError: {ex.Message}");
            }
        }
    }
}