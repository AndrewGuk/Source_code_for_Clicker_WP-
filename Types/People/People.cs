using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types.Interface;

namespace Types.People
{
    public class People : IPeople
    {
        public string Name { get; set; }
        public int BankAccount {  get; private set; }
        public Transport Transport { get; private set; }

        internal List<Transport> transports = new List<Transport>();
        internal void BuyTransport(int x) 
        {
            BankAccount -= x;
        }
        public void SellTransport(string x)
        {

            foreach (var item in transports)
            {
                if (item.Name == x)
                {
                    BankAccount += item.Price;
                    transports.Remove(item);
                    Console.WriteLine("You sell car");
                    Console.WriteLine(BankAccount.ToString());
                    return;
                }
            }
            Console.WriteLine($"You didn't have auto <{x}>( ");

        }
        public void DriveInSea()
        {

        }
        public void PrintProperty()
        {

        }
        public void Working()
        {
            BankAccount += 5555555;
        }
    }
}
