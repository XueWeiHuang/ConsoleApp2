using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Q1_2_Permuatation: Program
    {
        public bool PermuteOrNot(string original, string totest)
        {
            if (original.Length != totest.Length)
                return false;
            var originalArray = original.ToCharArray();
            var totestArray = totest.ToCharArray();
            Array.Sort(originalArray);
            Array.Sort(totestArray);
            original = originalArray.ToString();
            totest = totestArray.ToString();
            return original.Equals(totest);
        }
    }
}
