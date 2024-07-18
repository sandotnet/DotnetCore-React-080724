using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnNewFeatures
{
    internal static class ExtensionMethods
    {
        public static int Sqaure(this int k)
        {
            return k * k;
        }
        public static string Reverse(this string s)
        {
            string temp = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                temp += s[i];
            }
            return temp;
        }
        public static bool IsNotNull(this Object obj)
        {
            return obj != null ? true : false;
        }
        public static bool IsEqual(this string s, string s2)
        {
            if (s.Equals(s2))
            {
                return true;
            }
            else return false;
        }
    }
}
