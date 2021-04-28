using System;
using code;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test
{
    [TestClass]
    public class SumOfDigitsTests
    {
        [TestMethod]
        public void SumOfDigits_When123_ShouldReturn6()
        {
            // Arrange.
            var input = "123".ToCharArray();
            
            // Act.
            var result = Solution.SumOfDigits(input);
            
            // Assert.
            result.Should().Be(6);
        }
        
        [TestMethod]
        public void SumOfDigits_When0_ShouldReturn0()
        {
            // Arrange.
            var input = "0".ToCharArray();
            
            // Act.
            var result = Solution.SumOfDigits(input);
            
            // Assert.
            result.Should().Be(0);
        }
        
        [TestMethod]
        public void SumOfDigits_When1_ShouldReturn1()
        {
            // Arrange.
            var input = "1".ToCharArray();
            
            // Act.
            var result = Solution.SumOfDigits(input);
            
            // Assert.
            result.Should().Be(1);
        }
        
        [TestMethod]
        public void SumOfDigits_When2_ShouldReturn2()
        {
            // Arrange.
            var input = "2".ToCharArray();
            
            // Act.
            var result = Solution.SumOfDigits(input);
            
            // Assert.
            result.Should().Be(2);
        }
        
        [TestMethod]
        public void SumOfDigits_When9_ShouldReturn9()
        {
            // Arrange.
            var input = "9".ToCharArray();
            
            // Act.
            var result = Solution.SumOfDigits(input);
            
            // Assert.
            result.Should().Be(9);
        }
        
        [TestMethod]
        public void SumOfDigits_When10_ShouldReturn1()
        {
            // Arrange.
            var input = "10".ToCharArray();
            
            // Act.
            var result = Solution.SumOfDigits(input);
            
            // Assert.
            result.Should().Be(1);
        }
        
        [TestMethod]
        public void SumOfDigits_When10000_ShouldReturn1()
        {
            // Arrange.
            var input = "10000".ToCharArray();
            
            // Act.
            var result = Solution.SumOfDigits(input);
            
            // Assert.
            result.Should().Be(1);
        }
        
        [TestMethod]
        public void SumOfDigits_WhenBadInput_ShouldThrowEx()
        {
            // Arrange.
            var input = "dsf".ToCharArray();
            
            // Act.
            var action = new Action(() =>
            {
                Solution.SumOfDigits(input);
            });
            
            // Assert.
            action.Should().Throw<ArgumentOutOfRangeException>();
        }
    }
}