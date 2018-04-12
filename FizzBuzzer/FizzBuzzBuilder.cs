using System;
using System.Collections.Generic;

namespace FizzBuzzer
{
    public class FizzBuzzBuilder
    {
        private List<Rule> rules = new List<Rule>();

        public FizzBuzzBuilder WithFizzRule() => WithRule( ( value ) => value % 3 == 0, "Fizz" );
        public FizzBuzzBuilder WithBuzzRule() => WithRule( ( value ) => value % 5 == 0, "Buzz" );

        public FizzBuzzBuilder WithRule( Func<int, bool> rule, string result )
        {
            rules.Add( new Rule( rule, result ) );

            return this;
        }

        public FizzBuzzer Build() => new FizzBuzzer( rules );
    }
}
