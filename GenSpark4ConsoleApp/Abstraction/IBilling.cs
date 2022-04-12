using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenSpark4ConsoleApp.Abstraction
{
 public interface IBilling
    {
        void M1();
        void M2();
    }
    public interface IInvoicing
    {

        void M3();
        void M4();
    }

    public partial class MyNormalClass: IBilling, IInvoicing
    {
        public void M1() { }
        public void M3() { }

    }

    public partial class MyNormalClass
    {
        public void M2() { }
        public void M4() { }
    }
}
