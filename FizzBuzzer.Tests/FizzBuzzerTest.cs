using NUnit.Framework;
using FizzBuzzer;

namespace FizzBuzzer.Tests
{
    [TestFixture]
    public class FizzBuzzerTest
    {
        [Test]
        public void Convert_ReturnsNumberAsString_OnPassingInANumber( [Values( 1, 2, 4, 6, 7 )] int input )
        {
            var buzzer = new FizzBuzzer();

            var result = buzzer.Convert( input );

            Assert.AreEqual( input.ToString(), result );
        }

        [Test]
        public void Convert_ReturnsFizz_OnPassingInThree()
        {
            var buzzer = new FizzBuzzer();

            var result = buzzer.Convert( 3 );

            Assert.AreEqual( "Fizz", result );
        }

        [Test]
        public void Convert_ReturnsBuzz_OnPassingInFive()
        {
            var buzzer = new FizzBuzzer();

            var result = buzzer.Convert( 5 );

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
