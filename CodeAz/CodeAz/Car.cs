namespace CodeAz
{
    public class Car
    {
        public int FuelCapacity;
        public int CurrentFuel;


        public void AddFuel(int fuel)
        {
            if (!(CurrentFuel+fuel >= FuelCapacity))
            {
                CurrentFuel += fuel;
            }
        }
    }
}