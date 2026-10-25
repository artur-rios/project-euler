namespace ArturRios.ProjectEuler.Problems;

public static class EvenFibonacciNumbers
{
    /*
     * https://projecteuler.net/problem=2
     */
    public static int Solution(int limit)
    {
        var current = 1;
        var previous = current;
        var sum = 0;

        while (current <= limit)
        {
            var aux = current;
            
            current += previous;

            previous = aux;
            
            if (current % 2 == 0)
            {
                sum += current;
            }
        }

        return sum;
    }
}