using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenSpark4ConsoleApp
{
  public  class MethodExamples
    {
        int x = 100;
        //public, private, protected, internal, and protected internal
       //value, refernce, output, parameter array
        public void Multiple(int x, out int sq, out int cube, out int quad)
        {
            sq = x * x;
            cube = x * x * x;
            quad = x * x * x * x;
            Console.WriteLine(x * x * x * x * x);
         }

        public void ParamsExample(params string[] w)
        {
            foreach(string country in w)
            {
                Console.WriteLine(country);
            }
        }
        public int[] test(int x, int num)
        {
            int[] v = new int[num];
            for(int i = 0; i < num; i++)
            {
                v[0]=(int)Math.Pow(x,i+1);
            }
            return v;
        }
        public void MyMethod(ref int x)
        {
            x += 5;// x=x+5
            Console.WriteLine(x);
        }

        public static void M1()
        {

        }
    }
}
