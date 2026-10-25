namespace ArturRios.ProjectEuler.Problems;

public static class MultiplesOf3Or5
{
    /*
     * https://projecteuler.net/problem=1
     */
    public static int Solution(int range)
    {
        var sum = 0;
		
        for (var i = 1; i < range; i++)
        {
            var multipleOfThree = i % 3 == 0;
            var multipleOfFive = i % 5 == 0;
			
            if (multipleOfThree || multipleOfFive) 
            {
                sum += i;
            }
        }
		
        return sum;
    }
}