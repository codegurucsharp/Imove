using System;

namespace HeapPrograms
{
    public class Heap
    {
        public void BuildHeap()
        {
            var t = new int[] { 1, 3, 4, 5, 15, 18, 31, 30, 11, 23, 24, 90, 17, 67 };
            for (int i = t.Length / 2 - 1; i >= 0; i--)
            {
                t = Max_Heapify(t, t.Length - 1, i);
            }

            // Heap Sort
            int size = t.Length;
            for (int i = 0; i < t.Length; i++)
            {
                Console.Write(t[0] + " ");

                t[0] = t[size - 1];
                size--;
                t = Max_Heapify(t, size, 0);
            }

            t = new int[] { 1, 3, 4, 5, 15, 18, 31, 30, 11, 23, 24, 90, 17, 67 };

            for (int i = t.Length / 2 - 1; i >= 0; i--)
            {
                t = Min_Heapify(t, t.Length - 1, i);
            }

            Console.WriteLine("");
            // Heap Sort
            size = t.Length;
            for (int i = 0; i < t.Length; i++)
            {
                Console.Write(t[0] + " ");

                t[0] = t[size - 1];
                size--;
                t = Min_Heapify(t, size, 0);
            }

            Console.ReadLine();
        }
        public int[] Max_Heapify(int[] a, int heapsize, int i)
        {
            int l = 2 * i + 1;
            int r = 2 * i + 2;
            int largest = i;
            if (l <= heapsize && a[i] < a[l])
            {
                largest = l;
            }

            if (r <= heapsize && a[largest] < a[r])
            {
                largest = r;
            }

            if (largest != i)
            {
                // exchange
                int tmp = a[i];
                a[i] = a[largest];
                a[largest] = tmp;

                return Max_Heapify(a, heapsize, largest);
            }

            return a;
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
