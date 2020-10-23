using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        private int _speed;

        protected int hoursePower;
        public int MyProperty { get;}

        public readonly string Color;
        private readonly int Year;

        

        public Car(string brand,string model,double price,string color)
        {
            Brand = brand;
            Model = model;
            Price = price;
            hoursePower = 2;
            Color = color;
            Year = 2000;
        }

        //encapsulation
        public int Speed
        {
            get
            {
                return _speed;
            }
            set
            {
                if (value <= 300 && value >= 80)
                {
                    _speed = value;
                    return;
                }
                Console.WriteLine("Duzgun suret heddi daxil edin");
            }
        }
        //public void SetSpeed(int speed)
        //{
        //    if (speed <= 300 && speed>=80)
        //    {
        //        _speed = speed;
        //        return;
        //    }
        //    Console.WriteLine("Duzgun suret heddi daxil edin");
        //}

        //public int GetSpeed()
        //{
        //    return _speed;
        //}


        public virtual string Info()
        {
            return $"brand:{Brand}; model:{Model}; price:{Price},speed:{_speed},{hoursePower},{Color},{Year}";
        }

        public override string ToString()
        {
            return Brand;
        }

        private void CarTest()
        {

        }
    }
}
