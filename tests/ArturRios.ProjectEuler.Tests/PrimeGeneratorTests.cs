namespace ArturRios.ProjectEuler.Tests;

using Utils;

public class PrimeGeneratorTests
{
    private static int NthPrime(int n)
    {
        var generator = new PrimeGenerator();
        var prime = 0;

        for (var i = 0; i < n; i++)
        {
            prime = generator.GetNextPrime();
        }

        return prime;
    }

    [Fact]
    public void GivenANewGenerator_WhenAskedForPrimes_ThenTheyComeInOrderFromTwo()
    {
        // Given
        var generator = new PrimeGenerator();

        // When
        var primes = Enumerable.Range(0, 15).Select(_ => generator.GetNextPrime()).ToList();

        // Then
        Assert.Equal([2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47], primes);
    }

    [Theory]
    [InlineData(6, 13)]
    [InlineData(100, 541)]
    [InlineData(1000, 7919)]
    [InlineData(10001, 104743)]
    public void GivenAPosition_WhenAskingForThatManyPrimes_ThenTheLastIsTheKnownNthPrime(int n, int expected)
    {
        // When
        var prime = NthPrime(n);

        // Then
        Assert.Equal(expected, prime);
    }

    [Fact]
    public void GivenSquaresOfPrimes_WhenGeneratingPastThem_ThenNoneIsTakenForAPrime()
    {
        // Given
        var generator = new PrimeGenerator();

        // When
        var primes = Enumerable.Range(0, 30).Select(_ => generator.GetNextPrime()).ToList();

        // Then
        Assert.DoesNotContain(9, primes);
        Assert.DoesNotContain(25, primes);
        Assert.DoesNotContain(49, primes);
        Assert.DoesNotContain(121, primes);
    }

    [Fact]
    public void GivenTwoGenerators_WhenOneAdvances_ThenTheOtherStartsFromTwo()
    {
        // Given
        var first = new PrimeGenerator();
        first.GetNextPrime();
        first.GetNextPrime();

        // When
        var second = new PrimeGenerator().GetNextPrime();

        // Then
        Assert.Equal(2, second);
        Assert.Equal(5, first.GetNextPrime());
    }
}
