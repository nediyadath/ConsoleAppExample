using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenSpark4ConsoleApp
{
   public class EncapsulationExample
    {
        int x;
        public EncapsulationExample(int y)
        {
            x = y;
        }

        public int Square()
        {
            return x * x;
        }
    }
}
