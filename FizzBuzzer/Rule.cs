using System;

namespace FizzBuzzer
{
    public class Rule
    {
        private Func<int, bool> validator;
        private string output;

        public Rule( Func<int, bool> rule, string result )
        {
            validator = rule;
            output = result;
        }

        public string Apply( int value ) => validator.Invoke( value ) ? output : string.Empty;
    }
}
