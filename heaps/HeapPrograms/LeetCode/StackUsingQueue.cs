using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class StackUsingQueue
    {
        private Queue<int> q;
        private Queue<int> auxQ;
        private int top;
        /** Initialize your data structure here. */
        public StackUsingQueue()
        {
            q = new Queue<int>();
            auxQ = new Queue<int>();
        }

        /** Push element x onto stack. */
        public void Push(int x)
        {
            top = x;
            q.Enqueue(x);
        }

        /** Removes the element on top of the stack and returns that element. */
        public int Pop()
        {
            top = -1;
            if (q.Count < 1)
            {
                return -1;
            }

            if(q.Count == 1)
            {
                return q.Dequeue();
            }

            while (q.Count > 1)
            {
                top = q.Dequeue();
                auxQ.Enqueue(top);
            }

            var retValue = q.Dequeue();

            // Exchange as there is not need to copy again
            var tempQ = q;
            q = auxQ;
            auxQ = tempQ;

            return retValue;
        }

        /** Get the top element. */
        public int Top()
        {
            return this.top;
        }

        /** Returns whether the stack is empty. */
        public bool Empty()
        {
            return q.Count < 1;
        }

        /**
         * Your MyStack object will be instantiated and called as such:
         * MyStack obj = new MyStack();
         * obj.Push(x);
         * int param_2 = obj.Pop();
         * int param_3 = obj.Top();
         * bool param_4 = obj.Empty();
         */
    }
}
