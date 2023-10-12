using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Car
    {
        public double CurrentFuel;
        private double _fuelFor1Km;
        private double _millage;


        public string Model { get; set; }
        public string Brand { get; set; }

        public double Millage 
        { 
            get { return _millage; }
            set
            {
                if(value >= 0)
                {
                    _millage = value;
                }
            }
        }

        public double FuelFor1Km 
        {
            get
            {
                return _fuelFor1Km;
            }
            set
            {
                if(value > 0)
                {
                    this._fuelFor1Km = value;
                }
            } 
        }

        //public void FuelFor1KmSetter(double fuelFor1Km)
        //{
        //    if(fuelFor1Km > 0 && fuelFor1Km < 500)
        //    {
        //        this.FuelFor1Km = fuelFor1Km;
        //    }
        //}

        //public double FuelFor1KmGetter()
        //{
        //    return this.FuelFor1Km;
        //}

        public void Drive(int km)
        {
            if (CurrentFuel >= _fuelFor1Km*km) 
            {
                this.Millage += km;
                this.CurrentFuel -= _fuelFor1Km * km;
            }
            else
            {
                Console.WriteLine($"{km} km yola benzin yeterli deyil!");
            }
        }


        //public string GetFullInfo()
        //{
        //    return $"CurrentFuel: {CurrentFuel} - FuelFor1Km:  {FuelFor1Km} - Millage: {Millage}";
        //}
    }
}
