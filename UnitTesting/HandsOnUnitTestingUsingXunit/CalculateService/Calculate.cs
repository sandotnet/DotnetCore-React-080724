using System;
using System.Collections.Generic;

namespace CalculateService
{
    public class Calculate
    {
        public int Add(int a,int b)
        {
            int c = a + b;
            return c;
        }
        public int Div(int a,int b)
        {
            int c = a / b;
            return c;
        }
        public List<int> GetNos()
        {
            return new List<int>() { 1, 2, 3, 5 };
        }
    }
}
