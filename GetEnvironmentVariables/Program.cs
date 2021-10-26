using System;
using System.Collections;

namespace GetEnvironmentVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Listing of all your available environment variables");
            foreach (DictionaryEntry environmentVariable in Environment.GetEnvironmentVariables())
            {
                Console.WriteLine($"KEY: {environmentVariable.Key} VALUE: {environmentVariable.Value}");
            }
        }
    }
}