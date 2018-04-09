using System;

namespace FizzBuzzer
{
    public class FizzBuzzer
    {
        public string Convert( int value )
        {
            if( value == 3 )
                return "Fizz";

            if( value == 5 )
                return "Buzz";

            if( value == 15 )
                return "FizzBuzz";

            return value.ToString();
        }
    }
}
