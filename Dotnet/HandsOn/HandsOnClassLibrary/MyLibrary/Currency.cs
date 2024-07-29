using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Currency
    {
        public static double RTD(double rupees)//convert ruppee to doller
        {
            return rupees / 87.6;
        }
        public static double DTR(double dollers)
        {
            return dollers * 87.6;
        }

    }
}
