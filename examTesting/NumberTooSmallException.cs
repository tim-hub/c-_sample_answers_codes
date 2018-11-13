using System;
namespace examTesting
{
    public class NumberTooSmallException:Exception
    {
        public NumberTooSmallException()
        {
        }

        public NumberTooSmallException(string message)
        : base(message)
        {
        }
    }
}
