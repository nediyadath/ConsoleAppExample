using GenSpark4ConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using a=ProjA;
using b=ProjB;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {

            a.test t = new a.test();

            MethodExamples em = new MethodExamples();
            
            string[] countries = {"India","Japan","USA" };
            em.ParamsExample(countries);
            int square = 0;int cube = 0;int quad = 0;
            em.Multiple(10, out square, out cube, out quad);
            Console.WriteLine($"The square of 10 is {square}, cube is {cube} and the quadruple is {quad}");
            Console.ReadLine();
        }
    }
}

namespace ProjA
{
    namespace A
    {
        namespace C
        {
            public class b
            {

            }
        }
    }
    public class test
    {

    }
}

namespace ProjB
{
    public class test
    {

    }
}

