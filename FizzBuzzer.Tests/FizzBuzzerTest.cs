using NUnit.Framework;

namespace FizzBuzzer.Tests
{
    [TestFixture]
    public class FizzBuzzerTest
    {
        private FizzBuzzer buzzer;

        [SetUp]
        public void Setup()
        {
            buzzer = new FizzBuzzBuilder()
                .WithFizzRule()
                .WithBuzzRule()
                .Build();
        }

        [Test]
        public void Convert_ReturnsNumberAsString_OnPassingInANumber( [Values( 1, 2, 4, 7, 8 )] int input )
        {
            var result = buzzer.Convert( input );

            Assert.AreEqual( input.ToString(), result );
        }

        [Test]
        public void Convert_ReturnsFizz_OnPassingInAMultipleOfThree( [Values( 3, 6, 9, 12, 18 )] int input )
        {
            var result = buzzer.Convert( input );

            Assert.AreEqual( "Fizz", result );
        }

        [Test]
        public void Convert_ReturnsBuzz_OnPassingInAMultipleOfFive( [Values( 5, 10, 20, 25, 35 )] int input )
        {
            var result = buzzer.Convert( input );

            Assert.AreEqual( "Buzz", result );
        }

        [Test]
        public void Convert_ReturnsFizzBuzz_OnPassingInAMultipleOfThreeAndFive( [Values( 15, 30, 45, 60, 75 )] int input )
        {
            var result = buzzer.Convert( input );

            Assert.AreEqual( "FizzBuzz", result );
        }

        [Test]
        public void Convert_ReturnsBang_OnPassingInAMultipleOfSevenWhileUsingACustomRule( [Values( 7, 14, 21, 28, 35 )] int input )
        {
            var customBuzzer = new FizzBuzzBuilder()
                .WithRule( ( i ) => i % 7 == 0, "Bang" )
                .Build();

            var result = customBuzzer.Convert( input );

            Assert.AreEqual( "Bang", result );
        }
    }
}
