using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDelegates
{
    //Covariance in C#
    //Covariance enable you to pass a derived type where a base type is expected

    // Contravariance in C#
    //Contravariance is applied to parameters
    //Contravariance allows a method with the paramater of a base class to be assigned to a
    //delegate that expects parameter of a derived class
    public delegate Small CovarDel(Big big); //delegate
    public class Small
    {

    }
    public class Big : Small
    {

    }
    public class Bigger : Big
    {

    }
    internal class Demo3
    {
        public Small M1(Big big)
        {
            return new Small();
        }
        public static Big M2(Big big)
        {
            return new Big();
        } //appliced covarience
        public static Small M3(Small small) //appliced contravarience
        {
            return new Small();
        }
        public static Big M4(Small big)
        { //applied co and contravarience
            {
                return new Big();
            }
            static void Main()
            {
                Small ob = new Small();
                Small ob1 = new Big();
                //Big ob2=new Small(); //not possible
                CovarDel d1 = new Demo3().M1;
                CovarDel d2 = M2;
                d1(new Big());


            }
        }
    }
}
