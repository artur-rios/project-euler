namespace ArturRios.ProjectEuler.Tests;

using Problems;

public class MultiplesOf3Or5Tests
{
    [Fact]
    public void GivenRangeOfTen_WhenCalculatingSum_ThenReturnsTwentyThree()
    {
        // Given: a range of 10 (should include 3, 5, 6, 9)
        const int range = 10;
        const int expectedSum = 23;

        // When: we calculate the solution
        var result = MultiplesOf3Or5.Solution(range);

        // Then: the result should be 23
        Assert.Equal(expectedSum, result);
    }

    [Fact]
    public void GivenRangeOfOne_WhenCalculatingSum_ThenReturnsZero()
    {
        // Given: a range of 1 (no multiples of 3 or 5 below 1)
        const int range = 1;
        const int expectedSum = 0;

        // When: we calculate the solution
        var result = MultiplesOf3Or5.Solution(range);

        // Then: the result should be 0
        Assert.Equal(expectedSum, result);
    }

    [Fact]
    public void GivenRangeOfThree_WhenCalculatingSum_ThenReturnsZero()
    {
        // Given: a range of 3 (no multiples of 3 or 5 below 3)
        const int range = 3;
        const int expectedSum = 0;

        // When: we calculate the solution
        var result = MultiplesOf3Or5.Solution(range);

        // Then: the result should be 0
        Assert.Equal(expectedSum, result);
    }

    [Fact]
    public void GivenRangeOfFour_WhenCalculatingSum_ThenReturnsThree()
    {
        // Given: a range of 4 (includes 3)
        const int range = 4;
        const int expectedSum = 3;

        // When: we calculate the solution
        var result = MultiplesOf3Or5.Solution(range);

        // Then: the result should be 3
        Assert.Equal(expectedSum, result);
    }

    [Fact]
    public void GivenRangeOfSix_WhenCalculatingSum_ThenReturnsEight()
    {
        // Given: a range of 6 (includes 3, 5)
        const int range = 6;
        const int expectedSum = 8;

        // When: we calculate the solution
        var result = MultiplesOf3Or5.Solution(range);

        // Then: the result should be 8 (3 + 5)
        Assert.Equal(expectedSum, result);
    }

    [Fact]
    public void GivenRangeOfTwenty_WhenCalculatingSum_ThenReturnsCorrectSum()
    {
        // Given: a range of 20 (includes 3, 5, 6, 9, 10, 12, 15, 18)
        const int range = 20;
        const int expectedSum = 78; // 3 + 5 + 6 + 9 + 10 + 12 + 15 + 18

        // When: we calculate the solution
        var result = MultiplesOf3Or5.Solution(range);

        // Then: the result should be 78
        Assert.Equal(expectedSum, result);
    }

    [Fact]
    public void GivenRangeOfThousand_WhenCalculatingSum_ThenReturnsCorrectSum()
    {
        // Given: a range of 1000 (the original Project Euler problem)
        const int range = 1000;
        const int expectedSum = 233168; // Known result for Project Euler problem 1

        // When: we calculate the solution
        var result = MultiplesOf3Or5.Solution(range);

        // Then: the result should be 233168
        Assert.Equal(expectedSum, result);
    }

    [Fact]
    public void GivenNegativeRange_WhenCalculatingSum_ThenReturnsZero()
    {
        // Given: a negative range (-10)
        const int range = -10;
        const int expectedSum = 0;

        // When: we calculate the solution
        var result = MultiplesOf3Or5.Solution(range);

        // Then: the result should be 0 (loop doesn't execute for negative or zero range)
        Assert.Equal(expectedSum, result);
    }

    [Fact]
    public void GivenZeroRange_WhenCalculatingSum_ThenReturnsZero()
    {
        // Given: a range of 0
        const int range = 0;
        const int expectedSum = 0;

        // When: we calculate the solution
        var result = MultiplesOf3Or5.Solution(range);

        // Then: the result should be 0
        Assert.Equal(expectedSum, result);
    }
}