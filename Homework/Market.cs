using System;

namespace Homework
{
    public class Market:IStore
    {
        public Market()
        {
            _products = new Product[0];
        }
        private Product[] _products;
        public Product[] Products { get=>_products ; }
        private double _totalIncome;
        
        public int ProductLimit { get; set; }
        public double TotalIncome { get =>_totalIncome; }
        public void AddProduct(Product product)
        {
            bool check = false;
            if (_products.Length == 0)
            {
                check = true;
            }
            for (int i = 0; i < _products.Length; i++)
            {
                if (_products[i].No != product.No)
                {
                    check = true;
                }
            }

            if (check == false)
            {
                Console.WriteLine("Eyni No dəyərli məhsul mövcuddur!");
            }
            else if (_products.Length < ProductLimit)
            {
                Array.Resize(ref _products, _products.Length + 1);
                _products[_products.Length - 1] = product;
                Console.WriteLine("Məhsul əlavə edildi!");
            }
        }

        public void SellProduct(string no)
        {
            bool check = false;
            double price = 0;
            int cn = 0;
            for (int i = 0; i < _products.Length; i++)
            {
                if (_products[i].No == no && _products[i].Count > 0)
                {
                    cn = i;
                    price = _products[i].Price;
                    check = true;
                }
            }
            if (check)
            {
                _totalIncome += price;
                _products[cn].Count--;
                Console.WriteLine($"Məhsul satıldı - Total Income: {_totalIncome}");
            }
            else
            {
                Console.WriteLine("Satmaq istədiyiniz məhsul mövcüd deyil!");
            }
        }
    }
}