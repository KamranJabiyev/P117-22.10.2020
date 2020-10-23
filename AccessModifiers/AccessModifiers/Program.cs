using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        //public int MyProperty { get; set; }
        static void Main(string[] args)
        {
            #region Virtual method,polymorphism
            //Car car = new Car("BMW", "X5", 25000);
            //Console.WriteLine(car.Info());
            //Console.WriteLine(car);

            //Bus bus = new Bus("Hyundai", "Elantra", 18600, 8);
            //Console.WriteLine(bus.Info());
            //Console.WriteLine(bus);
            #endregion

            #region Access Modifiers
            #region Public - class,all class members - field,method,property
            //Car car = new Car("BMW", "X5", 25000);
            //car.Brand = "Opel";
            //Console.WriteLine(car.Model);
            //car.Info();
            #endregion

            #region Private - all class members
            //Car car = new Car("BMW", "X5", 25000);
            //car.Speed = 100;
            //Console.WriteLine(car.Speed);
            //car.MyProperty = 100;
            //Console.WriteLine(car.MyProperty);
            //car.SetSpeed(220);
            //Console.WriteLine(car.GetSpeed());
            #endregion

            #region Protected - all class members
            //Car car = new Car("BMW", "X5", 25000);
            //car.hoursePower = 10;
            //Console.WriteLine(car.hoursePower);
            #endregion

            #region Public readonly - only fields
            //Car car = new Car("BMW", "X5", 25000,"Teal");
            //car.Brand = "";
            //car.Color = "";
            //Console.WriteLine(car.Color);
            #endregion

            #region Private Readonly - only fields
            //Car car = new Car("BMW", "X5", 25000, "Teal");
            //car.Year = 2000;
            //Console.WriteLine(car.Year);
            #endregion
            #endregion
        }
    }
}
