using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInheritance
{
    public class AA
    {
        public void M() { }
    }
    
    public class BB : AA
    {
        public void M1() { }
    }
    public class CC : BB
    {
        public void M2() { }
    }

    class Demo5
    {
        static void Main()
        {
            AA ob = new AA();
            ob.M();
            BB ob1 = new BB();
            ob1.M();
            ob1.M1();
            CC ob2 = new CC();
            ob2.M();
            ob2.M1();
            ob2.M2();
        }
    }
}
