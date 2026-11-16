namespace ArturRios.ProjectEuler.Tests;

using Problems;

public class LargestPrimeFactorTests
{
    [Fact]
    public void GivenTheProblemsNumber_WhenFindingLargestPrimeFactor_ThenReturnsTheKnownAnswer()
    {
        // Given: Project Euler problem 3
        const long number = 600_851_475_143;

        // When
        var result = LargestPrimeFactor.Solution(number);

        // Then
        Assert.Equal(6857L, result);
    }

    [Fact]
    public void GivenTheProblemsExample_WhenFindingLargestPrimeFactor_ThenReturnsLargest()
    {
        // Given: 13195 = 5 * 7 * 13 * 29
        const long number = 13195;

        // When
        var result = LargestPrimeFactor.Solution(number);

        // Then
        Assert.Equal(29L, result);
    }

    [Theory]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(17)]
    [InlineData(97)]
    [InlineData(999_999_937)]
    public void GivenPrimeNumber_WhenFindingLargestPrimeFactor_ThenReturnsSameNumber(long number)
    {
        // When
        var result = LargestPrimeFactor.Solution(number);

        // Then
        Assert.Equal(number, result);
    }

    [Theory]
    [InlineData(4, 2)]
    [InlineData(1024, 2)]
    [InlineData(9, 3)]
    [InlineData(27, 3)]
    [InlineData(49, 7)]
    [InlineData(25, 5)]
    public void GivenPowerOfAPrime_WhenFindingLargestPrimeFactor_ThenReturnsThatPrime(long number, long expected)
    {
        // When
        var result = LargestPrimeFactor.Solution(number);

        // Then
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(6, 3)]
    [InlineData(10, 5)]
    [InlineData(15, 5)]
    [InlineData(35, 7)]
    [InlineData(30_030, 13)]
    public void GivenCompositeNumber_WhenFindingLargestPrimeFactor_ThenReturnsTheLargest(long number, long expected)
    {
        // When
        var result = LargestPrimeFactor.Solution(number);

        // Then
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(2_000_000_014, 1_000_000_007)]
    [InlineData(6_442_450_941, 2_147_483_647)]
    public void GivenALargePrimeTimesASmallOne_WhenFindingLargestPrimeFactor_ThenReturnsTheLargePrime(long number, long expected)
    {
        // When
        var result = LargestPrimeFactor.Solution(number);

        // Then
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(-7)]
    public void GivenANumberWithNoPrimeFactor_WhenFindingLargestPrimeFactor_ThenReturnsMinusOne(long number)
    {
        // Given: outside the problem, which asks about numbers above one; the implementation answers -1

        // When
        var result = LargestPrimeFactor.Solution(number);

        // Then
        Assert.Equal(-1L, result);
    }
}
