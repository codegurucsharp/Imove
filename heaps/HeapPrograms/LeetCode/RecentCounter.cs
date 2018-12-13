using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class RecentCounter
    {
        private LinkedList<int> ll = new LinkedList<int>();
        public RecentCounter()
        {

        }

        public int Ping(int t)
        {
            int ret = 0;
            ll.AddLast(t);
            foreach (var item in ll)
            {
                if (t - 3000 - item > 0) ret++;
            }
            return ret;
        }
    }

}
