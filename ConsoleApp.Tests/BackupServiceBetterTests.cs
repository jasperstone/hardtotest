using System;
using Xunit;
using Moq;

namespace ConsoleApp.Tests
{
    public class BackupServiceBetterTests
    {
        [Fact]
        public void Backup_ReturnsTrue_OnSaturday()
        {
            // Arrange
            var mockDTWrapper = new Mock<IDTWrapper>();
            var dt = new DateTime(2024, 6, 8); // Saturday
            mockDTWrapper.Setup(x => x.Now()).Returns(dt);
            var service = new BackupServiceBetter(mockDTWrapper.Object);

            // Act
            var result = service.Backup();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Backup_ReturnsFalse_OnNonSaturday()
        {
            // Arrange
            var mockDateTimeWrapper = new Mock<IDTWrapper>();
            mockDateTimeWrapper.Setup(x => x.Now()).Returns(new DateTime(2024, 6, 7)); // Friday
            var service = new BackupServiceBetter(mockDateTimeWrapper.Object);

            // Act
            var result = service.Backup();

            // Assert
            Assert.False(result);
        }
    }
}