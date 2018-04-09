using System;

namespace FizzBuzzer
{
    public class FizzBuzzer
    {
        public string Convert( int value )
        {
            string result = null;

            if( value % 3 == 0 )
                result += "Fizz";

            if( value % 5 == 0 )
                result += "Buzz";

            return result ?? value.ToString();
        }
    }
}
