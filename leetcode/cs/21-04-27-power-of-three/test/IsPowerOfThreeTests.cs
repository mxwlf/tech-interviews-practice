using code;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test
{
    [TestClass]
    public class IsPowerOfThreeTests
    {
        private static Solution _sol;

        public IsPowerOfThreeTests()
        {
            _sol = new Solution();
        }
        
        [TestMethod]
        public void IsPowerOfThree_When3_ShouldReturnTrue()
        {
            // Act.
            var result = _sol.IsPowerOfThree(3);
            
            // Assert.
            result.Should().BeTrue();
        }
        
        [TestMethod]
        public void IsPowerOfThree_When9_ShouldReturnTrue()
        {
            // Act.
            var result = _sol.IsPowerOfThree(9);
            
            // Assert.
            result.Should().BeTrue();
        }
        
        [TestMethod]
        public void IsPowerOfThree_When27_ShouldReturnTrue()
        {
            // Act.
            var result = _sol.IsPowerOfThree(27);
            
            // Assert.
            result.Should().BeTrue();
        }
        
        [TestMethod]
        public void IsPowerOfThree_When2187_ShouldReturnTrue()
        {
            // Act.
            var result = _sol.IsPowerOfThree(2187);
            
            // Assert.
            result.Should().BeTrue();
        }
        
        [TestMethod]
        public void IsPowerOfThree_When324_ShouldReturnFalse()
        {
            // Act.
            var result = _sol.IsPowerOfThree(324);
            
            // Assert.
            result.Should().BeFalse();
        }
        
        [TestMethod]
        public void IsPowerOfThree_When0_ShouldReturnFalse()
        {
            // Act.
            var result = _sol.IsPowerOfThree(0);
            
            // Assert.
            result.Should().BeFalse();
        }
        
        /// <summary>
        /// 1 is technically a power of 3 (or any base) : its the zero power.
        /// </summary>
        [TestMethod]
        public void IsPowerOfThree_When1_ShouldReturnTrue()
        {
            // Act.
            var result = _sol.IsPowerOfThree(1);
            
            // Assert.
            result.Should().BeTrue();
        }
        
        [TestMethod]
        public void IsPowerOfThree_When45_ShouldReturnFalse()
        {
            // Act.
            var result = _sol.IsPowerOfThree(45);
            
            // Assert.
            result.Should().BeFalse();
        }
        
        [TestMethod]
        public void IsPowerOfThree_WhenMinus27_ShouldReturnFalse()
        {
            // Act.
            var result = _sol.IsPowerOfThree(-27);
            
            // Assert.
            result.Should().BeFalse();
        }
    }
}