using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInheritance
{
    class X
    {
        private int i;
        public int j;
        protected int k;
        internal int l;
        protected internal int m;
    }
    class Y:X
    {
        public void F()
        {
            //i is not acccess because of private
            j = 10;
            k = 20; //prtected variables are accessale in derived class
            l = 30;
            m = 40;
        }
    }
    class Demo1
    {
       static void Main()
        {
            X ob = new X();
            ob.j = 10;
            ob.l = 20;
            ob.m = 30;
            
            Y obj = new Y();
            obj.j = 10; //public members of X can access using Y obj
            obj.l = 20; //internal members of X can access using Y obj
            obj.m = 30;//protected internal members of X can access using Y obj
            
        }
    }
}
