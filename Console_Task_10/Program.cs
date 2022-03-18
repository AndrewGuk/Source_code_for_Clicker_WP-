using System;
using Types;
using Types.People;
using Types.AutoServis;



namespace Console_Task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var au = new Autoservis<People>();
            var car = new Car();
            var moto = new Motorcycle();
            car.Name = "asdd";
            moto.Name = "moto";
            au.AddCarInServis(car);
            au.AddCarInServis(moto);
            au.PrintProperty();
            var people = new People();
            people.Working();
            
            //people.BankAccount = 500000;
            au.BuyTransport(people, moto);
            au.BuyTransport(people, car);
            people.SellTransport("asdd");





        }
    }
}