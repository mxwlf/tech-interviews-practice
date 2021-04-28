using code;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test
{
    [TestClass]
    public class ConvertToIntegerTests
    {
        [TestMethod]
        public void ConvertToInteger_When0_ShouldReturn0()
        {
            // Arrange.
            const char c = '0';
            
            // Act.
            var result = Solution.ConvertToInteger(c);
            
            // Assert.
            result.Should().Be(0);
        }
        
        [TestMethod]
        public void ConvertToInteger_When1_ShouldReturn1()
        {
            // Arrange.
            const char c = '1';
            
            // Act.
            var result = Solution.ConvertToInteger(c);
            
            // Assert.
            result.Should().Be(1);
        }
        
        [TestMethod]
        public void ConvertToInteger_When9_ShouldReturn9()
        {
            // Arrange.
            const char c = '9';
            
            // Act.
            var result = Solution.ConvertToInteger(c);
            
            // Assert.
            result.Should().Be(9);
        }
        
        [TestMethod]
        public void ConvertToInteger_WhenOtherThanNumber_ShouldThrow()
        {
            // Arrange.
            const char c = 'a';
            
            // Act.
            var result = Solution.ConvertToInteger(c);
            
            // Assert.
            result.Should().Be(-1);
        }
        
    }
}