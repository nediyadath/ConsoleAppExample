using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenSpark4ConsoleApp.Models
{
    //custom type, POCO class, entity, Model
    public class Patient
    {
        public int id { get; set; }
        public string name { get; set; }
        public string allergies { get; set; }
        public float temp { get; set; }
    }
}
