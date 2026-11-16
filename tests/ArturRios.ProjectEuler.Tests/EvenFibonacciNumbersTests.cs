namespace ArturRios.ProjectEuler.Tests;

using Problems;

public class EvenFibonacciNumbersTests
{
    [Fact]
    public void GivenTheProblemsLimitOfFourMillion_WhenCalculatingEvenFibonacciSum_ThenReturnsTheKnownAnswer()
    {
        // Given: Project Euler problem 2
        const int limit = 4_000_000;

        // When
        var result = EvenFibonacciNumbers.Solution(limit);

        // Then
        Assert.Equal(4_613_732, result);
    }

    [Theory]
    [InlineData(2, 2)]
    [InlineData(8, 10)]
    [InlineData(34, 44)]
    [InlineData(144, 188)]
    public void GivenALimitThatIsAnEvenTerm_WhenCalculatingEvenFibonacciSum_ThenTheTermIsIncluded(int limit, int expectedSum)
    {
        // When
        var result = EvenFibonacciNumbers.Solution(limit);

        // Then
        Assert.Equal(expectedSum, result);
    }

    [Theory]
    [InlineData(3, 2)]
    [InlineData(10, 10)]
    [InlineData(20, 10)]
    [InlineData(50, 44)]
    public void GivenALimitBetweenTerms_WhenCalculatingEvenFibonacciSum_ThenOnlyTheEvenTermsUpToItCount(int limit, int expectedSum)
    {
        // When
        var result = EvenFibonacciNumbers.Solution(limit);

        // Then
        Assert.Equal(expectedSum, result);
    }

    [Theory]
    [InlineData(1, 0)]
    [InlineData(7, 2)]
    [InlineData(33, 10)]
    [InlineData(100, 44)]
    [InlineData(143, 44)]
    public void GivenALimitBelowTheNextEvenTerm_WhenCalculatingEvenFibonacciSum_ThenThatTermIsLeftOut(int limit, int expectedSum)
    {
        // When
        var result = EvenFibonacciNumbers.Solution(limit);

        // Then
        Assert.Equal(expectedSum, result);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-5)]
    public void GivenALimitBelowTheFirstTerm_WhenCalculatingEvenFibonacciSum_ThenReturnsZero(int limit)
    {
        // When
        var result = EvenFibonacciNumbers.Solution(limit);

        // Then
        Assert.Equal(0, result);
    }
}
