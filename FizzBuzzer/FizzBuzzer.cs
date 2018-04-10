using System;
using System.Collections.Generic;

namespace FizzBuzzer
{
    public class FizzBuzzer
    {
        private List<Rule> ruleSet = new List<Rule>();

        public FizzBuzzer()
        {
            ruleSet.Add( new Rule( ( value ) => value % 3 == 0, "Fizz" ) );
            ruleSet.Add( new Rule( ( value ) => value % 5 == 0, "Buzz" ) );
        }

        public string Convert( int value )
        {
            string result = null;

            foreach( var rule in ruleSet )
            {
                result += rule.Apply( value );
            }

            return string.IsNullOrEmpty( result ) ? value.ToString() : result;
        }
    }
}
