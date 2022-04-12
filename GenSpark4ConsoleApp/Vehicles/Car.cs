using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenSpark4ConsoleApp.Vehicles
{
    public class Car
    {
        public int id { get; set; }
        public string modelName { get; set; }
        public float fuelCapacity { get; set; }
        public float price { get; set; }
    }

    public class BMW: Car
    {
        public void M1() { }
    }

    public class Tesla: BMW
    {
    }
}
