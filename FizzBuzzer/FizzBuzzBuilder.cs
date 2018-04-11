using System.Collections.Generic;

namespace FizzBuzzer
{
    public class FizzBuzzBuilder
    {
        private List<Rule> rules = new List<Rule>();

        public FizzBuzzBuilder WithFizzRule()
        {
            rules.Add( new Rule( ( value ) => value % 3 == 0, "Fizz" ) );

            return this;
        }

        public FizzBuzzBuilder WithBuzzRule()
        {
            rules.Add( new Rule( ( value ) => value % 5 == 0, "Buzz" ) );

            return this;
        }

        public FizzBuzzer Build()
        {
            return new FizzBuzzer( rules );
        }
    }
}
