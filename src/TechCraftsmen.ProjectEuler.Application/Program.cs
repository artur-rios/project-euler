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

        var problem = Startup.GetProblemByIndex(index);

        if (problem is null)
        {
            Console.WriteLine("Problem not found");

            return;
        }

        try
        {
            Console.WriteLine($"Solution to Problem {index}");
            Console.WriteLine($"\n{problem.Resolve(parameters)}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
    }
}