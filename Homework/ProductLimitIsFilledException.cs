using System;

namespace Homework
{
    public class ProductLimitIsFilledException : Exception
    {
        public ProductLimitIsFilledException(string msg) : base(msg)
        {

        }
    }
}