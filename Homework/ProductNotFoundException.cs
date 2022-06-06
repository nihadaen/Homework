using System;

namespace Homework
{
    public class ProductNotFoundException:Exception
    {
        public ProductNotFoundException(string msg):base(msg)
        {

        }
    }
}