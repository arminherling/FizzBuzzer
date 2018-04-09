using NUnit.Framework;
using FizzBuzzer;

namespace FizzBuzzer.Tests
{
    [TestFixture]
    public class FizzBuzzerTest
    {
        [Test]
        public void Convert_ReturnsNumberAsString_OnPassingInANumber()
        {
            var buzzer = new FizzBuzzer();

            var result = buzzer.Convert( 1 );

            Assert.AreEqual( 1.ToString(), result );
        }

        [Test]
        public void Convert_ReturnsFizz_OnPassingInThree()
        {
            var buzzer = new FizzBuzzer();

            var result = buzzer.Convert( 3 );

            Assert.AreEqual( "Fizz", result );
        }
    }
}
