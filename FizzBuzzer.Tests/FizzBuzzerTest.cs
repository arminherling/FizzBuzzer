using NUnit.Framework;
using FizzBuzzer;

namespace FizzBuzzer.Tests
{
    [TestFixture]
    public class FizzBuzzerTest
    {
        [Test]
        public void Convert_ReturnsNumberAsString_OnPassingInANumber( [Values( 1, 2, 4, 7, 8 )] int input )
        {
            var buzzer = new FizzBuzzer();

            var result = buzzer.Convert( input );

            Assert.AreEqual( input.ToString(), result );
        }

        [Test]
        public void Convert_ReturnsFizz_OnPassingInAMultipleOfThree( [Values( 3, 6, 9, 12, 18 )] int input )
        {
            var buzzer = new FizzBuzzer();

            var result = buzzer.Convert( input );

            Assert.AreEqual( "Fizz", result );
        }

        [Test]
        public void Convert_ReturnsBuzz_OnPassingInAMultipleOfFive( [Values( 5, 10, 20, 25, 35 )] int input )
        {
            var buzzer = new FizzBuzzer();

            var result = buzzer.Convert( input );

            Assert.AreEqual( "Buzz", result );
        }

        [Test]
        public void Convert_ReturnsFizzBuzz_OnPassingInFifteen()
        {
            var buzzer = new FizzBuzzer();

            var result = buzzer.Convert( 15 );

            Assert.AreEqual( "FizzBuzz", result );
        }
    }
}
