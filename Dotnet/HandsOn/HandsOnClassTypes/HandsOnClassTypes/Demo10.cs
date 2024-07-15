using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassTypes
{
    interface IA<T>
    {
        T M1();
        T M2(T a, T b);
        T M3(T a, double b);
    }
    class Test1 : IA<int>
    {
        public int M1()
        {
            throw new NotImplementedException();
        }

        public int M2(int a, int b)
        {
            throw new NotImplementedException();
        }

        public int M3(int a, double b)
        {
            throw new NotImplementedException();
        }
    }
    class Test3 : IA<double>
    {
        public double M1()
        {
            throw new NotImplementedException();
        }

        public double M2(double a, double b)
        {
            throw new NotImplementedException();
        }

        public double M3(double a, double b)
        {
            throw new NotImplementedException();
        }
    }
    internal class Demo10
    {
    }
}
