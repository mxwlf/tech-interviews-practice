// using code;
// using FluentAssertions;
// using Microsoft.VisualStudio.TestTools.UnitTesting;
//
// namespace test
// {
//     [TestClass]
//     public class IsMultipleOfThreeTests
//     {
//         [TestMethod]
//         public void IsMultipleOfThree_When3_ShouldBeTrue()
//         {
//             // Arrange.
//             const int input = 3;
//             
//             // Act.
//             var result = Solution.IsMultipleOfThree(input);
//             
//             // Assert.
//             result.Should().BeTrue();
//         }
//         
//         [TestMethod]
//         public void IsMultipleOfThree_When0_ShouldBeFalse()
//         {
//             // Arrange.
//             const int input = 0;
//             
//             // Act.
//             var result = Solution.IsMultipleOfThree(input);
//             
//             // Assert.
//             result.Should().BeFalse();
//         }
//         
//         [TestMethod]
//         public void IsMultipleOfThree_When1_ShouldBeFalse()
//         {
//             // Arrange.
//             const int input = 1;
//             
//             // Act.
//             var result = Solution.IsMultipleOfThree(input);
//             
//             // Assert.
//             result.Should().BeFalse();
//         }
//         
//         [TestMethod]
//         public void IsMultipleOfThree_When9_ShouldBeTrue()
//         {
//             // Arrange.
//             const int input = 9;
//             
//             // Act.
//             var result = Solution.IsMultipleOfThree(input);
//             
//             // Assert.
//             result.Should().BeTrue();
//         }
//         
//         [TestMethod]
//         public void IsMultipleOfThree_When12_ShouldBeTrue()
//         {
//             // Arrange.
//             const int input = 12;
//             
//             // Act.
//             var result = Solution.IsMultipleOfThree(input);
//             
//             // Assert.
//             result.Should().BeTrue();
//         }
//         
//         [TestMethod]
//         public void IsMultipleOfThree_When21_ShouldBeTrue()
//         {
//             // Arrange.
//             const int input = 21;
//             
//             // Act.
//             var result = Solution.IsMultipleOfThree(input);
//             
//             // Assert.
//             result.Should().BeTrue();
//         }
//         
//         [TestMethod]
//         public void IsMultipleOfThree_WhenNonPowerMultiple324_ShouldBeTrue()
//         {
//             // Arrange.
//             const int input = 21;
//             
//             // Act.
//             var result = Solution.IsMultipleOfThree(input);
//             
//             // Assert.
//             result.Should().BeTrue();
//         }
//         
//         [TestMethod]
//         public void IsMultipleOfThree_WhenPowerAndMultiple59049_ShouldBeTrue()
//         {
//             // Arrange.
//             const int input = 21;
//             
//             // Act.
//             var result = Solution.IsMultipleOfThree(input);
//             
//             // Assert.
//             result.Should().BeTrue();
//         }
//     }
// }