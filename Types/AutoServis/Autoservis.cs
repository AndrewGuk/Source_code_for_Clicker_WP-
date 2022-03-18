using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types.People;
using Types.Interface;
using System.Collections.ObjectModel;
using Types;


namespace Types.AutoServis
{
    public class Autoservis<T> where T : People.People 
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

            priceList.Add(truck);
            priceList.Add(helicopter);
            priceList.Add(airplane);
            priceList.Add(rollers);
            priceList.Add(bike);
            priceList.Add(moto);
            priceList.Add(car);
            priceList.Add(bus);
            priceList.Add(pickup);

            


        }
        public void PrintProperty()
        {
            priceList.Sort(new TransportComparer((a, b) => a.Price - b.Price));
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
                people.BuyTransport(transport.Price);
                people.transports.Add(transport);
                Console.WriteLine($"Nice! You bought <{transport.ToString().Remove(0,6)}>! Now let's earn more!!");
            }
            else
                Console.WriteLine("Oops, not enough funds, go work some more and come back!");
        }

        public void ChangeColor(People.People people, Transport transport , Color color)
        {
            foreach (var item in people.transports)
            {
                if (item.ToString() == transport.ToString())
                {
                    var oldColor = item.Color;
                    item.Color = color;
                    Console.WriteLine($"Nice, you change the color of the <{item.ToString().Remove(0,6)}>" +
                        $"from <{oldColor}> to <{color}>");
                    return;
                }
            }
            Console.WriteLine($"You didn't have auto <{transport.ToString().Remove(0, 6)}>( ");
        }

        public void SellTransport(People.People people, Transport transport)
        {
            if (people.transports.Contains(transport))
                {
                    people.transports.Remove(transport);
                    people.SellTransport(transport.Price);
                    Console.WriteLine($"Nice! You sold <{transport.Name}>");
                }
            else
              Console.WriteLine($"You don't have a <{transport.ToString().Remove(0,6)}>");
        }

    }
    


}
    

