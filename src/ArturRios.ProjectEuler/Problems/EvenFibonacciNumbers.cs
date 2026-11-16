namespace ArturRios.ProjectEuler.Problems;

public static class EvenFibonacciNumbers
{
    /*
     * https://projecteuler.net/problem=2
     */
    public static int Solution(int limit)
    {
        var previous = 1;
        var current = 2;
        var sum = 0;

        while (current <= limit)
        {
            if (current % 2 == 0)
            {
                sum += current;
            }

            var aux = current;

            current += previous;

            previous = aux;
        }

        return sum;
    }
}