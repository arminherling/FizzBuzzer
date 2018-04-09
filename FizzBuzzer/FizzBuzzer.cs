using System;

namespace FizzBuzzer
{
    public class FizzBuzzer
    {
        public string Convert( int value )
        {
            if( value == 3 )
                return "Fizz";

            return value.ToString();
        }
    }
}
