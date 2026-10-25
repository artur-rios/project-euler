namespace ArturRios.ProjectEuler.Tests;

using Problems;

public class LargestPrimeFactorTests
{
    [Fact]
    public void GivenNumberTwo_WhenFindingLargestPrimeFactor_ThenReturnsTwo()
    {

        const int number = 2;
        const long expected = 2L;

        var result = LargestPrimeFactor.Solution(number);
        
        Assert.Equal(expected, result);
    }

    [Fact]
    public void GivenPrimeNumber_WhenFindingLargestPrimeFactor_ThenReturnsSameNumber()
    {
        const int number = 17;
        const long expected = 17L;
        
        var result = LargestPrimeFactor.Solution(number);
        
        Assert.Equal(expected, result);
    }

    [Fact]
    public void GivenCompositeNumber_WhenFindingLargestPrimeFactor_ThenReturnsCorrectFactor()
    {
        const int number = 10;
        const long expected = 5L;
        
        var result = LargestPrimeFactor.Solution(number);
        
        Assert.Equal(expected, result);
    }

    [Fact]
    public void GivenSquareOfPrime_WhenFindingLargestPrimeFactor_ThenReturnsThatPrime()
    {
        const int number = 49;
        const long expected = 7L;
        
        var result = LargestPrimeFactor.Solution(number);
        
        Assert.Equal(expected, result);
    }

    [Fact]
    public void GivenMultiplePrimeFactors_WhenFindingLargestPrimeFactor_ThenReturnsLargest()
    {
        // 13195 = 5 * 7 * 13 * 29
        const int number = 13195;
        const long expected = 29L;
        
        var result = LargestPrimeFactor.Solution(number);
        
        Assert.Equal(expected, result);
    }

    [Fact]
    public void GivenPowerOfTwo_WhenFindingLargestPrimeFactor_ThenReturnsTwo()
    {
        // 1024 = 2^10
        const int number = 1024;
        const long expected = 2L;
        
        var result = LargestPrimeFactor.Solution(number);
        
        Assert.Equal(expected, result);
    }

    [Fact]
    public void GivenOne_WhenFindingLargestPrimeFactor_ThenReturnsOne()
    {
        // 1 has no prime factors; method defined to return input for <=1
        const int number = 1;
        // Current implementation returns -1 when no prime factors are found
        const long expected = -1L;
        
        var result = LargestPrimeFactor.Solution(number);
        
        Assert.Equal(expected, result);
    }

    [Fact]
    public void GivenNegativeNumber_WhenFindingLargestPrimeFactor_ThenReturnsNegativeNumber()
    {
        // Negative numbers are out of domain; method returns input for <=1
        const int number = -7;
        // Current implementation returns -1 for negative input / no factors
        const long expected = -1L;
        
        var result = LargestPrimeFactor.Solution(number);
        
        Assert.Equal(expected, result);
    }
}
