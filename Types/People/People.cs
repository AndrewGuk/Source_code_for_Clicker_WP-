using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types.Interface;

namespace Types.People
{
    public class People : IPeople 
    {
        int _Level = 0;
        public int Level
        {
            get { return _Level; }
            private set
            {
                _Level = value;
            }
        }
        
        public string Name { get; set; }
        public int BankAccount {  get; private set; }

        internal List<Transport> transports = new List<Transport>();
        internal void BuyTransport(int x) 
        {
            BankAccount -= x;
        }
        internal void SellTransport(int price)
        {
            BankAccount += price;
        }
        public void DriveInSea()
        {
            if (BankAccount > 1000)
            {
                Console.WriteLine("EEEEU,  we'are going to sea!!");
                BankAccount -= 1000; //дописать
            }
            else
            {
                Console.WriteLine("Sorry,  you must work a lot");
            }
        }
        public void PrintProperty()
        {
            transports.Sort(new TransportComparer((a, b) => b.Price - a.Price));
            foreach (var item in transports)
            {
                Console.WriteLine($"Type: {item.ToString().Remove(0, 6)}," +
                    $"\nName: {item.Name}," +
                    $"\nColor: {item.Color}," +
                    $"\nPrice: {item.Price}");
                Console.WriteLine();
            }
        }
        public void Working()
        {
            BankAccount += 5555555;
        }
        public void RenameAuto( string newName, string typeCar)
        {
            foreach (var item in transports)
            {
                if (item.ToString().Remove(0, 6).ToLower() == typeCar.ToLower())
                {
                    item.Name = newName;
                    Console.WriteLine($"New name for <{item.ToString().Remove(0, 6)}> is {newName}, nice!");
                    return;
                }
            }
            Console.WriteLine($"I don't fint transport with type <{typeCar}>( ");
        }

        

        
        

    }
}
