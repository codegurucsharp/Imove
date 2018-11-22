using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class PrintStackInReverse
    {
        public void PrintStack(Stack<int> st)
        {
            if (st.Count < 1) return;

            int s = st.Pop();
            PrintStack(st);
            Console.WriteLine(s);

            InsertAtBottom(st, s);
        }

        public void InsertAtBottom(Stack<int> st, int n)
        {
            if (st.Count < 1)
            {
                st.Push(n);
            }
            else
            {
                int temp = st.Pop();
                InsertAtBottom(st, n);
                st.Push(temp);
            }
        }

    }
}
