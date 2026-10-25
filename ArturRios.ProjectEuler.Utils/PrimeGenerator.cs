namespace ArturRios.ProjectEuler.Utils;

public class PrimeGenerator
{
    private int _lastPrime = 1; // Start before the first prime

    public int GetNextPrime()
    {
        var candidate = _lastPrime + 1;

        while (!IsPrime(candidate))
        {
            candidate++;
        }

        _lastPrime = candidate;
        
        return candidate;
    }

    private static bool IsPrime(int number)
    {
        // Two is the first prime number
        if (number < 2)
        {
            return false;
        }
        
        if (number == 2)
        {
            return true;
        }
        
        // Any even number bigger than two is not prime
        if (number % 2 == 0)
        {
            return false;
        }

        /*
         * To test primality, you only need to check divisibility up to the square root of the number.
         * Reason: If a number has a factor larger than its square root, the corresponding paired factor must be smaller than the square root.
         * So checking up to √n covers all possible divisors.
         */
        var boundary = (int)Math.Sqrt(number);

        // If the candidate number divides evenly by any tested divisor, it’s not prime.
        for (var i = 3; i <= boundary; i += 2)
        {
            if (number % i == 0) return false;
        }

        return true;
    }
}