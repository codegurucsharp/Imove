using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class KthLargest
    {
        int[] heap = null;
        public KthLargest(int k, int[] nums)
        {
            heap = new int[k];

            for (int i = 0; i < heap.Length; i++)
            {
                heap[i] = int.MinValue;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                Add(nums[i]);
            }
          }

        public int Add(int val)
        {
            if (heap[0] < val)
            {
                heap[0] = val;
                Min_Heapify(heap, heap.Length - 1, 0);
            }

            return heap[0];
        }

        public int[] Min_Heapify(int[] a, int heapsize, int i)
        {
            int l = 2 * i + 1;
            int r = 2 * i + 2;
            int smallest = i;
            if (l <= heapsize && a[i] > a[l])
            {
                smallest = l;
            }

            if (r <= heapsize && a[smallest] > a[r])
            {
                smallest = r;
            }

            if (smallest != i)
            {
                // exchange
                int tmp = a[i];
                a[i] = a[smallest];
                a[smallest] = tmp;

                return Min_Heapify(a, heapsize, smallest);
            }

            return a;
        }
    }

    /**
     * Your KthLargest object will be instantiated and called as such:
     * KthLargest obj = new KthLargest(k, nums);
     * int param_1 = obj.Add(val);
     */
}
