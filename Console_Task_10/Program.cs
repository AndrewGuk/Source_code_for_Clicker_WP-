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
            var air = new Airplane();
            var roller = new Rollers();

            //car.Name = "asdd";
            //moto.Name = "moto";
            //au.AddCarInServis(car);
            //au.AddCarInServis(moto);
            //au.AddCarInServis(air);
            //au.AddCarInServis(roller);
            au.PrintProperty();
            var people = new People();
            people.Working();

            au.BuyTransport(people, air);
            au.BuyTransport(people, moto);
            au.BuyTransport(people, car);

            ////au.BuyTransport(people, roller);
            ////people.SellTransport("asdd");
            Console.WriteLine("-------------");
            people.PrintProperty();
            //Console.WriteLine("-------------");
            //Console.WriteLine(people.BankAccount);
            ////people.PrintProperty();
            //Console.WriteLine("-------------");
            //people.RenameAuto("java", "Motorcycle");
            //people.RenameAuto("mercedes", "Car");
            //people.RenameAuto("boing", "Airplane");
            //people.RenameAuto("suka", "Rollers");
            //Console.WriteLine("-------------");
            //au.ChangeColor(people, car, Color.Red);
            //au.ChangeColor(people, moto, Color.Blue);
            //au.ChangeColor(people, roller, Color.Black);
            //au.ChangeColor(people, car, Color.Ping);
            ////au.ChangeColor(people, air, Color.Yellow);
            //Console.WriteLine("-------------");
            //people.PrintProperty();
            //Console.WriteLine("-------------");
            ////au.SellTransport(people, moto);
            ////Console.WriteLine("-------------");
            //people.PrintProperty();




        }
    }
}