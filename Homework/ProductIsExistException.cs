using System;

namespace Homework
{ 
    public class ProductIsExistException:Exception
        {
            public ProductIsExistException(string msg):base(msg)
            {
                
            }
    }
}