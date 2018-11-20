namespace LeetCode
{
    public class KthLargestElementInStreamSolution
    {
        int[] heap;
        public int FindKthLargest(int[] nums, int k)
        {
            heap = new int[k];

            for (int i = 0; i < k; i++)
            {
                heap[i]=int.MinValue;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                Add(nums[i]);
            }

            return heap[0];
        }

        public void Add(int a)
        {
            if(heap[0]<a)
            {
                heap[0] = a;
                Min_Heapify(heap, heap.Length-1, 0);
            }
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
}
