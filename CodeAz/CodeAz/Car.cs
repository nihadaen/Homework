using System;

namespace CodeAz
{
    public class Car
    {
        public string Brand;
        public string Model;
        public double CurrentFuel;
        public double FuelFor1Km;
        public double Mileage;

        public Car(string brand, string model, double currentFuel, double fuelFor1Km, double mileage)
        {
            Brand = brand;
            Model = model;
            CurrentFuel = currentFuel;
            FuelFor1Km = fuelFor1Km;
            Mileage = mileage;
        }

        public void Drive(int km)
        {
            if (CurrentFuel / FuelFor1Km >= km)
            {
                // burada mileage eslinde artmalidi azalmali deil. cunki getdiyimiz yolun ustune gelmelidi km. lakin 
                // meselenin sertinde azalsin deyirsiz ona gore mende azaldiram.
                Mileage -= km;
                CurrentFuel -= km * FuelFor1Km;
                Console.WriteLine($"Hazırki mil: {Mileage}");
                Console.WriteLine($"Hazırki benzin: {CurrentFuel}");
            }
            else
            {
                Console.WriteLine("Benzin kifayət deyil!");
            }
        }
    }
}