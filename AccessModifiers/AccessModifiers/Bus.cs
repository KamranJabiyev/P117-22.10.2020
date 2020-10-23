using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class Bus:Car
    {
        public int PassengerCount;
        public Bus(string brand,string model,double price,int passengerCount,string color):base(brand,model,price, color)
        {
            PassengerCount = passengerCount;
            hoursePower = 4;
        }

        //polymorphism
        public override string Info()
        {
            return base.Info()+","+"passenger Count:"+ PassengerCount;
        }

        public override string ToString()
        {
            return Model;
        }

        public void Test()
        {
            Info();
            Brand = "Mercedes";
            Console.WriteLine(Brand+" "+hoursePower+" "+Color);
        }
    }
}
