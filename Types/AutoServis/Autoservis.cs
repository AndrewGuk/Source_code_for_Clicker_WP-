using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types.People;
using Types.Interface;


namespace Types.AutoServis
{
    public class Autoservis <T> where T : People.People
    {
        public Autoservis()
        {
            StartPrice();
        }
        List<Transport> priceList = new List<Transport>();
        public void AddCarInServis(Transport transport)
        {
            priceList.Add(transport);
        }
        void StartPrice()
        {
            var car = new Car();
            var moto = new Motorcycle();
            var bike = new Bike();
            var bus = new Bus();
            var airplane = new Airplane();
            var helicopter = new Helicopter();
            var rollers = new Rollers();
            var truck = new Truck();
            var pickup = new Pickup();
            priceList.Add(car);
            priceList.Add(moto);
            priceList.Add(bike);
            priceList.Add(bus);
            priceList.Add(airplane);
            priceList.Add(helicopter);
            priceList.Add(rollers);
            priceList.Add(pickup);
            priceList.Add(truck);
        }
        public void PrintProperty()
        {
            foreach (var item in priceList)
            {
                Console.WriteLine($"Type: {item.ToString().Remove(0,6)}," +
                    $"\nName: {item.Name}," +
                    $"\nColor: {item.Color}," +
                    $"\nPrice: {item.Price}");
                Console.WriteLine();
            }
        }

        public void BuyTransport(People.People people, Transport transport)
        {
            if (people.BankAccount > transport.Price)
            {
                people.transports.Add(transport);
                Console.WriteLine($"Cach : {people.BankAccount}");
                people.BuyTransport(transport.Price);
                Console.WriteLine("DONE!");
                Console.WriteLine($"Cach : {people.BankAccount}");
            }
            else
                Console.WriteLine("GO WORK!");
        }
    }
}
