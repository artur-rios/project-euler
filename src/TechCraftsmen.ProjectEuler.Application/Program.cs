﻿namespace TechCraftsmen.ProjectEuler.Application;

// ReSharper disable once ClassNeverInstantiated.Global
public class Program
{
    public static void Main()
    {
        const int index = 2;

        var parameters = new Dictionary<string, object>();

        // Problem 1
        // parameters.Add("range", 1000);
        
        // Problem 2
        parameters.Add("limit", 4000000);
        
        // Problem 3
        // parameters.Add("numberToFactor", 600851475143);

        var problem = Startup.GetProblemByIndex(index);

        if (problem is null)
        {
            Console.WriteLine("Problem not found");

            return;
        }

        try
        {
            Console.WriteLine($"Problem {index}\n");
            Console.WriteLine($"{problem.Title}\n");
            Console.WriteLine($"{problem.Objective}\n");
            Console.WriteLine("Expected parameters:");
            PrintExpectedParameters(problem.ExpectedParameters);
            Console.WriteLine($"\nAnswer: {problem.Resolve(parameters)}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"\nError: {e.Message}");
        }
    }

    private static void PrintExpectedParameters(Dictionary<string, Type> requiredParameters)
    {
        foreach (var parameter in requiredParameters)
        {
            Console.WriteLine($"Name: {parameter.Key} | Type: {parameter.Value}");
        }
    }
}