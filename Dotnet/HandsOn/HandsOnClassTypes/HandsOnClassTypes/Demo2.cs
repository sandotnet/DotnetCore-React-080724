using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassTypes
{
    //1. sealed classes are declare with sealed keyword
    //2. sealed classes ar not inherited
    //3. sealed classes are instatiated
    class A
    {
        public void M1() { }
    }
    sealed class B:A
    {
        public void M2() { }
    }
    class C
    {

    }
    class Demo2
    {
        static void Main()
        {
            B obj = new B();
            obj.M1();
            obj.M2();

        }
    }
}
