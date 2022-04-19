using LeetCode.Additional;
using Xunit;

namespace LeetCode.Tests.Additional
{
    public class SieveOfEratosthenesTest
    {
        [Fact]
        public void PrimeNumbersTest()
        {
            // arrange
            var n = 30;
            var expected = new[] {2, 3, 5, 7, 11, 13, 17, 19, 23, 29};
            var sieveOfEratosthenes = new SieveOfEratosthenes();

            // act
            var primes = sieveOfEratosthenes.PrimeNumbers(n);

            // assert
            Assert.Equal(expected, primes);
        }
    }
}