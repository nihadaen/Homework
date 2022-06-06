using System;

namespace Homework
{
    public class ProductStockCountException:Exception
    {
        public ProductStockCountException(string msg):base(msg)
        {

        }
    }
}