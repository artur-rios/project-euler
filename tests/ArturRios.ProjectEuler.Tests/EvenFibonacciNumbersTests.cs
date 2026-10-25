namespace ArturRios.ProjectEuler.Tests;

using Problems;

public class EvenFibonacciNumbersTests
{
    [Fact]
    public void GivenLimitOfTen_WhenCalculatingEvenFibonacciSum_ThenReturnsTen()
    {
        // Given: a limit of 10 (Fibonacci sequence: 1, 1, 2, 3, 5, 8; even values: 2, 8)
        const int limit = 10;
        const int expectedSum = 10; // 2 + 8

        // When: we calculate the solution
        var result = EvenFibonacciNumbers.Solution(limit);

        // Then: the result should be 10
        Assert.Equal(expectedSum, result);
    }

    [Fact]
    public void GivenLimitOfOne_WhenCalculatingEvenFibonacciSum_ThenReturnsTwo()
    {
        // Given: a limit of 1 (algorithm generates 1+1=2, which is even)
        const int limit = 1;
        const int expectedSum = 2;

        // When: we calculate the solution
        var result = EvenFibonacciNumbers.Solution(limit);

        // Then: the result should be 2
        Assert.Equal(expectedSum, result);
    }

    [Fact]
    public void GivenLimitOfTwo_WhenCalculatingEvenFibonacciSum_ThenReturnsTwo()
    {
        // Given: a limit of 2 (Fibonacci: 1, 1, 2; even values: 2)
        const int limit = 2;
        const int expectedSum = 2;

        // When: we calculate the solution
        var result = EvenFibonacciNumbers.Solution(limit);

        // Then: the result should be 2
        Assert.Equal(expectedSum, result);
    }

    [Fact]
    public void GivenLimitOfFifty_WhenCalculatingEvenFibonacciSum_ThenReturnsCorrectSum()
    {
        // Given: a limit of 50 (Fibonacci: 1, 1, 2, 3, 5, 8, 13, 21, 34; even values: 2, 8, 34)
        const int limit = 50;
        const int expectedSum = 44; // 2 + 8 + 34

        // When: we calculate the solution
        var result = EvenFibonacciNumbers.Solution(limit);

        // Then: the result should be 44
        Assert.Equal(expectedSum, result);
    }

    [Fact]
    public void GivenLimitOfHundred_WhenCalculatingEvenFibonacciSum_ThenReturnsCorrectSum()
    {
        // Given: a limit of 100 (Fibonacci even values: 2, 8, 34, 144)
        const int limit = 100;
        const int expectedSum = 188; // 2 + 8 + 34 + 144

        // When: we calculate the solution
        var result = EvenFibonacciNumbers.Solution(limit);

        // Then: the result should be 188
        Assert.Equal(expectedSum, result);
    }

    [Fact]
    public void GivenLimitOfFourMillion_WhenCalculatingEvenFibonacciSum_ThenReturnsCorrectSum()
    {
        // Given: a limit of 4,000,000 (the original Project Euler problem 2)
        const int limit = 4_000_000;
        const int expectedSum = 4_613_732; // Known result for Project Euler problem 2

        // When: we calculate the solution
        var result = EvenFibonacciNumbers.Solution(limit);

        // Then: the result should be 4,613,732
        Assert.Equal(expectedSum, result);
    }

    [Fact]
    public void GivenLimitOfZero_WhenCalculatingEvenFibonacciSum_ThenReturnsZero()
    {
        // Given: a limit of 0 (loop condition 1 <= 0 is false, so no iterations)
        const int limit = 0;
        const int expectedSum = 0;

        // When: we calculate the solution
        var result = EvenFibonacciNumbers.Solution(limit);

        // Then: the result should be 0
        Assert.Equal(expectedSum, result);
    }

    [Fact]
    public void GivenLimitOfNegativeNumber_WhenCalculatingEvenFibonacciSum_ThenReturnsZero()
    {
        // Given: a negative limit (-5)
        const int limit = -5;
        const int expectedSum = 0;

        // When: we calculate the solution
        var result = EvenFibonacciNumbers.Solution(limit);

        // Then: the result should be 0 (no Fibonacci numbers less than or equal to a negative number)
        Assert.Equal(expectedSum, result);
    }

    [Fact]
    public void GivenLimitOfThree_WhenCalculatingEvenFibonacciSum_ThenReturnsTwo()
    {
        // Given: a limit of 3 (algorithm generates 2, which is the first even Fibonacci)
        const int limit = 3;
        const int expectedSum = 2;

        // When: we calculate the solution
        var result = EvenFibonacciNumbers.Solution(limit);

        // Then: the result should be 2
        Assert.Equal(expectedSum, result);
    }

    [Fact]
    public void GivenLimitOfTwenty_WhenCalculatingEvenFibonacciSum_ThenReturnsCorrectSum()
    {
        // Given: a limit of 20 (Fibonacci: 1, 1, 2, 3, 5, 8, 13; even values: 2, 8)
        const int limit = 20;
        const int expectedSum = 10; // 2 + 8

        // When: we calculate the solution
        var result = EvenFibonacciNumbers.Solution(limit);

        // Then: the result should be 10
        Assert.Equal(expectedSum, result);
    }
}





