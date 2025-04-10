using System;
using Xunit;

namespace BankAccountApp.UnitTests
{
    public class BankAccountTests
    {
        private readonly BankAccount _bankAccount;

        public BankAccountTests()
        {
            _bankAccount = new BankAccount("123456", 1000.0, "John Doe", "Savings", DateTime.Now);
        }

        [Fact]
        public void Credit_IncreasesBalance()
        {
            // Arrange
            var account = new BankAccount("12345", 100, "John Doe", "Savings", DateTime.Now);

            // Act
            account.Credit(50);

            // Assert
            Assert.Equal(150, account.Balance);
        }

        [Fact]
        public void Credit_WithZeroAmount_ShouldNotChangeBalance()
        {
            // Arrange
            var account = new BankAccount("12345", 100, "John Doe", "Savings", DateTime.Now);

            // Act
            account.Credit(0);

            // Assert
            Assert.Equal(100, account.GetBalance());
        }

        [Fact]
        public void Debit_DecreasesBalance_WhenSufficientFunds()
        {
            // Arrange
            var account = new BankAccount("12345", 100, "John Doe", "Savings", DateTime.Now);

            // Act
            account.Debit(50);

            // Assert
            Assert.Equal(50, account.Balance);
        }

        [Fact]
        public void Debit_ThrowsException_WhenInsufficientFunds()
        {
            // Arrange
            var account = new BankAccount("12345", 100, "John Doe", "Savings", DateTime.Now);

            // Act & Assert
            Assert.Throws<Exception>(() => account.Debit(150));
        }

        [Fact]
        public void Debit_WithZeroAmount_ShouldNotChangeBalance()
        {
            // Arrange
            var account = new BankAccount("12345", 100, "John Doe", "Savings", DateTime.Now);

            // Act
            account.Debit(0);

            // Assert
            Assert.Equal(100, account.GetBalance());
        }

        [Fact]
        public void Transfer_TransfersFunds_WhenSufficientBalance()
        {
            // Arrange
            var account1 = new BankAccount("12345", 1000, "John Doe", "Savings", DateTime.Now);
            var account2 = new BankAccount("67890", 500, "Jane Doe", "Savings", DateTime.Now);

            // Act
            account1.Transfer(account2, 200);

            // Assert
            Assert.Equal(800, account1.Balance);
            Assert.Equal(700, account2.Balance);
        }

        [Fact]
        public void Transfer_ThrowsException_WhenInsufficientBalance()
        {
            // Arrange
            var account1 = new BankAccount("12345", 100, "John Doe", "Savings", DateTime.Now);
            var account2 = new BankAccount("67890", 500, "Jane Doe", "Savings", DateTime.Now);

            // Act & Assert
            Assert.Throws<Exception>(() => account1.Transfer(account2, 200));
        }

        [Fact]
        public void Transfer_ThrowsException_WhenExceedsLimitForDifferentOwners()
        {
            // Arrange
            var account1 = new BankAccount("12345", 1000, "John Doe", "Savings", DateTime.Now);
            var account2 = new BankAccount("67890", 500, "Jane Doe", "Savings", DateTime.Now);

            // Act & Assert
            Assert.Throws<Exception>(() => account1.Transfer(account2, 600));
        }

        [Fact]
        public void CalculateInterest_ReturnsCorrectInterest()
        {
            // Arrange
            var account = new BankAccount("12345", 1000, "John Doe", "Savings", DateTime.Now);

            // Act
            double interest = account.CalculateInterest(0.05);

            // Assert
            Assert.Equal(50, interest);
        }

        [Fact]
        public void CalculateInterest_WithZeroBalance_ShouldReturnZero()
        {
            // Arrange
            var account = new BankAccount("12345", 0, "John Doe", "Savings", DateTime.Now);

            // Act
            double interest = account.CalculateInterest(0.05);

            // Assert
            Assert.Equal(0, interest);
        }

        [Fact]
        public void GetBalance_ReturnsCorrectBalance()
        {
            // Arrange
            var account = new BankAccount("12345", 1000, "John Doe", "Savings", DateTime.Now);

            // Act
            double balance = account.GetBalance();

            // Assert
            Assert.Equal(1000, balance);
        }
    }
}
