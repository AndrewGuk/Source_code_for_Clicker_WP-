using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types.People;

namespace Types.Work
{
    public class Work <T> where T : People.People
    {
        Random random = new Random();
        int tempCount;

        public void StartWork(People.People people)
        {
            people.transports.Sort(new TransportComparer((a, b) => b.Price - a.Price));
            string x = people.transports[0].ToString().Remove(0, 6);
            switch (x)
            {
                case "Car":
                    CarWork(people);
                    break;
                case "Motorcycle":
                    MotorcycleWork(people);
                    break;
                case "Bike":
                    BikeWork(people);
                    break;
                case "Bus":
                    BusWork(people);
                    break;
                case "Airplane":
                    AirplaneWork(people);
                    break;
                case "Helicopter":
                    HelicopterWork(people);
                    break;
                case "Rollers":
                    RollersWork(people);
                    break;
                case "Truck":
                    TruckWork(people);
                    break;
                case "Pickup":
                    PickupWork(people);
                    break;
                default:
                    NoneWork(people);
                    break;
            }
        }
        void CarWork(People.People people)
        {
            tempCount = random.Next(150, 700);
            people.AddBankAccount(tempCount);
            PrintCount(tempCount);
        }
        void MotorcycleWork(People.People people)
        {
            tempCount = random.Next(100, 500);
            people.AddBankAccount(tempCount);
            PrintCount(tempCount);
        }
        void BikeWork(People.People people)
        {
            tempCount = random.Next(20, 200);
            people.AddBankAccount(tempCount);
            PrintCount(tempCount);
        }
        void BusWork(People.People people)
        {
            tempCount = random.Next(200, 900);
            people.AddBankAccount(tempCount);
            PrintCount(tempCount);
        }
        void AirplaneWork(People.People people)
        {
            tempCount = random.Next(350, 2200);
            people.AddBankAccount(tempCount);
            PrintCount(tempCount);
        }
        void HelicopterWork(People.People people)
        {
            tempCount = random.Next(300, 2000);
            people.AddBankAccount(tempCount);
            PrintCount(tempCount);
        }
        void RollersWork(People.People people)
        {
            tempCount = random.Next(5, 25);
            people.AddBankAccount(tempCount);
            PrintCount(tempCount);
        }
        void TruckWork(People.People people)
        {
            tempCount = random.Next(350, 2000);
            people.AddBankAccount(tempCount);
            PrintCount(tempCount);
        }
        void PickupWork(People.People people)
        {
            tempCount = random.Next(250, 1100);
            people.AddBankAccount(tempCount);
            PrintCount(tempCount);
        }
        void NoneWork(People.People people)
        {
            tempCount = random.Next(1, 10);
            people.AddBankAccount(tempCount);
            PrintCount(tempCount);
        }
        void PrintCount(int tempCount)
        {
            Console.WriteLine($"Hooray! You have earned <{tempCount}>");
        }
    }


}
