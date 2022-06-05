namespace Homework
{
    public class Product
    {
        private string _no;
        private string _name;
        private double _price;
        private int _count;
        
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
            }
        }

        public string No
        {
            get => _no;
            set
            {
                _no = value;
            }
        }

        public double Price
        {
            get => _price;
            set
            {
                _price = value;
            }
        }

        public int Count
        {
            get => _count;
            set
            {
                _count = value;
            }
        }
    }
}