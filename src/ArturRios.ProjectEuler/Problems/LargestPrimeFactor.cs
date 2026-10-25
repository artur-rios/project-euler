namespace ArturRios.ProjectEuler.Problems;

public static class LargestPrimeFactor 
{
    /*
     * https://projecteuler.net/problem=3
     */
    public static long Solution(long number)
    {
        long largestFactor = -1;

        // Step 1: Remove factors of 2
        while (number % 2 == 0)
        {
            largestFactor = 2;
            number /= 2;
        }

        // Step 2: Check odd factors
        for (long i = 3; i <= Math.Sqrt(number); i += 2)
        {
            while (number % i == 0)
            {
                largestFactor = i;
                number /= i;
            }
        }

        // Step 3: If number itself is prime and > 2
        if (number > 2)
        {
            largestFactor = number;
        }

        return largestFactor;
    }
}