namespace System.Numbers.UnitTests;

public class PrimeServiceTests
{
    [Fact]
    public void IsPrime_ReturnsTrue_ForPrimeNumber()
    {
        // Arrange
        var primeService = new PrimeService();
        int primeCandidate = 7;

        // Act
        bool result = primeService.IsPrime(primeCandidate);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsPrime_ReturnsFalse_ForNonPrimeNumber()
    {
        // Arrange
        var primeService = new PrimeService();
        int nonPrimeCandidate = 4;

        // Act
        bool result = primeService.IsPrime(nonPrimeCandidate);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsPrime_ReturnsFalse_ForNegativeNumber()
    {
        // Arrange
        var primeService = new PrimeService();
        int negativeCandidate = -3;

        // Act
        bool result = primeService.IsPrime(negativeCandidate);

        // Assert
        Assert.False(result);
    }
    [Fact]
    public void IsPrime_ReturnsFalse_ForZero()
    {
        // Arrange
        var primeService = new PrimeService();
    
        // Act
        bool result = primeService.IsPrime(0);
    
        // Assert
        Assert.False(result);
    }
    
    [Fact]
    public void IsPrime_ReturnsFalse_ForOne()
    {
        // Arrange
        var primeService = new PrimeService();
    
        // Act
        bool result = primeService.IsPrime(1);
    
        // Assert
        Assert.False(result);
    }
    
    [Fact]
    public void IsPrime_ReturnsFalse_ForNegativeNumber()
    {
        // Arrange
        var primeService = new PrimeService();
    
        // Act
        bool result = primeService.IsPrime(-5);
    
        // Assert
        Assert.False(result);
    }
    
    [Fact]
    public void IsPrime_ReturnsTrue_ForLargePrimeNumber()
    {
        // Arrange
        var primeService = new PrimeService();
        int largePrime = 7919; // Example of a large prime number
    
        // Act
        bool result = primeService.IsPrime(largePrime);
    
        // Assert
        Assert.True(result);
    }
    
    [Fact]
    public void IsPrime_ReturnsFalse_ForLargeNonPrimeNumber()
    {
        // Arrange
        var primeService = new PrimeService();
        int largeNonPrime = 8000; // Example of a large non-prime number
    
        // Act
        bool result = primeService.IsPrime(largeNonPrime);
    
        // Assert
        Assert.False(result);
    }
    
    [Fact]
    public void IsPrime_ReturnsTrue_ForTwo()
    {
        // Arrange
        var primeService = new PrimeService();
    
        // Act
        bool result = primeService.IsPrime(2);
    
        // Assert
        Assert.True(result);
    }
    
    [Fact]
    public void IsPrime_ReturnsFalse_ForEvenNumberGreaterThanTwo()
    {
        // Arrange
        var primeService = new PrimeService();
    
        // Act
        bool result = primeService.IsPrime(4);
    
        // Assert
        Assert.False(result);
    }
}
