using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInterfaces
{
    interface IA
    {
        void M1();
        void Discount();
    }
    interface IB
    {
        void M2();
        void Discount();
    }
    class A : IA, IB
    {
        public void M1()
        {
            Console.WriteLine("M1:IA");
        }

        public void M2()
        {
            Console.WriteLine("M1:IB");
        }
        //explicit implementation
         void IA.Discount()
        {
            Console.WriteLine("IA:Discount");
        }
        void IB.Discount()
        {
            Console.WriteLine("IB:Dicsount");
        }
    }
    internal class Demo2
    {
        static void Main()
        {
            IA ob = new A();
            ob.M1();
            ob.Discount(); //Invoike IA Discount
            IB ob1 = new A();
            ob1.M2();
            ob1.Discount(); //invoke IB Discount
        }
    }
}
