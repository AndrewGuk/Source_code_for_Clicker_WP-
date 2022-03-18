using System.Collections.ObjectModel;
using Types.Interface;
using Types.AutoServis;


namespace Types
{
    public abstract class Transport : ITransport<Transport>
    {
        string _Name = "Unknow";
        Color _Color = Color.White;
        public string Name
        {
            set
            {
                value = value == null ? (value = _Name) : _Name = value;
            }
            get { return _Name; }
        }
        public int Price { get; set; }
        public Color Color
        {
            set
            {
                value = value == null ? (value = _Color) : _Color = value;
            }
            get { return _Color; }
        }
        public Transport Type { get; set; }
        public void TransportInfo()
        {
            Console.WriteLine($"Transport is {Type.ToString().Remove(0,6)}" +
                $"\n{Type.ToString().Remove(0, 6)} have name is {Name}" +
                $"\n{Name} costs {Price.ToString()}$" +
                $"\n{Name} have color - {Color.ToString()}");
        }

    }
    public class Car : Transport
    {
        public Car()
        {
            Price = 8000;
        }
    }
    public class Motorcycle : Transport
    {
        public Motorcycle()
        {
            Price = 5000;
        }
    }
    public class Bike : Transport
    {
        public Bike()
        {
            Price = 200;
        }
    }
    public class Bus : Transport
    {
        public Bus()
        {
            Price = 20000;
        }
    }
    public class Airplane : Transport
    {
        public Airplane()
        {
            Price = 100000;
        }
    }
    public class Helicopter : Transport
    {
        public Helicopter()
        {
            Price = 75000;
        }
    }
    public class Rollers : Transport
    {
        public Rollers()
        {
            Price = 50;
        }
    }
    public class Truck : Transport
    {
        public Truck()
        {
            Price = 50000;
        }
    }
    public class Pickup : Transport
    {
        public Pickup()
        {
            Price = 25000;
        }
    }

}

