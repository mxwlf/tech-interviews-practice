using code;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test
{
    [TestClass]
    public class IsSingleDigitMultipleTests
    {
        [TestMethod]
        public void IsSingleDigitMultiple_WhenMultiple3_ShouldReturnTrue()
        {
            // Arrange.
            const int input = 3;
            
            // Act.
            var result = Solution.IsSingleDigitMultiple(input);
            
            // Assert.
            result.Should().BeTrue();
        }
        
        [TestMethod]
        public void IsSingleDigitMultiple_WhenMultiple6_ShouldReturnTrue()
        {
            // Arrange.
            const int input = 6;
            
            // Act.
            var result = Solution.IsSingleDigitMultiple(input);
            
            // Assert.
            result.Should().BeTrue();
        }
        
        [TestMethod]
        public void IsSingleDigitMultiple_WhenMultiple9_ShouldReturnTrue()
        {
            // Arrange.
            const int input = 9;
            
            // Act.
            var result = Solution.IsSingleDigitMultiple(input);
            
            // Assert.
            result.Should().BeTrue();
        }
        
        [TestMethod]
        public void IsSingleDigitMultiple_WhenMultiple1_ShouldReturnFalse()
        {
            // Arrange.
            const int input = 1;
            
            // Act.
            var result = Solution.IsSingleDigitMultiple(input);
            
            // Assert.
            result.Should().BeFalse();
        }
        
        [TestMethod]
        public void IsSingleDigitMultiple_WhenNonMultiple0_ShouldReturnFalse()
        {
            // Arrange.
            const int input = 0;
            
            // Act.
            var result = Solution.IsSingleDigitMultiple(input);
            
            // Assert.
            result.Should().BeFalse();
        }
        
        [TestMethod]
        public void IsSingleDigitMultiple_WhenNonMultiple4_ShouldReturnFalse()
        {
            // Arrange.
            const int input = 0;
            
            // Act.
            var result = Solution.IsSingleDigitMultiple(input);
            
            // Assert.
            result.Should().BeFalse();
        }
    }
}