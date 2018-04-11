using System.Collections.Generic;

namespace FizzBuzzer
{
    public class FizzBuzzer
    {
        private readonly List<Rule> ruleSet;

        public FizzBuzzer( List<Rule> rules = null )
        {
            ruleSet = rules ?? new List<Rule>();
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
