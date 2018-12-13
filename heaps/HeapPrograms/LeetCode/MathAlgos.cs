using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class MathAlgos
    {
        public int ArrangeCoins(int n)
        {
            var res = (-0.5 +  2*Math.Sqrt(0.0625 + n/2.0 ));

            return (int)Math.Floor(res);
        }
    }
}
