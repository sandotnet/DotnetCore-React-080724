using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassTypes
{
    class X
    {
        public virtual void M() { }
    }
    class Y:X
    {
        public sealed override void M() //sealed methods are not override further derived classes
        {
            base.M();
        }
    }
    class Z:Y
    {
        //public override void M()
        //{
        //    base.M();
        //}
    }
    class Demo3
    {
    }
}
